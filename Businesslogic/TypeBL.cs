using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BusinessObject;
using DataAccess;

namespace Businesslogic
{
    public class TypeBL
    {
        public void AddTypeBL(TypeBO objTypeBO) 
        {
            objTypeBO.TypeCount = 0;
            TypeDA objTypeDA = new TypeDA();
            objTypeDA.AddTypeDA(objTypeBO);
        }

        public DataSet PopulateComboBoxProductTypeBL(int ProductID)
        {
            TypeDA objTypeDA = new TypeDA();
            return objTypeDA.PopulateComboBoxProductTypeDA(ProductID);
        }

        public void AddProductToStockBL(TypeBO objTypeBO) 
        {
            StockBO objStockBO = new StockBO();
            StockDA objStockDA = new StockDA();
            TypeDA objTypeDA = new TypeDA();
            ProductDA objProductDA = new ProductDA();
            
            objStockBO.StockName = objProductDA.GetProductName(objTypeBO.ProductID);
            objStockBO.StockType = objTypeBO.TypeName;
            objStockBO.StockCount = objTypeBO.TypeCount;
            objStockBO.StockDate = DateTime.Today ;
           
            int oldCount = objTypeDA.GetOldTypeCount(objTypeBO.TypeName,objTypeBO.ProductID);
            objTypeBO.TypeCount = objTypeBO.TypeCount + oldCount;
            
            objTypeDA.AddProductToStockDA(objTypeBO);
            objStockDA.AddStockRecord(objStockBO);
        }

        public DataSet PopulateGridViewProductsBL()
        {
            TypeDA objTypeDA = new TypeDA();
            DataSet ds = objTypeDA.PopulateGridViewProductsDA();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                decimal dec = Convert.ToDecimal(ds.Tables[0].Rows[i][2]);
                string decStr = dec.ToString("0.##");
                ds.Tables[0].Rows[i].SetField(2, decStr);
                ds.AcceptChanges();
            }
            return ds;
        }

        public void DeleteTypeBL(string ProductName, string TypeName)
        {
            TypeDA objTypeDA = new TypeDA();
            SellDA objSellDA = new SellDA();

            int ProductID = objSellDA.GetProductID(ProductName);
            objTypeDA.DeleteTypeBL(ProductID,TypeName);
        }

        public int GetTypeID(TypeBO objTypeBO)
        {
            TypeDA objTypeDA = new TypeDA();
            return objTypeDA.GetTypeID(objTypeBO);
        }

        public void UpdateProduct(TypeBO objTypeBO)
        {
            TypeDA objTypeDA = new TypeDA();
            objTypeDA.UpdateProduct(objTypeBO);
        }
    }
}
