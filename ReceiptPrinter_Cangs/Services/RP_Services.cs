using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using System.Data.SQLite;
using ReceiptPrinter_Cangs.Models;

namespace ReceiptPrinter_Cangs.Services
{
    public class RP_Services
    {
        readonly String_Path _strPath = new String_Path();
        SQLiteConnection sqliteConnection;

        public RP_Services()
        {

        }

        public int SaveReceiptDetails(DTO_Receipt receipt)
        {
            try
            {
                using (var db = new LiteDatabase(_strPath.liteDB_Path()))
                {
                    var col = db.GetCollection<DTO_Receipt>("tblReceiptDetails");

                    var res = col.Insert(receipt);
                    if (res > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public List<DTO_Receipt> GetReceiptList()
        {
            try
            {
                using (var db = new LiteDatabase(_strPath.liteDB_Path()))
                {
                    var col = db.GetCollection<DTO_Receipt>("tblReceiptDetails");

                    var res = col.Query().ToList();
                    if (res.Count > 0)
                    {
                        return res;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<DTO_Customer> GetCustomerList(string customerName)
        {
            try
            {
                using (var db = new LiteDatabase(_strPath.liteDB_Path()))
                {
                    var col = db.GetCollection<DTO_Customer>("customer");

                    var res = col.Query()
                        .Where(customer => customer.Customer_Name.StartsWith(customerName))
                        .Limit(7)
                        .ToList();

                    return res;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int SaveCustomer(DTO_Customer receipt)
        {
            try
            {
                using (var db = new LiteDatabase(_strPath.liteDB_Path()))
                {
                    var col = db.GetCollection<DTO_Customer>("customer");

                    var res1 = col.Query()
                    .Where(customer => customer.Customer_Name == receipt.Customer_Name)
                    .Limit(1).FirstOrDefault();

                    if (res1 != null)
                    {
                        res1.Address = receipt.Address;
                        res1.Business_Style = receipt.Business_Style;
                        res1.TIN = receipt.TIN;

                        var resupdate = col.Update(res1);

                        if (resupdate)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        var res = col.Insert(receipt);
                        if (res > 0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
