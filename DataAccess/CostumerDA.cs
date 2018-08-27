using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BusinessObject;

namespace DataAccess
{
    public class CostumerDA
    {
        public void AddCostumerDA(CostumerBO objCostumerBO)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into dbo.Costumer (CostumerName,CostumerAddress,CostumerPhone) Values (@CostumerName,@CostumerAddress,@CostumerPhone)", con);
            cmd.Parameters.Add(new SqlParameter("@CostumerName", objCostumerBO.CostumerName));
            cmd.Parameters.Add(new SqlParameter("@CostumerAddress", objCostumerBO.CostumerAddress));
            cmd.Parameters.Add(new SqlParameter("@CostumerPhone", objCostumerBO.CostumerPhone));
            cmd.ExecuteNonQuery();
        }

        public DataSet PopulateGridViewCostumerDA() 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CostumerName,CostumerAddress,CostumerPhone From dbo.Costumer Order By CostumerName", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public DataSet PopulateComboBoxCostumerSellDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CostumerID,CostumerName From dbo.Costumer", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public void DeleteCostumerDA(string CostumerName)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From dbo.Costumer Where CostumerName=@CostumerName", con);
            cmd.Parameters.Add(new SqlParameter("@CostumerName", CostumerName));
            cmd.ExecuteNonQuery();
        }

        public void UpdateCostumer(CostumerBO objCostumerBO)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update dbo.Costumer Set CostumerName=@CostumerName,CostumerAddress=@CostumerAddress,CostumerPhone=@CostumerPhone Where CostumerID=@CostumerID", con);
            cmd.Parameters.Add(new SqlParameter("@CostumerID", objCostumerBO.CostumerID));
            cmd.Parameters.Add(new SqlParameter("@CostumerName", objCostumerBO.CostumerName));
            cmd.Parameters.Add(new SqlParameter("@CostumerAddress", objCostumerBO.CostumerAddress));
            cmd.Parameters.Add(new SqlParameter("@CostumerPhone", objCostumerBO.CostumerPhone));
            cmd.ExecuteNonQuery();
        }

        public int GetCostumerID(CostumerBO objCostumerBO)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CostumerID From dbo.Costumer Where CostumerName=@CostumerName", con);
            cmd.Parameters.Add(new SqlParameter("@CostumerName", objCostumerBO.CostumerName));
            SqlDataReader dr = cmd.ExecuteReader();
            int CostumerID = 0;
            if (dr.Read())
            {
                CostumerID = dr.GetInt32(0);
            }
            return CostumerID;
        }

        public void PayLoanDA(SellBO objSellBO, decimal newLoan)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update dbo.Costumer Set CostumerTotal=@CostumerTotal Where CostumerName=@CostumerName", con);
            cmd.Parameters.Add(new SqlParameter("@CostumerName", objSellBO.CustomerName));
            cmd.Parameters.Add(new SqlParameter("@CostumerTotal", newLoan));
            cmd.ExecuteNonQuery();
        }
    }
}
