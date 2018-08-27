namespace StokYönetim
{
    partial class UpdateCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelCompanyNameUpdateCustomer = new System.Windows.Forms.Label();
            this.LabelAddressUpdateCustomer = new System.Windows.Forms.Label();
            this.LabelTelephoneUpdateCustomer = new System.Windows.Forms.Label();
            this.ButtonUpdateCustomer = new System.Windows.Forms.Button();
            this.TextBoxCompanyNameUpdateCustomer = new System.Windows.Forms.TextBox();
            this.TextBoxAddressUpdateCustomer = new System.Windows.Forms.TextBox();
            this.TextBoxTelephoneUpdateCustomer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.TextBoxTelephoneUpdateCustomer);
            this.groupBox1.Controls.Add(this.TextBoxAddressUpdateCustomer);
            this.groupBox1.Controls.Add(this.TextBoxCompanyNameUpdateCustomer);
            this.groupBox1.Controls.Add(this.ButtonUpdateCustomer);
            this.groupBox1.Controls.Add(this.LabelTelephoneUpdateCustomer);
            this.groupBox1.Controls.Add(this.LabelAddressUpdateCustomer);
            this.groupBox1.Controls.Add(this.LabelCompanyNameUpdateCustomer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Güncelle";
            // 
            // LabelCompanyNameUpdateCustomer
            // 
            this.LabelCompanyNameUpdateCustomer.AutoSize = true;
            this.LabelCompanyNameUpdateCustomer.Location = new System.Drawing.Point(25, 45);
            this.LabelCompanyNameUpdateCustomer.Name = "LabelCompanyNameUpdateCustomer";
            this.LabelCompanyNameUpdateCustomer.Size = new System.Drawing.Size(50, 13);
            this.LabelCompanyNameUpdateCustomer.TabIndex = 0;
            this.LabelCompanyNameUpdateCustomer.Text = "Firma Adı";
            // 
            // LabelAddressUpdateCustomer
            // 
            this.LabelAddressUpdateCustomer.AutoSize = true;
            this.LabelAddressUpdateCustomer.Location = new System.Drawing.Point(25, 86);
            this.LabelAddressUpdateCustomer.Name = "LabelAddressUpdateCustomer";
            this.LabelAddressUpdateCustomer.Size = new System.Drawing.Size(34, 13);
            this.LabelAddressUpdateCustomer.TabIndex = 1;
            this.LabelAddressUpdateCustomer.Text = "Adres";
            // 
            // LabelTelephoneUpdateCustomer
            // 
            this.LabelTelephoneUpdateCustomer.AutoSize = true;
            this.LabelTelephoneUpdateCustomer.Location = new System.Drawing.Point(25, 170);
            this.LabelTelephoneUpdateCustomer.Name = "LabelTelephoneUpdateCustomer";
            this.LabelTelephoneUpdateCustomer.Size = new System.Drawing.Size(43, 13);
            this.LabelTelephoneUpdateCustomer.TabIndex = 2;
            this.LabelTelephoneUpdateCustomer.Text = "Telefon";
            // 
            // ButtonUpdateCustomer
            // 
            this.ButtonUpdateCustomer.Location = new System.Drawing.Point(28, 212);
            this.ButtonUpdateCustomer.Name = "ButtonUpdateCustomer";
            this.ButtonUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdateCustomer.TabIndex = 3;
            this.ButtonUpdateCustomer.Text = "Güncelle";
            this.ButtonUpdateCustomer.UseVisualStyleBackColor = true;
            this.ButtonUpdateCustomer.Click += new System.EventHandler(this.ButtonUpdateCustomer_Click);
            // 
            // TextBoxCompanyNameUpdateCustomer
            // 
            this.TextBoxCompanyNameUpdateCustomer.Location = new System.Drawing.Point(81, 42);
            this.TextBoxCompanyNameUpdateCustomer.Name = "TextBoxCompanyNameUpdateCustomer";
            this.TextBoxCompanyNameUpdateCustomer.Size = new System.Drawing.Size(147, 20);
            this.TextBoxCompanyNameUpdateCustomer.TabIndex = 4;
            // 
            // TextBoxAddressUpdateCustomer
            // 
            this.TextBoxAddressUpdateCustomer.Location = new System.Drawing.Point(81, 83);
            this.TextBoxAddressUpdateCustomer.Multiline = true;
            this.TextBoxAddressUpdateCustomer.Name = "TextBoxAddressUpdateCustomer";
            this.TextBoxAddressUpdateCustomer.Size = new System.Drawing.Size(147, 67);
            this.TextBoxAddressUpdateCustomer.TabIndex = 5;
            // 
            // TextBoxTelephoneUpdateCustomer
            // 
            this.TextBoxTelephoneUpdateCustomer.Location = new System.Drawing.Point(81, 167);
            this.TextBoxTelephoneUpdateCustomer.Name = "TextBoxTelephoneUpdateCustomer";
            this.TextBoxTelephoneUpdateCustomer.Size = new System.Drawing.Size(147, 20);
            this.TextBoxTelephoneUpdateCustomer.TabIndex = 6;
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 278);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxTelephoneUpdateCustomer;
        private System.Windows.Forms.TextBox TextBoxAddressUpdateCustomer;
        private System.Windows.Forms.TextBox TextBoxCompanyNameUpdateCustomer;
        private System.Windows.Forms.Button ButtonUpdateCustomer;
        private System.Windows.Forms.Label LabelTelephoneUpdateCustomer;
        private System.Windows.Forms.Label LabelAddressUpdateCustomer;
        private System.Windows.Forms.Label LabelCompanyNameUpdateCustomer;
    }
}