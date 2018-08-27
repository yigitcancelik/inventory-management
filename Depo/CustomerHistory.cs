using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Businesslogic;
using BusinessObject;
using System.Data;

namespace StokYönetim
{
    public partial class CustomerHistory : Form
    {
        Stok form = new Stok();

        public CustomerHistory(Stok parent)
        {
            InitializeComponent();
            form = parent;
        }

        private void CustomerHistory_Load(object sender, System.EventArgs e)
        {
            SellBL objSellBL = new SellBL();
            DataSet ds = objSellBL.PopulateGridViewCustomerHistoryBL();

            ds.Tables[0].Columns[0].ColumnName = "Firma Adı";
            ds.Tables[0].Columns[1].ColumnName = "Ürün Adı";
            ds.Tables[0].Columns[2].ColumnName = "Ürün Türü";
            ds.Tables[0].Columns[3].ColumnName = "Sayısı";
            ds.Tables[0].Columns[4].ColumnName = "Fiyat";
            ds.Tables[0].Columns[5].ColumnName = "Tarih";

            DataGridViewCustomerHistory.DataSource = ds;
            DataGridViewCustomerHistory.DataMember = ds.Tables[0].ToString();

            string decStr = objSellBL.GetTotalLoanBL().ToString("0.##");
            TextBoxTotalLoan.Text = decStr;
        }

        private void ButtonPayLoan_Click(object sender, EventArgs e)
        {
            SellBL objSellBL = new SellBL();
            SellBO objSellBO = new SellBO();
            objSellBO.CustomerName = Constants.CompanyNameCustomerHistory;
            bool payed = objSellBL.PayLoanDA(objSellBO, Convert.ToDecimal(TextBoxPayment.Text));
            if (payed == false)
            {
                MessageBox.Show("Borçtan daha fazla ödeme yapılamaz");
            }
            else 
            {
                MessageBox.Show("Ödeme Gerçekleşti");

                string decStr = objSellBL.GetTotalLoanBL().ToString("0.##");
                TextBoxTotalLoan.Text = decStr;

                TextBoxPayment.Text = "";
            }
        }
    }
}
