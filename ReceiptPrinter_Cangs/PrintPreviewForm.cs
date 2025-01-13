using ReceiptPrinter_Cangs.Models;
using ReceiptPrinter_Cangs.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptPrinter_Cangs
{
    public partial class PrintPreviewForm : Form
    {
        Brush brushColor = Brushes.Black;
        DTO_Receipt receipt;
        Wordify wordifyNumber = new Wordify();

        public PrintPreviewForm(DTO_Receipt dtoReceipt)
        {
            InitializeComponent();
            receipt = new DTO_Receipt();
            receipt = dtoReceipt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintDocument_PrintPage; ;
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.Print();
            printDocument.Dispose();
            this.Close();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipt.ReceiptDate.ToString("MM/dd/yyyy"), new Font("Arial", 9, FontStyle.Bold), brushColor, 610, 300);
            e.Graphics.DrawString(receipt.ReceivedFrom.ToUpper(), new Font("Arial", 9, FontStyle.Bold), brushColor, 100, 330);
            e.Graphics.DrawString(receipt.Address.ToUpper(), new Font("Arial", 9, FontStyle.Bold), brushColor, 60, 352);
            e.Graphics.DrawString(receipt.TIN.ToUpper(), new Font("Arial", 9, FontStyle.Bold), brushColor, 545, 352);
            e.Graphics.DrawString(receipt.BusinessStyle.ToUpper(), new Font("Arial", 9, FontStyle.Bold), brushColor, 200, 374);
            e.Graphics.DrawString(wordifyNumber.AmountToWords((double)receipt.Amount), new Font("Arial", 9, FontStyle.Bold), brushColor, 20, 396);
            e.Graphics.DrawString(receipt.Amount.ToString("#,##0.00"), new Font("Arial", 9, FontStyle.Bold), brushColor, 20, 418);
            int xAxis = 0;
            if (receipt.isFull_Payment) xAxis = 245;
            else xAxis = 185;
            e.Graphics.DrawString("✔", new Font("Arial", 9, FontStyle.Bold), brushColor, xAxis, 418);
            e.Graphics.DrawString(receipt.Payment_For.ToUpper(), new Font("Arial", 9, FontStyle.Bold), brushColor, 20, 438);
            e.Graphics.DrawString(receipt.AuthorizeCashierID.ToUpper(), new Font("Arial", 9, FontStyle.Bold), brushColor, 510, 518);
        }
    }
}
