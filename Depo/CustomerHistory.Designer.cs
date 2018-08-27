namespace StokYönetim
{
    partial class CustomerHistory
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
            this.DataGridViewCustomerHistory = new System.Windows.Forms.DataGridView();
            this.TextBoxTotalLoan = new System.Windows.Forms.TextBox();
            this.LabelTotalLoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPayment = new System.Windows.Forms.Label();
            this.TextBoxPayment = new System.Windows.Forms.TextBox();
            this.ButtonPayLoan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomerHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewCustomerHistory
            // 
            this.DataGridViewCustomerHistory.AllowUserToAddRows = false;
            this.DataGridViewCustomerHistory.AllowUserToDeleteRows = false;
            this.DataGridViewCustomerHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewCustomerHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCustomerHistory.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewCustomerHistory.Name = "DataGridViewCustomerHistory";
            this.DataGridViewCustomerHistory.ReadOnly = true;
            this.DataGridViewCustomerHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridViewCustomerHistory.Size = new System.Drawing.Size(626, 400);
            this.DataGridViewCustomerHistory.TabIndex = 0;
            // 
            // TextBoxTotalLoan
            // 
            this.TextBoxTotalLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxTotalLoan.Location = new System.Drawing.Point(85, 420);
            this.TextBoxTotalLoan.Name = "TextBoxTotalLoan";
            this.TextBoxTotalLoan.ReadOnly = true;
            this.TextBoxTotalLoan.Size = new System.Drawing.Size(63, 20);
            this.TextBoxTotalLoan.TabIndex = 1;
            // 
            // LabelTotalLoan
            // 
            this.LabelTotalLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTotalLoan.AutoSize = true;
            this.LabelTotalLoan.Location = new System.Drawing.Point(12, 423);
            this.LabelTotalLoan.Name = "LabelTotalLoan";
            this.LabelTotalLoan.Size = new System.Drawing.Size(67, 13);
            this.LabelTotalLoan.TabIndex = 2;
            this.LabelTotalLoan.Text = "Toplam Borç";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TL";
            // 
            // LabelPayment
            // 
            this.LabelPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPayment.AutoSize = true;
            this.LabelPayment.Location = new System.Drawing.Point(249, 423);
            this.LabelPayment.Name = "LabelPayment";
            this.LabelPayment.Size = new System.Drawing.Size(45, 13);
            this.LabelPayment.TabIndex = 4;
            this.LabelPayment.Text = "Ödenen";
            // 
            // TextBoxPayment
            // 
            this.TextBoxPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxPayment.Location = new System.Drawing.Point(300, 420);
            this.TextBoxPayment.Name = "TextBoxPayment";
            this.TextBoxPayment.Size = new System.Drawing.Size(83, 20);
            this.TextBoxPayment.TabIndex = 5;
            // 
            // ButtonPayLoan
            // 
            this.ButtonPayLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPayLoan.Location = new System.Drawing.Point(541, 418);
            this.ButtonPayLoan.Name = "ButtonPayLoan";
            this.ButtonPayLoan.Size = new System.Drawing.Size(75, 23);
            this.ButtonPayLoan.TabIndex = 6;
            this.ButtonPayLoan.Text = "Öde";
            this.ButtonPayLoan.UseVisualStyleBackColor = true;
            this.ButtonPayLoan.Click += new System.EventHandler(this.ButtonPayLoan_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TL";
            // 
            // CustomerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonPayLoan);
            this.Controls.Add(this.TextBoxPayment);
            this.Controls.Add(this.LabelPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTotalLoan);
            this.Controls.Add(this.TextBoxTotalLoan);
            this.Controls.Add(this.DataGridViewCustomerHistory);
            this.Name = "CustomerHistory";
            this.Text = "Müşteri Hesap Özeti";
            this.Load += new System.EventHandler(this.CustomerHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomerHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewCustomerHistory;
        private System.Windows.Forms.TextBox TextBoxTotalLoan;
        private System.Windows.Forms.Label LabelTotalLoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelPayment;
        private System.Windows.Forms.TextBox TextBoxPayment;
        private System.Windows.Forms.Button ButtonPayLoan;
        private System.Windows.Forms.Label label2;
    }
}