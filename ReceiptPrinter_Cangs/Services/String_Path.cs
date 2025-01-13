using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptPrinter_Cangs.Services
{
    public class String_Path
    {
        readonly static string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        readonly string liteDbPath = Path.Combine(dbPath, "liteDB_ReceiptPrinterDb.db");

        public string SqliteDB_Path()
        {
            string connectionString = "Data Source=checkPrinterDB.db3; Version=3;";
            return connectionString;
        }

        public string liteDB_Path()
        {
            return liteDbPath;
        }
    }
}
