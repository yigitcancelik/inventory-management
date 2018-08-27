using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BusinessObject;
using DataAccess;

namespace Businesslogic
{
    public class CostumerBL
    {
        public void AddCostumerBL(CostumerBO objCostumerBO)
        {
            CostumerDA objCostumerDA = new CostumerDA();
            objCostumerDA.AddCostumerDA(objCostumerBO);
        }

        public DataSet PopulateGridViewCostumerBL() 
        {
            CostumerDA objCostumerDA = new CostumerDA();
            return objCostumerDA.PopulateGridViewCostumerDA();
        }

        public DataSet PopulateComboBoxCostumerSellBL()
        {
            CostumerDA objCostumerDA = new CostumerDA();
            return objCostumerDA.PopulateComboBoxCostumerSellDA();
        }

        public void DeleteCostumerBL(string CostumerName)
        {
            CostumerDA objCostumerDA = new CostumerDA();
            objCostumerDA.DeleteCostumerDA(CostumerName);
        }

        public void UpdateCustomer(CostumerBO objCostumerBO)
        {
            CostumerDA objCostumerDA = new CostumerDA();
            objCostumerDA.UpdateCostumer(objCostumerBO);
        }

        public int GetCostumerID(CostumerBO objCostumerBO)
        {
            CostumerDA objCostumerDA = new CostumerDA();
            return objCostumerDA.GetCostumerID(objCostumerBO);
        }
    }
}
