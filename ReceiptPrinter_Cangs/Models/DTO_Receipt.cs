using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptPrinter_Cangs.Models
{
    public class DTO_Receipt
    {
        public int ID { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime DateTimeAdded { get; set; }
        public long ReceiptNumber { get; set; }
        public string ReceivedFrom { get; set; }
        public string Address { get; set; }
        public string TIN { get; set; }
        public string BusinessStyle { get; set; }
        public decimal Amount { get; set; }
        public string AuthorizeCashierID { get; set; }
        public string Payment_For { get; set; }
        public bool isFull_Payment { get; set; }
    }

    public class DTO_Cashier
    {
        public int CashierID { get; set; }
        public int CashierName { get; set; }
    }

    public class DTO_Customer
    {
        public int ID { get; set; }
        public string Customer_Name { get; set; }
        public string Address { get; set; }
        public string TIN { get; set; }
        public string Business_Style { get; set; }
    }
}
