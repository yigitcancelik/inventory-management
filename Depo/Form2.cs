using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObject;
using Businesslogic;

namespace StokYönetim
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            PreferencesBL objPreferencesBL = new PreferencesBL();
            objPreferencesBL.SetColorBL();
            objPreferencesBL.SetLimitBL();

            PopulateGridViewStock();
            ControlStock();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBoxLowColor.Items.Clear();
                ComboBoxLowColor.Text = "";

                ComboBoxNormalColor.Items.Clear();
                ComboBoxNormalColor.Text = "";

                ComboBoxEmptyColor.Items.Clear();
                ComboBoxEmptyColor.Text = "";

                if (TabControl.SelectedIndex == 0) //Stok
                {
                    PopulateGridViewStock();
                    ControlStock();
                }
                if (TabControl.SelectedIndex == 1)  //Müşteri
                {
                    PopulateGridViewCostumers();
                }
                if (TabControl.SelectedIndex == 2)  //Stok ekleme
                {
                    PopulateComboBoxProductName();
                    PopulateGridViewStockHistory();
                }
                if (TabControl.SelectedIndex == 3)  //Satış
                {
                    PopulateComboBoxProductNameSell();
                    PopulateComboBoxCostumerSell();
                    PopulateGridViewSell();
                }
                if (TabControl.SelectedIndex == 4)  //Ürün ekleme
                {
                    PopulateComboBoxProductNameAddProduct();
                }
                if (TabControl.SelectedIndex == 5) //Ürünler
                {
                    PopulateGridViewProducts();
                }
                if (TabControl.SelectedIndex == 6) //Seçenekler
                {
                    PopulateComboBoxColors();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ComboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxProductName.SelectedValue.ToString() != "System.Data.DataRowView")
                Constants.ProductIDOfFirstItem = Convert.ToInt32(ComboBoxProductName.SelectedValue);
            PopulateComboBoxProductType();
        }

        private void ComboBoxProductNameSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxProductNameSell.SelectedValue.ToString() != "System.Data.DataRowView")
                Constants.ProductIDOfFirstItem = Convert.ToInt32(ComboBoxProductNameSell.SelectedValue);
            PopulateComboBoxProductTypeSell();
        }

        protected void PopulateGridViewStock()
        {
            try
            {
                ProductBL objProductBL = new ProductBL();
                DataSet ds = objProductBL.PopulateGridViewStockBL();

                ds.Tables[0].Columns[0].ColumnName = "Ürün Adı";
                ds.Tables[0].Columns[1].ColumnName = "Ürün Türü";
                ds.Tables[0].Columns[2].ColumnName = "Ürün Adedi";

                GridViewStock.DataSource = ds;
                GridViewStock.DataMember = ds.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void PopulateGridViewCostumers()
        {
            try
            {
                CostumerBL objCostumerBL = new CostumerBL();
                DataSet ds = objCostumerBL.PopulateGridViewCostumerBL();

                ds.Tables[0].Columns[0].ColumnName = "Firma Adı";
                ds.Tables[0].Columns[1].ColumnName = "Adres";
                ds.Tables[0].Columns[2].ColumnName = "Telefon";

                GridViewCostumers.DataSource = ds;
                GridViewCostumers.DataMember = ds.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PopulateGridViewStockHistory()
        {
            try
            {
                StockBL objStockBL = new StockBL();
                DataSet ds = objStockBL.PopulateGridViewStockHistoryBL();

                ds.Tables[0].Columns[0].ColumnName = "Ürün Adı";
                ds.Tables[0].Columns[1].ColumnName = "Ürün Türü";
                ds.Tables[0].Columns[2].ColumnName = "Sayısı";
                ds.Tables[0].Columns[3].ColumnName = "Tarihi";

                GridViewStockHistory.DataSource = ds;
                GridViewStockHistory.DataMember = ds.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void PopulateGridViewSell()
        {
            SellBL objSellBL = new SellBL();
            DataSet ds = objSellBL.PopulateGridViewSellBL();

            ds.Tables[0].Columns[0].ColumnName = "Firma Adı";
            ds.Tables[0].Columns[1].ColumnName = "Ürün Adı";
            ds.Tables[0].Columns[2].ColumnName = "Ürün Türü";
            ds.Tables[0].Columns[3].ColumnName = "Sayısı";
            ds.Tables[0].Columns[4].ColumnName = "Fiyat";
            ds.Tables[0].Columns[5].ColumnName = "Tarih";

            GridViewSellHistory.DataSource = ds;
            GridViewSellHistory.DataMember = ds.Tables[0].ToString();
        }

        public void PopulateGridViewProducts()
        {
            TypeBL objTypeBL = new TypeBL();
            DataSet ds = objTypeBL.PopulateGridViewProductsBL();

            ds.Tables[0].Columns[0].ColumnName = "Ürün Adı";
            ds.Tables[0].Columns[1].ColumnName = "Ürün Türü";
            ds.Tables[0].Columns[2].ColumnName = "Fiyat";

            GridViewProducts.DataSource = ds;
            GridViewProducts.DataMember = ds.Tables[0].ToString();
        }

        protected void PopulateComboBoxProductNameAddProduct()
        {
            try
            {
                ProductBL objProductBL = new ProductBL();
                DataSet ds = objProductBL.PopulateComboBoxProductNameAddProductBL();

                DataView dvTypes = new DataView(ds.Tables[0]);
                dvTypes.Sort = "ProductName";

                ComboBoxProductNameAddProduct.DataSource = dvTypes;
                ComboBoxProductNameAddProduct.DisplayMember = "ProductName";
                ComboBoxProductNameAddProduct.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void PopulateComboBoxProductName()
        {
            try
            {
                ProductBL objProductBL = new ProductBL();
                DataSet ds = objProductBL.PopulateComboBoxProductNameBL();

                DataView dvTypes = new DataView(ds.Tables[0]);
                dvTypes.Sort = "ProductName";

                DataTable dt = dvTypes.ToTable();
                Constants.ProductIDOfFirstItem = Convert.ToInt32(dt.Rows[0][0].ToString());

                ComboBoxProductName.DataSource = dvTypes;
                ComboBoxProductName.DisplayMember = "ProductName";
                ComboBoxProductName.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void PopulateComboBoxProductType()
        {
            try
            {
                ComboBoxProductType.Text = "";
                TypeBL objTypetBL = new TypeBL();
                int ProductID = Constants.ProductIDOfFirstItem;
                DataSet ds = objTypetBL.PopulateComboBoxProductTypeBL(ProductID);

                DataView dvTypes = new DataView(ds.Tables[0]);
                dvTypes.Sort = "TypeName";

                ComboBoxProductType.DataSource = dvTypes;
                ComboBoxProductType.DisplayMember = "TypeName";
                ComboBoxProductType.ValueMember = "TypeID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void PopulateComboBoxProductNameSell()
        {
            try
            {
                ProductBL objProductBL = new ProductBL();
                DataSet ds = objProductBL.PopulateComboBoxProductNameBL();

                DataView dvTypes = new DataView(ds.Tables[0]);
                dvTypes.Sort = "ProductName";

                DataTable dt = dvTypes.ToTable();
                Constants.ProductIDOfFirstItem = Convert.ToInt32(dt.Rows[0][0].ToString());

                ComboBoxProductNameSell.DataSource = dvTypes;
                ComboBoxProductNameSell.DisplayMember = "ProductName";
                ComboBoxProductNameSell.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void PopulateComboBoxProductTypeSell()
        {
            try
            {
                ComboBoxProductTypeSell.Text = "";
                TypeBL objTypetBL = new TypeBL();
                int ProductID = Constants.ProductIDOfFirstItem;
                DataSet ds = objTypetBL.PopulateComboBoxProductTypeBL(ProductID);

                DataView dvTypes = new DataView(ds.Tables[0]);
                dvTypes.Sort = "TypeName";

                ComboBoxProductTypeSell.DataSource = dvTypes;
                ComboBoxProductTypeSell.DisplayMember = "TypeName";
                ComboBoxProductTypeSell.ValueMember = "TypeID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void PopulateComboBoxCostumerSell()
        {
            try
            {
                CostumerBL objCostumerBL = new CostumerBL();
                DataSet ds = objCostumerBL.PopulateComboBoxCostumerSellBL();

                DataView dvTypes = new DataView(ds.Tables[0]);
                dvTypes.Sort = "CostumerName";

                ComboBoxCompanyNameSell.DataSource = dvTypes;
                ComboBoxCompanyNameSell.DisplayMember = "CostumerName";
                ComboBoxCompanyNameSell.ValueMember = "CostumerID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void PopulateComboBoxColors()
        {
            ComboBoxItem obj = new ComboBoxItem("Aqua", "Aqua      ");
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Mavi";
            obj.Value = "Mavi";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Ciyan";
            obj.Value = "Ciyan";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Fuşya";
            obj.Value = "Fuşya";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Altın";
            obj.Value = "Altın";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Gri";
            obj.Value = "Gri";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Yeşil";
            obj.Value = "Yeşil";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Turuncu";
            obj.Value = "Turuncu";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Pembe";
            obj.Value = "Pembe";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Kırmızı";
            obj.Value = "Kırmızı";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Beyaz";
            obj.Value = "Beyaz";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);
            obj.Text = "Sarı";
            obj.Value = "Sarı";
            ComboBoxEmptyColor.Items.Add(obj);
            ComboBoxNormalColor.Items.Add(obj);
            ComboBoxLowColor.Items.Add(obj);

            ComboBoxEmptyColor.SelectedText = PreferencesBO.EmptyColor;
            ComboBoxNormalColor.SelectedText = PreferencesBO.NormalColor;
            ComboBoxLowColor.SelectedText = PreferencesBO.LowColor;

            TextBoxLimit.Text = PreferencesBO.Limit.ToString();
        }

        protected void ControlStock()
        {
            foreach (DataGridViewRow row in GridViewStock.Rows)
            {
                if (Convert.ToInt32(row.Cells[2].Value) < PreferencesBO.Limit && Convert.ToInt32(row.Cells[2].Value) > 0)
                {
                    row.DefaultCellStyle.BackColor = PreferencesBO.Low;
                }
                if (Convert.ToInt32(row.Cells[2].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = PreferencesBO.Empty;
                }
                if (Convert.ToInt32(row.Cells[2].Value) >= PreferencesBO.Limit)
                {
                    row.DefaultCellStyle.BackColor = PreferencesBO.Normal;
                }
            }
        }

        private void ButtonProductNameAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxProductNameAddProduct.Text != "")
                {
                    ProductBL objProductBL = new ProductBL();
                    objProductBL.AddProductBL(TextBoxProductNameAddProduct.Text);

                    MessageBox.Show("Ürün Başarıyla Eklenmiştir");
                    TextBoxProductNameAddProduct.Clear();
                    PopulateComboBoxProductNameAddProduct();
                }
                else
                {
                    MessageBox.Show("Lütfen ürün adı giriniz");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonTypeAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxTypeNameAddProduct.Text != "" && TextBoxTypePriceAddProduct.Text != "")
                {
                    TypeBO objTypeBO = new TypeBO();
                    objTypeBO.ProductID = (Int32)ComboBoxProductNameAddProduct.SelectedValue;
                    objTypeBO.TypeName = TextBoxTypeNameAddProduct.Text;
                    objTypeBO.TypePrice = Convert.ToDecimal(TextBoxTypePriceAddProduct.Text);

                    TypeBL objTypeBL = new TypeBL();
                    objTypeBL.AddTypeBL(objTypeBO);

                    MessageBox.Show("Ürün türü başarıyla eklenmiştir");
                }
                else
                {
                    MessageBox.Show("Lütfen tür adı ve fiyatını giriniz");
                }
                TextBoxTypeNameAddProduct.Clear();
                TextBoxTypePriceAddProduct.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonCostumerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCompanyName.Text != "")
                {
                    CostumerBO objCostumerBO = new CostumerBO();
                    objCostumerBO.CostumerName = TextBoxCompanyName.Text;
                    objCostumerBO.CostumerAddress = TextBoxAddress.Text;
                    objCostumerBO.CostumerPhone = TextBoxTelephone.Text;

                    CostumerBL objCostumerBL = new CostumerBL();
                    objCostumerBL.AddCostumerBL(objCostumerBO);

                    MessageBox.Show("Müşteri başarı ile eklenmiştir");
                }
                else
                {
                    MessageBox.Show("Lütfen müşteri adı giriniz");
                }

                TextBoxCompanyName.Clear();
                TextBoxAddress.Clear();
                TextBoxTelephone.Clear();
                PopulateGridViewCostumers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxProductCount.Text != "")
                {
                    TypeBO objTypeBO = new TypeBO();
                    objTypeBO.ProductID = (Int32)ComboBoxProductName.SelectedValue;
                    objTypeBO.TypeName = ComboBoxProductType.Text;
                    objTypeBO.TypeCount = Convert.ToInt32(TextBoxProductCount.Text);

                    TypeBL objTypeBL = new TypeBL();
                    objTypeBL.AddProductToStockBL(objTypeBO);

                    MessageBox.Show("Ürün başarı ile eklenmiştir");

                    TextBoxProductCount.Clear();
                    ComboBoxProductName.SelectedIndex = 0;
                    PopulateGridViewStockHistory();
                }
                else
                {
                    MessageBox.Show("Lütfen ürün adedini giriniz");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxProductCountSell.Text != "")
                {
                    SellBO objSellBO = new SellBO();
                    objSellBO.CustomerName = ComboBoxCompanyNameSell.Text;
                    objSellBO.ProductName = ComboBoxProductNameSell.Text;
                    objSellBO.TypeName = ComboBoxProductTypeSell.Text;
                    objSellBO.ProductCount = Convert.ToInt32(TextBoxProductCountSell.Text);
                    string Date = DateTimePicker.Value.ToString("dd/MM/yyyy");
                    objSellBO.SellDate = Convert.ToDateTime(Date);

                    SellBL objSellBL = new SellBL();
                    bool Sold = objSellBL.SellProductBL(objSellBO);

                    if (Sold == true)
                    {
                        MessageBox.Show("Satış başarı ile gerçekleştirilmiştir");

                        TextBoxProductCountSell.Clear();
                        ComboBoxCompanyNameSell.SelectedIndex = 0;
                        ComboBoxProductNameSell.SelectedIndex = 0;
                        DateTimePicker.Value = DateTime.Today;

                        PopulateGridViewSell();
                    }
                    else
                    {
                        MessageBox.Show("Seçilen ürün için yeterli stoğunuz bulunmamaktadır. Kalan ürün sayısı: " + Constants.RemainingProduct);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen satış adedi giriniz");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                if (GridViewProducts.SelectedRows.Count == 1)
                {
                    DataGridViewRow dr = GridViewProducts.SelectedRows[0];
                    TypeBL objTypeBL = new TypeBL();
                    ProductBL objProductBL = new ProductBL();

                    foreach (DataGridViewRow row in GridViewProducts.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == dr.Cells[0].Value.ToString())
                        {
                            if (count == 1)
                            {
                                objTypeBL.DeleteTypeBL(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString());
                                count++;
                                break;
                            }
                            count++;
                        }
                    }
                    if (count == 1)
                        objProductBL.DeleteProductBL(dr.Cells[0].Value.ToString());

                    PopulateGridViewProducts();
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz ürünün satırını seçin");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridViewProducts.SelectedRows.Count == 1)
                {
                    DataGridViewRow dr = GridViewProducts.SelectedRows[0];
                    Constants.ProductNameUpdateProduct = dr.Cells[0].Value.ToString();
                    Constants.TypeNameUpdateProduct = dr.Cells[1].Value.ToString();
                    Constants.TypePriceUpdateProduct = dr.Cells[2].Value.ToString();
                    UpdateProduct update = new UpdateProduct(this);
                    update.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz ürünün satırını seçin");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridViewCostumers.SelectedRows.Count == 1)
                {
                    DataGridViewRow dr = GridViewCostumers.SelectedRows[0];
                    CostumerBL objCostumerBL = new CostumerBL();
                    objCostumerBL.DeleteCostumerBL(dr.Cells[0].Value.ToString());

                    PopulateGridViewCostumers();
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz müşterinin satırını seçin");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridViewCostumers.SelectedRows.Count == 1)
                {
                    DataGridViewRow dr = GridViewCostumers.SelectedRows[0];
                    Constants.CompanyNameUpdateCustomer = dr.Cells[0].Value.ToString();
                    Constants.AddressUpdateCustomer = dr.Cells[1].Value.ToString();
                    Constants.TelephoneUpdateCustomer = dr.Cells[2].Value.ToString();
                    UpdateCustomer update = new UpdateCustomer(this);
                    update.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz müşterinin satırını seçin");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonSeeCustomerHistory_Click(object sender, EventArgs e) 
        {
            if (GridViewCostumers.SelectedRows.Count == 1)
            {
                DataGridViewRow dr = GridViewCostumers.SelectedRows[0];
                Constants.CompanyNameCustomerHistory = dr.Cells[0].Value.ToString();
                CustomerHistory history = new CustomerHistory(this);
                history.Show();
            }
            else 
            {
                MessageBox.Show("Lütfen hesap özetini görmek istediğiniz müşteriyi seçin");
            }
        }

        private void ButtonApplyChanges_Click(object sender, EventArgs e)
        {
            try
            {
                PreferencesBO.Limit = Convert.ToInt32(TextBoxLimit.Text);
                PreferencesBO.EmptyColor = ComboBoxEmptyColor.Text;
                PreferencesBO.NormalColor = ComboBoxNormalColor.Text;
                PreferencesBO.LowColor = ComboBoxLowColor.Text;

                PreferencesBL objPreferencesBL = new PreferencesBL();
                objPreferencesBL.ChangeColorBL();
                objPreferencesBL.ChangeLimitBL();

                MessageBox.Show("Tercihleriniz onaylanmıştır");

                objPreferencesBL.SetColorBL();
                objPreferencesBL.SetLimitBL();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ButtonClearSellHistory_Click(object sender, EventArgs e)
        {
            SellBL objSellBL = new SellBL();
            objSellBL.ClearSellHistoryBL();

            MessageBox.Show("Satış geçmişi temizlenmiştir");
        }

        private void ButtonClearStockHistory_Click(object sender, EventArgs e)
        {
            StockBL objStockBL = new StockBL();
            objStockBL.ClearStockHistoryBL();

            MessageBox.Show("Stok geçmişi temizlenmiştir");
        }

        private void TextBoxProductCountSell_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxProductCountSell.Text != "")
                {
                    SellBO objSellBO = new SellBO();
                    objSellBO.ProductName = ComboBoxProductNameSell.Text;
                    objSellBO.TypeName = ComboBoxProductTypeSell.Text;
                    objSellBO.ProductCount = Convert.ToInt32(TextBoxProductCountSell.Text);

                    SellBL objSellBL = new SellBL();
                    decimal Price = objSellBL.CalculatePriceBL(objSellBO);
                    string PriceStr = Price.ToString("0.##");

                    TextBoxTotalPrice.Text = PriceStr;
                }
                else
                {
                    TextBoxTotalPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
