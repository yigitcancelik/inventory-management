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
    public partial class UpdateCustomer : Form
    {
        Stok form1 = new Stok();

        public UpdateCustomer(Stok parent)
        {
            InitializeComponent();
            form1 = parent;
        }

        CostumerBO objCostumerBO = new CostumerBO();

        private void UpdateCustomer_Load(object sender, System.EventArgs e)
        {
            try
            {
                TextBoxCompanyNameUpdateCustomer.Text = Constants.CompanyNameUpdateCustomer;
                TextBoxAddressUpdateCustomer.Text = Constants.AddressUpdateCustomer;
                TextBoxTelephoneUpdateCustomer.Text = Constants.TelephoneUpdateCustomer;

                objCostumerBO.CostumerName = TextBoxCompanyNameUpdateCustomer.Text;
                objCostumerBO.CostumerAddress = TextBoxAddressUpdateCustomer.Text;
                objCostumerBO.CostumerPhone = TextBoxTelephoneUpdateCustomer.Text;

                CostumerBL objCostumerBL = new CostumerBL();

                objCostumerBO.CostumerID = objCostumerBL.GetCostumerID(objCostumerBO);
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
                objCostumerBO.CostumerName = TextBoxCompanyNameUpdateCustomer.Text;
                objCostumerBO.CostumerAddress = TextBoxAddressUpdateCustomer.Text;
                objCostumerBO.CostumerPhone = TextBoxTelephoneUpdateCustomer.Text;

                CostumerBL objCostumerBL = new CostumerBL();
                objCostumerBL.UpdateCustomer(objCostumerBO);

                MessageBox.Show("Müşteri başarı ile güncellenmiştir");
                this.Close();
                form1.PopulateGridViewCostumers();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
