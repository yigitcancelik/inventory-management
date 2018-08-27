using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BusinessObject;

namespace DataAccess
{
    public class SellDA
    {
        public DataSet PopulateGridViewSellDA() 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CustomerName,ProductName,TypeName,ProductCount,ProductPrice,SellDate From dbo.Sell Order By SellDate Desc", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public void SellProductDA(SellBO objSellBO) 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into dbo.Sell (CustomerName,ProductName,TypeName,ProductCount,ProductPrice,SellDate) Values (@CostumerName,@ProductName,@TypeName,@ProductCount,@ProductPrice,@SellDate)", con);
            cmd.Parameters.Add(new SqlParameter("@CostumerName", objSellBO.CustomerName));
            cmd.Parameters.Add(new SqlParameter("@ProductName", objSellBO.ProductName));
            cmd.Parameters.Add(new SqlParameter("@TypeName", objSellBO.TypeName));
            cmd.Parameters.Add(new SqlParameter("@ProductCount", objSellBO.ProductCount));
            cmd.Parameters.Add(new SqlParameter("@ProductPrice", objSellBO.ProductPrice));
            cmd.Parameters.Add(new SqlParameter("@SellDate", objSellBO.SellDate));
            cmd.ExecuteNonQuery();
        }

        public decimal GetPriceOfProduct(SellBO objSellBO, int ProductID) 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select TypePrice From dbo.Type Where TypeName=@TypeName And ProductID=@ProductID", con);
            cmd.Parameters.Add(new SqlParameter("@TypeName", objSellBO.TypeName));
            cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
            SqlDataReader dr = cmd.ExecuteReader();
            decimal Price = 0;
            if (dr.Read())
            {
                Price = dr.GetDecimal(0);
            }
            return Price;
        }

        public int GetProductID(string ProductName) 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ProductID From dbo.Product Where ProductName=@ProductName", con);
            cmd.Parameters.Add(new SqlParameter("@ProductName", ProductName));
            SqlDataReader dr = cmd.ExecuteReader();
            int ProductID = 0;
            if (dr.Read())
            {
                ProductID = dr.GetInt32(0);
            }
            return ProductID;
        }

        public void ClearSellHistoryDA() 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from dbo.Sell Where SellID in (select top 500 SellID from dbo.Sell order by SellID asc)", con);
            cmd.ExecuteNonQuery();
        }

        public DataSet PopulateGridViewCustomerHistoryDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CustomerName,ProductName,TypeName,ProductCount,ProductPrice,SellDate From dbo.Sell Where CustomerName=@CustomerName Order By SellDate Desc", con);
            cmd.Parameters.Add(new SqlParameter("CustomerName",Constants.CompanyNameCustomerHistory));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public void AddLoanDA(SellBO objSellBO, decimal newLoan)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update dbo.Costumer Set CostumerTotal=@CostumerTotal Where CostumerName=@CostumerName", con);
            cmd.Parameters.Add(new SqlParameter("@CostumerName", objSellBO.CustomerName));
            cmd.Parameters.Add(new SqlParameter("@CostumerTotal", newLoan));
            cmd.ExecuteNonQuery();
        }

        public decimal GetOldLoan(SellBO objSellBO)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CostumerTotal From dbo.Costumer Where CostumerName=@CostumerName", con);
            cmd.Parameters.Add(new SqlParameter("@CostumerName", objSellBO.CustomerName));
            SqlDataReader dr = cmd.ExecuteReader();
            decimal oldLoan = 0;
            if (dr.Read())
            {
                oldLoan = dr.GetDecimal(0);
            }
            return oldLoan;
        }

        public decimal GetTotalLoanDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CostumerTotal From dbo.Costumer Where CostumerName=@CostumerName", con);
            cmd.Parameters.Add(new SqlParameter("@CostumerName", Constants.CompanyNameCustomerHistory));
            SqlDataReader dr = cmd.ExecuteReader();
            decimal total = 0;
            if (dr.Read())
            {
                total = dr.GetDecimal(0);
            }
            return total;
        }
    }
}
