using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BusinessObject;
using DataAccess;

namespace Businesslogic
{
    public class ProductBL
    {
        public void AddProductBL(string ProductName)
        {
            ProductBO objProductBO = new ProductBO();
            objProductBO.ProductName = ProductName;
            ProductDA objProductDA = new ProductDA();
            objProductDA.AddProductDA(objProductBO);
        }

        public DataSet PopulateComboBoxProductNameAddProductBL()
        {
            ProductDA objProductDA = new ProductDA();
            return objProductDA.PopulateComboBoxProductNameAddProductDA();
        }

        public DataSet PopulateGridViewStockBL() 
        {
            ProductDA objProductDA = new ProductDA();
            return objProductDA.PopulateGridViewStockDA();
        }

        public DataSet PopulateComboBoxProductNameBL()
        {
            ProductDA objProductDA = new ProductDA();
            return objProductDA.PopulateComboBoxProductNameDA();
        }

        public void DeleteProductBL(string ProductName)
        {
            SellDA objSellDA = new SellDA();
            ProductDA objProductDA = new ProductDA();
            TypeDA objTypeDA = new TypeDA();
            int ProductID = objSellDA.GetProductID(ProductName);
            objProductDA.DeleteProductBL(ProductName);
            objTypeDA.DeleteTypeBL(ProductID);
        }

        public int GetProductID(string ProductName)
        {
            SellDA objSellDA = new SellDA();
            return objSellDA.GetProductID(ProductName);
        }
    }
}
