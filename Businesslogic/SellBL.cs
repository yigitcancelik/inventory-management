using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BusinessObject;
using DataAccess;

namespace Businesslogic
{
    public class SellBL
    {
        public DataSet PopulateGridViewSellBL()
        {
            SellDA objSellDA = new SellDA();
            DataSet ds = objSellDA.PopulateGridViewSellDA();
            for(int i = 0 ; i < ds.Tables[0].Rows.Count ; i++){
                decimal dec = Convert.ToDecimal(ds.Tables[0].Rows[i][4]);
                string decStr = dec.ToString("0.##");
                ds.Tables[0].Rows[i].SetField(4,decStr);
                ds.AcceptChanges();
            }
            return ds;
        }

        public bool SellProductBL(SellBO objSellBO)
        {
            SellDA objSellDA = new SellDA();
            int ProductID = objSellDA.GetProductID(objSellBO.ProductName);
           
            TypeDA objTypeDA = new TypeDA();
            int OldTypeCount = objTypeDA.GetOldTypeCount(objSellBO.TypeName, ProductID);
            Constants.RemainingProduct = OldTypeCount;
            if (OldTypeCount < objSellBO.ProductCount)
            {
                return false;
            }
            int NewTypeCount = OldTypeCount - objSellBO.ProductCount;
            objTypeDA.DecreaseFromStock(objSellBO.TypeName,ProductID,NewTypeCount);

            decimal Price = objSellDA.GetPriceOfProduct(objSellBO,ProductID);
            objSellBO.ProductPrice = Price * objSellBO.ProductCount;
            objSellDA.SellProductDA(objSellBO);
            
            decimal oldLoan = objSellDA.GetOldLoan(objSellBO);
            decimal newLoan = oldLoan + objSellBO.ProductPrice;
            objSellDA.AddLoanDA(objSellBO,newLoan);
            
            return true;
        }

        public decimal CalculatePriceBL(SellBO objSellBO) 
        {
            SellDA objSellDA = new SellDA();
            int ProductID = objSellDA.GetProductID(objSellBO.ProductName);
            decimal Price = objSellDA.GetPriceOfProduct(objSellBO, ProductID);
            objSellBO.ProductPrice = Price * objSellBO.ProductCount;
            return objSellBO.ProductPrice;
        }

        public void ClearSellHistoryBL() 
        {
            SellDA objSellDA = new SellDA();
            objSellDA.ClearSellHistoryDA();
        }

        public DataSet PopulateGridViewCustomerHistoryBL() 
        {
            SellDA objSellDA = new SellDA();
            DataSet ds = objSellDA.PopulateGridViewCustomerHistoryDA();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                decimal dec = Convert.ToDecimal(ds.Tables[0].Rows[i][4]);
                string decStr = dec.ToString("0.##");
                ds.Tables[0].Rows[i].SetField(4, decStr);
                ds.AcceptChanges();
            }
            return ds;
        }

        public decimal GetTotalLoanBL()
        {
            SellDA objSellDA = new SellDA();
            return objSellDA.GetTotalLoanDA();
        }

        public bool PayLoanDA(SellBO objSellBO, decimal payment)
        {
            SellDA objSellDA = new SellDA();
            CostumerDA objCostumerDA = new CostumerDA();
            decimal oldLoan = objSellDA.GetOldLoan(objSellBO);
            decimal newLoan = 0;
            if (oldLoan < payment)
            {
                return false;
            }
            else 
            {
                newLoan = oldLoan - payment;
                objCostumerDA.PayLoanDA(objSellBO,newLoan);
                return true;
            }
        }
    }
}
