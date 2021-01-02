using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLNS
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection("Data Source=.;Initial Catalog=QuanLyNhaSach;Integrated Security=True");
        
        protected void openDB()
        {
            if(_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
        }
        protected bool cmdExecuted(SqlCommand cmd)
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }
        protected void closeDB()
        {
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
        }
    }
}
