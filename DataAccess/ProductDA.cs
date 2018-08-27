using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BusinessObject;

namespace DataAccess
{
    public class ProductDA
    {
        public void AddProductDA(ProductBO objProductBO) 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into dbo.Product (ProductName) Values (@ProductName)",con);
            cmd.Parameters.Add(new SqlParameter("@ProductName",objProductBO.ProductName));
            cmd.ExecuteNonQuery();
        }

        public DataSet PopulateComboBoxProductNameAddProductDA() 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From dbo.Product", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public DataSet PopulateGridViewStockDA() 
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Product.ProductName,Type.TypeName,Type.TypeCount From dbo.Product, dbo.Type Where Product.ProductID = Type.ProductID Group by Product.ProductName,Type.TypeName, Type.TypeCount", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public DataSet PopulateComboBoxProductNameDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From dbo.Product", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public void DeleteProductBL(string ProductName)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From dbo.Product Where ProductName=@ProductName", con);
            cmd.Parameters.Add(new SqlParameter("@ProductName", ProductName));
            cmd.ExecuteNonQuery();
        }

        public string GetProductName(int ProductID)
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ProductName From dbo.Product Where ProductID=@ProductID", con);
            cmd.Parameters.Add(new SqlParameter("@ProductID",ProductID));
            SqlDataReader dr = cmd.ExecuteReader();
            string ProductName = "";
            if (dr.Read())
            {
                ProductName = dr.GetString(0);
            }
            return ProductName;
        }
    }
}
