using ReceiptPrinter_Cangs.Models;
using ReceiptPrinter_Cangs.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptPrinter_Cangs
{
    public partial class IssuedReceipts : Form
    {
        RP_Services rps = new RP_Services();
        public IssuedReceipts()
        {
            InitializeComponent();
        }

        private void InitializedReceiptList()
        {
            var result = rps.GetReceiptList();
            if (result != null)
            {
                var _listReceipt = new List<DTO_Receipt>();
                _listReceipt = result;
                lstReceiptList.Items.Clear();
                for (int i = 0; i < result.Count(); i++)
                {
                    lstReceiptList.Items.Add(_listReceipt[i].ID.ToString());
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].ReceiptDate.ToString("MM/dd/yyyy"));
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].ReceiptNumber.ToString());
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].ReceivedFrom);
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].Address);
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].TIN);
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].BusinessStyle);
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].Amount.ToString("#,##0.00"));
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].AuthorizeCashierID);
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].Payment_For);
                    lstReceiptList.Items[i].SubItems.Add(_listReceipt[i].isFull_Payment.ToString());
                }
            }
            else
            {
                MessageBox.Show(this,"No record/s found","Empty",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DTO_Receipt reprintReceipt = new DTO_Receipt()
            {
                ID = Convert.ToInt32(lstReceiptList.SelectedItems[0].Text),
                ReceiptDate = Convert.ToDateTime(lstReceiptList.SelectedItems[0].SubItems[1].Text),
                ReceiptNumber = Convert.ToInt64(lstReceiptList.SelectedItems[0].SubItems[2].Text),
                ReceivedFrom = lstReceiptList.SelectedItems[0].SubItems[3].Text,
                Address = lstReceiptList.SelectedItems[0].SubItems[4].Text,
                TIN = lstReceiptList.SelectedItems[0].SubItems[5].Text,
                BusinessStyle = lstReceiptList.SelectedItems[0].SubItems[6].Text,
                Amount = Convert.ToDecimal(lstReceiptList.SelectedItems[0].SubItems[7].Text),
                AuthorizeCashierID = lstReceiptList.SelectedItems[0].SubItems[8].Text,
                Payment_For = lstReceiptList.SelectedItems[0].SubItems[9].Text,
                isFull_Payment = Convert.ToBoolean(lstReceiptList.SelectedItems[0].SubItems[10].Text)
            };

            PrintPreviewForm ppf = new PrintPreviewForm(reprintReceipt);
            ppf.ShowDialog();
        }

        private void IssuedReceipts_Activated(object sender, EventArgs e)
        {
            InitializedReceiptList();
        }
    }
}
