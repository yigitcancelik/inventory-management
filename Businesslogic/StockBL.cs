using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BusinessObject;
using DataAccess;

namespace Businesslogic
{
    public class StockBL
    {
        public DataSet PopulateGridViewStockHistoryBL()
        {
            StockDA objStockDA = new StockDA();
            return objStockDA.PopulateGridViewStockHistoryDA();
        }

        public void ClearStockHistoryBL() 
        {
            StockDA objStockDA = new StockDA();
            objStockDA.ClearStockHistoryDA();
        }
    }
}
