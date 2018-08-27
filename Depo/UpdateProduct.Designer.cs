namespace StokYönetim
{
    partial class UpdateProduct
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
            this.GroupBoxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.LabelCurrencyUpdateProduct = new System.Windows.Forms.Label();
            this.ButtonUpdateProduct = new System.Windows.Forms.Button();
            this.TextBoxTypePriceUpdateProduct = new System.Windows.Forms.TextBox();
            this.TextBoxTypeNameUpdateProduct = new System.Windows.Forms.TextBox();
            this.TextBoxProductNameUpdateProduct = new System.Windows.Forms.TextBox();
            this.LabelTypePriceUpdateProduct = new System.Windows.Forms.Label();
            this.LabelTypeNameUpdateProduct = new System.Windows.Forms.Label();
            this.LabelProductNameUpdateProduct = new System.Windows.Forms.Label();
            this.GroupBoxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxUpdateProduct
            // 
            this.GroupBoxUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxUpdateProduct.BackColor = System.Drawing.SystemColors.Window;
            this.GroupBoxUpdateProduct.Controls.Add(this.LabelCurrencyUpdateProduct);
            this.GroupBoxUpdateProduct.Controls.Add(this.ButtonUpdateProduct);
            this.GroupBoxUpdateProduct.Controls.Add(this.TextBoxTypePriceUpdateProduct);
            this.GroupBoxUpdateProduct.Controls.Add(this.TextBoxTypeNameUpdateProduct);
            this.GroupBoxUpdateProduct.Controls.Add(this.TextBoxProductNameUpdateProduct);
            this.GroupBoxUpdateProduct.Controls.Add(this.LabelTypePriceUpdateProduct);
            this.GroupBoxUpdateProduct.Controls.Add(this.LabelTypeNameUpdateProduct);
            this.GroupBoxUpdateProduct.Controls.Add(this.LabelProductNameUpdateProduct);
            this.GroupBoxUpdateProduct.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxUpdateProduct.Name = "GroupBoxUpdateProduct";
            this.GroupBoxUpdateProduct.Size = new System.Drawing.Size(351, 252);
            this.GroupBoxUpdateProduct.TabIndex = 0;
            this.GroupBoxUpdateProduct.TabStop = false;
            this.GroupBoxUpdateProduct.Text = "Ürün Güncelle";
            // 
            // LabelCurrencyUpdateProduct
            // 
            this.LabelCurrencyUpdateProduct.AutoSize = true;
            this.LabelCurrencyUpdateProduct.Location = new System.Drawing.Point(157, 138);
            this.LabelCurrencyUpdateProduct.Name = "LabelCurrencyUpdateProduct";
            this.LabelCurrencyUpdateProduct.Size = new System.Drawing.Size(20, 13);
            this.LabelCurrencyUpdateProduct.TabIndex = 7;
            this.LabelCurrencyUpdateProduct.Text = "TL";
            // 
            // ButtonUpdateProduct
            // 
            this.ButtonUpdateProduct.Location = new System.Drawing.Point(35, 190);
            this.ButtonUpdateProduct.Name = "ButtonUpdateProduct";
            this.ButtonUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdateProduct.TabIndex = 6;
            this.ButtonUpdateProduct.Text = "Güncelle";
            this.ButtonUpdateProduct.UseVisualStyleBackColor = true;
            this.ButtonUpdateProduct.Click += new System.EventHandler(this.ButtonUpdateProduct_Click);
            // 
            // TextBoxTypePriceUpdateProduct
            // 
            this.TextBoxTypePriceUpdateProduct.Location = new System.Drawing.Point(88, 135);
            this.TextBoxTypePriceUpdateProduct.Name = "TextBoxTypePriceUpdateProduct";
            this.TextBoxTypePriceUpdateProduct.Size = new System.Drawing.Size(63, 20);
            this.TextBoxTypePriceUpdateProduct.TabIndex = 5;
            // 
            // TextBoxTypeNameUpdateProduct
            // 
            this.TextBoxTypeNameUpdateProduct.Location = new System.Drawing.Point(88, 87);
            this.TextBoxTypeNameUpdateProduct.Name = "TextBoxTypeNameUpdateProduct";
            this.TextBoxTypeNameUpdateProduct.Size = new System.Drawing.Size(161, 20);
            this.TextBoxTypeNameUpdateProduct.TabIndex = 4;
            // 
            // TextBoxProductNameUpdateProduct
            // 
            this.TextBoxProductNameUpdateProduct.Location = new System.Drawing.Point(88, 41);
            this.TextBoxProductNameUpdateProduct.Name = "TextBoxProductNameUpdateProduct";
            this.TextBoxProductNameUpdateProduct.ReadOnly = true;
            this.TextBoxProductNameUpdateProduct.Size = new System.Drawing.Size(113, 20);
            this.TextBoxProductNameUpdateProduct.TabIndex = 3;
            // 
            // LabelTypePriceUpdateProduct
            // 
            this.LabelTypePriceUpdateProduct.AutoSize = true;
            this.LabelTypePriceUpdateProduct.Location = new System.Drawing.Point(32, 138);
            this.LabelTypePriceUpdateProduct.Name = "LabelTypePriceUpdateProduct";
            this.LabelTypePriceUpdateProduct.Size = new System.Drawing.Size(50, 13);
            this.LabelTypePriceUpdateProduct.TabIndex = 2;
            this.LabelTypePriceUpdateProduct.Text = "Tür Fiyatı";
            // 
            // LabelTypeNameUpdateProduct
            // 
            this.LabelTypeNameUpdateProduct.AutoSize = true;
            this.LabelTypeNameUpdateProduct.Location = new System.Drawing.Point(32, 90);
            this.LabelTypeNameUpdateProduct.Name = "LabelTypeNameUpdateProduct";
            this.LabelTypeNameUpdateProduct.Size = new System.Drawing.Size(41, 13);
            this.LabelTypeNameUpdateProduct.TabIndex = 1;
            this.LabelTypeNameUpdateProduct.Text = "Tür Adı";
            // 
            // LabelProductNameUpdateProduct
            // 
            this.LabelProductNameUpdateProduct.AutoSize = true;
            this.LabelProductNameUpdateProduct.Location = new System.Drawing.Point(32, 44);
            this.LabelProductNameUpdateProduct.Name = "LabelProductNameUpdateProduct";
            this.LabelProductNameUpdateProduct.Size = new System.Drawing.Size(48, 13);
            this.LabelProductNameUpdateProduct.TabIndex = 0;
            this.LabelProductNameUpdateProduct.Text = "Ürün Adı";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 276);
            this.Controls.Add(this.GroupBoxUpdateProduct);
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            this.GroupBoxUpdateProduct.ResumeLayout(false);
            this.GroupBoxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxUpdateProduct;
        private System.Windows.Forms.Label LabelCurrencyUpdateProduct;
        private System.Windows.Forms.Button ButtonUpdateProduct;
        private System.Windows.Forms.TextBox TextBoxTypePriceUpdateProduct;
        private System.Windows.Forms.TextBox TextBoxTypeNameUpdateProduct;
        private System.Windows.Forms.TextBox TextBoxProductNameUpdateProduct;
        private System.Windows.Forms.Label LabelTypePriceUpdateProduct;
        private System.Windows.Forms.Label LabelTypeNameUpdateProduct;
        private System.Windows.Forms.Label LabelProductNameUpdateProduct;
    }
}