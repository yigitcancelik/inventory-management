using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObject;
using Businesslogic;

namespace StokYönetim
{
    public partial class UpdateProduct : Form
    {
        Stok form = new Stok();

        public UpdateProduct(Stok parent)
        {
            InitializeComponent();
            form = parent;
        }

        TypeBO objTypeBO = new TypeBO();

        private void UpdateProduct_Load(object sender, System.EventArgs e)
        {
            TextBoxProductNameUpdateProduct.Text = Constants.ProductNameUpdateProduct;
            TextBoxTypeNameUpdateProduct.Text = Constants.TypeNameUpdateProduct;
            TextBoxTypePriceUpdateProduct.Text = Constants.TypePriceUpdateProduct;

            ProductBL objProductBL = new ProductBL();

            objTypeBO.ProductID = objProductBL.GetProductID(Constants.ProductNameUpdateProduct);
            objTypeBO.TypeName = TextBoxTypeNameUpdateProduct.Text;
            objTypeBO.TypePrice = Convert.ToDecimal(TextBoxTypePriceUpdateProduct.Text);

            TypeBL objTypeBL = new TypeBL();

            objTypeBO.TypeID = objTypeBL.GetTypeID(objTypeBO);
        }

        private void ButtonUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                objTypeBO.TypeName = TextBoxTypeNameUpdateProduct.Text;
                objTypeBO.TypePrice = Convert.ToDecimal(TextBoxTypePriceUpdateProduct.Text);

                TypeBL objTypeBL = new TypeBL();
                objTypeBL.UpdateProduct(objTypeBO);

                MessageBox.Show("Ürün başarı ile güncellenmiştir");
                this.Close();
                form.PopulateGridViewProducts();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
