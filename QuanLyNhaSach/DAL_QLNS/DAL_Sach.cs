using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLNS;
using System.Collections;

namespace DAL_QLNS
{
    public class DAL_Sach : DBConnect
    {
        //string maSach, string maGH, string tenSach, string theloai, string tenNCC, string tacgia, string maNV, float giaban, DateTime nxb, DateTime ngaynhap, int soluong, int giamgia
        private String[] strNameParameter = { "@MASACH", "@MAGH", "@TENSACH", "@THELOAI", "@TENNXB", "@TACGIA", "@MANV", "@GIAMGIA", "@NXB", "@NGAYNHAP", "@SOLUONG", "@GIABAN" };

        public int getPrice(String maSach) {
            try
            {
                this.openDB();
                SqlCommand cmd = new SqlCommand("getGiaSach", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                Int32 price = Convert.ToInt32(cmd.ExecuteScalar());
                
                    Console.WriteLine("DA: " + price);
                
                return price;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return 0;
            }
            finally
            {
                this.closeDB();
            }
        }


        public DataTable getSach()
        {
            DataTable dt = new DataTable();
            try
            {
                this.openDB();
                SqlCommand cmd = new SqlCommand("sp_TruyXuatSach", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                this.closeDB();
            }
        }
        public bool xoaSach(string maSach)
        {
            try
            {
                this.openDB();
                SqlCommand cmd = new SqlCommand("sp_XoaSach", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter ptMaSach = new SqlParameter("@MASACH", maSach);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.closeDB();
            }
            return false;
        }
        public bool themSach(ET_Sach sach)
        {
            try
            {
                this.openDB();
                SqlCommand cmd = HandleCMD.proc("sp_ThemSach", _con);
                addParameter(cmd, sach, strNameParameter);
                if (cmd.ExecuteNonQuery() > 0) 
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.closeDB();
            }
            return false;
        }
        public bool suaSach(ET_Sach sach)
        {
            try
            {
                SqlCommand cmd = HandleCMD.proc("sp_SuaSach", _con);
                addParameter(cmd, sach, strNameParameter);
                if (cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public void addParameter(SqlCommand cmd, ET_Sach sach, String[] strNameParametor)
        {
            //string maSach, string maGH, string tenSach, string theloai, string tenNCC, string tacgia, string maNV, float giaban, DateTime nxb, DateTime ngaynhap, int soluong, int giamgia

            ArrayList list = sach.getAllProperties();

            foreach (string item in strNameParametor)
            {
                SqlParameter pt = new SqlParameter(item, list[Array.IndexOf(strNameParametor, item)]);
                cmd.Parameters.Add(pt);
            }
        }
    }
}
