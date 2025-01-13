namespace ReceiptPrinter_Cangs
{
    partial class IssuedReceipts
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lstReceiptList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReceiptDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReceiptNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReceivedFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusinessStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorizedCashierID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrint = new System.Windows.Forms.Button();
            this.PaymentFor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isFullPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(624, 363);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstReceiptList
            // 
            this.lstReceiptList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ReceiptDate,
            this.ReceiptNumber,
            this.ReceivedFrom,
            this.Address,
            this.TIN,
            this.BusinessStyle,
            this.Amount,
            this.AuthorizedCashierID,
            this.PaymentFor,
            this.isFullPayment});
            this.lstReceiptList.FullRowSelect = true;
            this.lstReceiptList.GridLines = true;
            this.lstReceiptList.HideSelection = false;
            this.lstReceiptList.Location = new System.Drawing.Point(12, 12);
            this.lstReceiptList.MultiSelect = false;
            this.lstReceiptList.Name = "lstReceiptList";
            this.lstReceiptList.Size = new System.Drawing.Size(688, 344);
            this.lstReceiptList.TabIndex = 1;
            this.lstReceiptList.UseCompatibleStateImageBehavior = false;
            this.lstReceiptList.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.Text = "Receipt Date";
            this.ReceiptDate.Width = 80;
            // 
            // ReceiptNumber
            // 
            this.ReceiptNumber.Text = "Receipt Number";
            this.ReceiptNumber.Width = 100;
            // 
            // ReceivedFrom
            // 
            this.ReceivedFrom.Text = "Company";
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 100;
            // 
            // TIN
            // 
            this.TIN.Text = "TIN";
            this.TIN.Width = 70;
            // 
            // BusinessStyle
            // 
            this.BusinessStyle.Text = "Business Style";
            this.BusinessStyle.Width = 70;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 80;
            // 
            // AuthorizedCashierID
            // 
            this.AuthorizedCashierID.Text = "Cashier";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 363);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // isFullPayment
            // 
            this.isFullPayment.Text = "Full Payment";
            // 
            // IssuedReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 398);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lstReceiptList);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IssuedReceipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssuedReceipts";
            this.Activated += new System.EventHandler(this.IssuedReceipts_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lstReceiptList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ReceiptDate;
        private System.Windows.Forms.ColumnHeader ReceiptNumber;
        private System.Windows.Forms.ColumnHeader ReceivedFrom;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader TIN;
        private System.Windows.Forms.ColumnHeader BusinessStyle;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader AuthorizedCashierID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ColumnHeader PaymentFor;
        private System.Windows.Forms.ColumnHeader isFullPayment;
    }
}