namespace ReceiptPrinter_Cangs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReceiveFrom = new System.Windows.Forms.TextBox();
            this.dtCheckDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBStyle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSavePrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnViewIssued = new System.Windows.Forms.Button();
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCashier = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPaymentFor = new System.Windows.Forms.TextBox();
            this.chkFullPayment = new System.Windows.Forms.CheckBox();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtReceiveFrom
            // 
            this.txtReceiveFrom.HideSelection = false;
            this.txtReceiveFrom.Location = new System.Drawing.Point(117, 133);
            this.txtReceiveFrom.Name = "txtReceiveFrom";
            this.txtReceiveFrom.Size = new System.Drawing.Size(509, 20);
            this.txtReceiveFrom.TabIndex = 0;
            this.txtReceiveFrom.TextChanged += new System.EventHandler(this.txtReceiveFrom_TextChanged);
            this.txtReceiveFrom.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtReceiveFrom_PreviewKeyDown);
            // 
            // dtCheckDate
            // 
            this.dtCheckDate.Location = new System.Drawing.Point(426, 39);
            this.dtCheckDate.Name = "dtCheckDate";
            this.dtCheckDate.Size = new System.Drawing.Size(200, 20);
            this.dtCheckDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Received from :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(117, 159);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(509, 20);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TIN :";
            // 
            // txtTIN
            // 
            this.txtTIN.Location = new System.Drawing.Point(117, 185);
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(509, 20);
            this.txtTIN.TabIndex = 6;
            this.txtTIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTIN_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Business style :";
            // 
            // txtBStyle
            // 
            this.txtBStyle.Location = new System.Drawing.Point(117, 211);
            this.txtBStyle.Name = "txtBStyle";
            this.txtBStyle.Size = new System.Drawing.Size(509, 20);
            this.txtBStyle.TabIndex = 8;
            this.txtBStyle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBStyle_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(117, 237);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(509, 20);
            this.txtAmount.TabIndex = 10;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cashier / Authorize Representative :";
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Location = new System.Drawing.Point(551, 380);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(75, 23);
            this.btnSavePrint.TabIndex = 14;
            this.btnSavePrint.Text = "Save / Print";
            this.btnSavePrint.UseVisualStyleBackColor = true;
            this.btnSavePrint.Click += new System.EventHandler(this.btnSavePrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnViewIssued
            // 
            this.btnViewIssued.Location = new System.Drawing.Point(36, 380);
            this.btnViewIssued.Name = "btnViewIssued";
            this.btnViewIssued.Size = new System.Drawing.Size(128, 23);
            this.btnViewIssued.TabIndex = 16;
            this.btnViewIssued.Text = "View Issued Receipt";
            this.btnViewIssued.UseVisualStyleBackColor = true;
            this.btnViewIssued.Click += new System.EventHandler(this.btnViewIssued_Click);
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.Location = new System.Drawing.Point(460, 85);
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.Size = new System.Drawing.Size(156, 20);
            this.txtReceiptNumber.TabIndex = 0;
            this.txtReceiptNumber.WordWrap = false;
            this.txtReceiptNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceiptNumber_KeyDown);
            this.txtReceiptNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceiptNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Receipt No. :";
            // 
            // cmbCashier
            // 
            this.cmbCashier.FormattingEnabled = true;
            this.cmbCashier.Location = new System.Drawing.Point(213, 332);
            this.cmbCashier.Name = "cmbCashier";
            this.cmbCashier.Size = new System.Drawing.Size(413, 21);
            this.cmbCashier.TabIndex = 19;
            this.cmbCashier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashier_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Payment for :";
            // 
            // txtPaymentFor
            // 
            this.txtPaymentFor.Location = new System.Drawing.Point(117, 263);
            this.txtPaymentFor.Name = "txtPaymentFor";
            this.txtPaymentFor.Size = new System.Drawing.Size(509, 20);
            this.txtPaymentFor.TabIndex = 20;
            this.txtPaymentFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaymentFor_KeyDown);
            // 
            // chkFullPayment
            // 
            this.chkFullPayment.AutoSize = true;
            this.chkFullPayment.Checked = true;
            this.chkFullPayment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFullPayment.Location = new System.Drawing.Point(117, 290);
            this.chkFullPayment.Name = "chkFullPayment";
            this.chkFullPayment.Size = new System.Drawing.Size(85, 17);
            this.chkFullPayment.TabIndex = 22;
            this.chkFullPayment.Text = "Full payment";
            this.chkFullPayment.UseVisualStyleBackColor = true;
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.Location = new System.Drawing.Point(118, 153);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(508, 95);
            this.lstCustomer.TabIndex = 23;
            this.lstCustomer.Visible = false;
            this.lstCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstCustomer_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 427);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.chkFullPayment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPaymentFor);
            this.Controls.Add(this.cmbCashier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReceiptNumber);
            this.Controls.Add(this.btnViewIssued);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSavePrint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBStyle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtCheckDate);
            this.Controls.Add(this.txtReceiveFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Printer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceiveFrom;
        private System.Windows.Forms.DateTimePicker dtCheckDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBStyle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSavePrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewIssued;
        private System.Windows.Forms.TextBox txtReceiptNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCashier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPaymentFor;
        private System.Windows.Forms.CheckBox chkFullPayment;
        private System.Windows.Forms.ListBox lstCustomer;
    }
}

