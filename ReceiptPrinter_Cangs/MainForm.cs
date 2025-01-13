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
    public partial class MainForm : Form
    {
        RP_Services rps = new RP_Services();
        List<DTO_Customer> customers = new List<DTO_Customer>();

        public MainForm()
        {
            InitializeComponent();
            txtReceiptNumber.Focus();
        }

        private void ValidateReceiptNumber(object sender)
        {
            if (((TextBox)sender).Text == "")
            {
                MessageBox.Show(this, "Receipt number cannot be empty.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            try
            {
                var save = MessageBox.Show(this, "Save this info and print?", "Save and Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (save == DialogResult.Yes)
                {
                    DTO_Receipt receipt = new DTO_Receipt();
                    receipt.ReceiptNumber = Convert.ToInt64(txtReceiptNumber.Text);
                    receipt.ReceivedFrom = txtReceiveFrom.Text;
                    receipt.Address = txtAddress.Text;
                    receipt.TIN = txtTIN.Text;
                    receipt.ReceiptDate = dtCheckDate.Value.ToLocalTime();
                    receipt.DateTimeAdded = DateTime.Now.ToLocalTime();
                    receipt.BusinessStyle = txtBStyle.Text;
                    receipt.Amount = Convert.ToDecimal(txtAmount.Text);
                    receipt.AuthorizeCashierID = cmbCashier.Text;
                    receipt.Payment_For = txtPaymentFor.Text;
                    receipt.isFull_Payment = chkFullPayment.Checked;

                    var result = rps.SaveReceiptDetails(receipt);

                    DTO_Customer customer = new DTO_Customer();
                    customer.Customer_Name = txtReceiveFrom.Text;
                    customer.Address = txtAddress.Text;
                    customer.TIN = txtTIN.Text;
                    customer.Business_Style = txtBStyle.Text;

                    var saveCust = rps.SaveCustomer(customer);

                    if (result == 1)
                    {
                        PrintPreviewForm ppf = new PrintPreviewForm(receipt);
                        ppf.ShowDialog();

                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show(this, "Error","Save failed.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,"Error",ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnViewIssued_Click(object sender, EventArgs e)
        {
            IssuedReceipts ir = new IssuedReceipts();
            ir.ShowDialog();
        }

        private void lstCustomer_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void select_customer()
        {
            DTO_Customer selectedCustomer = (DTO_Customer)lstCustomer.SelectedItem;
            txtReceiveFrom.Text = selectedCustomer.Customer_Name;
            txtAddress.Text = selectedCustomer.Address;
            txtTIN.Text = selectedCustomer.TIN;
            txtBStyle.Text = selectedCustomer.Business_Style;
            lstCustomer.Visible = false;
            txtAmount.Focus();
        }

        private void txtReceiptNumber_Leave(object sender, EventArgs e)
        {

        }

        private void txtReceiptNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
        }

        private void txtReceiptNumber_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtReceiveFrom.Focus();
                    break;
                default:
                    break;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtTIN.Focus();
                    break;
                default:
                    break;
            }
        }

        private void txtTIN_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtBStyle.Focus();
                    break;
                default:
                    break;
            }
        }

        private void txtBStyle_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtAmount.Focus();
                    break;
                default:
                    break;
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtPaymentFor.Focus();
                    break;
                default:
                    break;
            }
        }

        private void txtPaymentFor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    cmbCashier.Focus();
                    break;
                default:
                    break;
            }
        }

        private void cmbCashier_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnSavePrint.Focus();
                    break;
                default:
                    break;
            }
        }

        private void lstCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    select_customer();
                    break;
            }
        }

        private void txtReceiveFrom_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (lstCustomer.Visible == true)
                    {
                        select_customer();
                        lstCustomer.Visible = false;
                    }
                    else
                    {
                        txtAddress.Focus();
                    }
                    break;
                case Keys.Down:
                    lstCustomer.Focus();
                    break;
                default:
                    break;
            }
        }

        private void txtReceiveFrom_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text != "")
            {
                customers = rps.GetCustomerList(txtBox.Text);
            }
            else
            {
                customers.Clear();
            }

            if (customers.Count > 0)
            {
                lstCustomer.DataSource = customers;
                lstCustomer.DisplayMember = "Customer_Name";
                lstCustomer.Visible = true;
            }
            else
            {
                lstCustomer.DataSource = null;
                lstCustomer.Visible = false;
            }
        }

        private void ClearFields()
        {
            txtReceiptNumber.Clear();
            txtReceiveFrom.Clear();
            txtAddress.Clear();
            txtTIN.Clear();
            txtBStyle.Clear();
            txtAmount.Clear();
            txtPaymentFor.Clear();
            cmbCashier.SelectedIndex = -1;
            cmbCashier.Text = "";

            txtReceiptNumber.Focus();
        }
    }
}
