using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BusinessObject;

namespace DataAccess
{
    public class PreferencesDA
    {
        public string[] SetColorDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select EmptyColor,NormalColor,LowColor From dbo.Preferences", con);
            SqlDataReader dr = cmd.ExecuteReader();
            string []color = new string[3];
            if (dr.Read())
            {
                color[0] = dr.GetString(0);
                color[1] = dr.GetString(1);
                color[2] = dr.GetString(2);
            }
            return color;
        }

        public int SetLimitDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Limit From dbo.Preferences", con);
            SqlDataReader dr = cmd.ExecuteReader();
            int Limit = 0;
            if (dr.Read())
            {
                Limit = dr.GetInt32(0);
            }
            return Limit;
        }

        public void ChangeLimitDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update dbo.Preferences Set Limit=@Limit", con);
            cmd.Parameters.Add(new SqlParameter("@Limit", PreferencesBO.Limit));
            cmd.ExecuteNonQuery();
        }

        public void ChangeColorDA()
        {
            DbConnection objDbConnection = DbConnection.GetInstance();
            SqlConnection con = objDbConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update dbo.Preferences Set EmptyColor=@EmptyColor,NormalColor=@NormalColor,LowColor=@LowColor", con);
            cmd.Parameters.Add(new SqlParameter("@EmptyColor", PreferencesBO.EmptyColor));
            cmd.Parameters.Add(new SqlParameter("@NormalColor", PreferencesBO.NormalColor));
            cmd.Parameters.Add(new SqlParameter("@LowColor", PreferencesBO.LowColor));
            cmd.ExecuteNonQuery();
        }
    }
}
