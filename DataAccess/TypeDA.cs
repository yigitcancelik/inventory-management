using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BusinessObject;

namespace DataAccess
{
    public class TypeDA
    {
        public void AddTypeDA(TypeBO objTypeBO) 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into dbo.Type (TypeName,TypeCount,TypePrice,ProductID) Values (@TypeName,@TypeCount,@TypePrice,@ProductID)", con);
            cmd.Parameters.Add(new SqlParameter("@TypeName", objTypeBO.TypeName));
            cmd.Parameters.Add(new SqlParameter("@TypeCount", objTypeBO.TypeCount));
            cmd.Parameters.Add(new SqlParameter("@TypePrice", objTypeBO.TypePrice));
            cmd.Parameters.Add(new SqlParameter("@ProductID", objTypeBO.ProductID));
            cmd.ExecuteNonQuery();
        }

        public DataSet PopulateComboBoxProductTypeDA(int ProductID)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select TypeID,TypeName From dbo.Type Where ProductID=@ProductID", con);
            cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public void AddProductToStockDA(TypeBO objTypeBO) 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update dbo.Type Set TypeCount=@TypeCount Where TypeName=@TypeName And ProductID=@ProductID", con);
            cmd.Parameters.Add(new SqlParameter("@TypeName", objTypeBO.TypeName));
            cmd.Parameters.Add(new SqlParameter("@ProductID", objTypeBO.ProductID));
            cmd.Parameters.Add(new SqlParameter("@TypeCount", objTypeBO.TypeCount));
            cmd.ExecuteNonQuery();
        }

        public int GetOldTypeCount(string TypeName, int ProductID) 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select TypeCount From dbo.Type Where TypeName=@TypeName And ProductID=@ProductID",con);
            cmd.Parameters.Add(new SqlParameter("@TypeName", TypeName));
            cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
            SqlDataReader dr = cmd.ExecuteReader();
            int oldCount = 0 ;
            if (dr.Read()) 
            {
                oldCount = dr.GetInt32(0);
            }
            return oldCount;
        }

        public void DecreaseFromStock(string TypeName, int ProductID, int NewTypeCount)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update dbo.Type Set TypeCount=@TypeCount Where TypeName=@TypeName And ProductID=@ProductID", con);
            cmd.Parameters.Add(new SqlParameter("@TypeName", TypeName));
            cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
            cmd.Parameters.Add(new SqlParameter("@TypeCount", NewTypeCount));
            cmd.ExecuteNonQuery();
        }

        public DataSet PopulateGridViewProductsDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Product.ProductName,Type.TypeName,Type.TypePrice From dbo.Product, dbo.Type Where Product.ProductID = Type.ProductID Group by Product.ProductName,Type.TypeName, Type.TypePrice", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public void DeleteTypeBL(int ProductID, string TypeName)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From dbo.Type Where TypeName=@TypeName And ProductID=@ProductID", con);
            cmd.Parameters.Add(new SqlParameter("@TypeName", TypeName));
            cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
            cmd.ExecuteNonQuery();
        }

        public void DeleteTypeBL(int ProductID)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From dbo.Type Where ProductID=@ProductID", con);
            cmd.Parameters.Add(new SqlParameter("@ProductID", ProductID));
            cmd.ExecuteNonQuery();
        }

        public int GetTypeID(TypeBO objTypeBO)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select TypeID From dbo.Type Where ProductID=@ProductID And TypeName=@TypeName", con);
            cmd.Parameters.Add(new SqlParameter("@ProductID", objTypeBO.ProductID));
            cmd.Parameters.Add(new SqlParameter("@TypeName", objTypeBO.TypeName));
            SqlDataReader dr = cmd.ExecuteReader();
            int TypeID = 0;
            if (dr.Read())
            {
                TypeID = dr.GetInt32(0);
            }
            return TypeID;
        }

        public void UpdateProduct(TypeBO objTypeBO)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update dbo.Type Set TypeName=@TypeName,TypePrice=@TypePrice Where TypeID=@TypeID", con);
            cmd.Parameters.Add(new SqlParameter("@TypeID", objTypeBO.TypeID));
            cmd.Parameters.Add(new SqlParameter("@TypeName", objTypeBO.TypeName));
            cmd.Parameters.Add(new SqlParameter("@TypePrice", objTypeBO.TypePrice));
            cmd.ExecuteNonQuery();
        }
    }
}
