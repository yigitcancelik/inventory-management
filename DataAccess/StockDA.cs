using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BusinessObject;

namespace DataAccess
{
    public class StockDA
    {

        public void AddStockRecord(StockBO objStockBO)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into dbo.Stock (StockName,StockType,StockCount,StockDate) Values (@StockName,@StockType,@StockCount,@StockDate)", con);
            cmd.Parameters.Add(new SqlParameter("@StockName", objStockBO.StockName));
            cmd.Parameters.Add(new SqlParameter("@StockType", objStockBO.StockType));
            cmd.Parameters.Add(new SqlParameter("@StockCount", objStockBO.StockCount));
            cmd.Parameters.Add(new SqlParameter("@StockDate", objStockBO.StockDate));
            cmd.ExecuteNonQuery();
        }

        public DataSet PopulateGridViewStockHistoryDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select StockName,StockType,StockCount,StockDate From dbo.Stock Order By StockDate Desc", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public void ClearStockHistoryDA() 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from dbo.Stock Where StockID in (select top 500 StockID from dbo.Stock order by StockID asc)", con);
            cmd.ExecuteNonQuery();
        }
    }
}
