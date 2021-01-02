using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QLNS
{
    public class DAL_DangNhap : DBConnect
    {
        public DataTable GetData(string maNV, string password, bool type)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_LayDangNhapNV", _con);

                SqlParameter ptMaNV = new SqlParameter("@MaNV", maNV);
                SqlParameter ptPass = new SqlParameter("@PASSWORD", password);
                SqlParameter ptType = new SqlParameter("@TYPE", type);

                cmd.Parameters.Add(ptMaNV);
                cmd.Parameters.Add(ptPass);
                cmd.Parameters.Add(ptType);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                closeDB();
            }
        }
    }
}
