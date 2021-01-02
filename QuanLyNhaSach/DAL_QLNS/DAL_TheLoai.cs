using ET_QLNS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QLNS
{
    public class DAL_TheLoai : DBConnect
    {
        String[] strNameParametor = { "MaTL", "MaNCC", "TenTL" };

        public DataTable getTheLoai()
        {
            DataTable dt = new DataTable();
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_LayThongTinBangTheLoai", _con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                closeDB();
            }
        }
        //----------------------------------------------------------------
        //THEM, XOA, SUA
        public bool themTheLoai(ET_TheLoai eT_TheLoai)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_ThemTheLoai", _con);
                addParameter(cmd, eT_TheLoai, strNameParametor);
                if (this.cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
            finally
            {
                closeDB();
            }
            return false;
        }
        public bool suaTheLoai(ET_TheLoai eT_TheLoai)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_CapNhatTheLoai", _con);
                addParameter(cmd, eT_TheLoai, strNameParametor);

                if (this.cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
            finally
            {
                closeDB();
            }
            return false;
        }
        public bool xoaTheLoai(string maTL)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_XoaTheLoai", _con);
                SqlParameter _maHD = new SqlParameter("MaTL", maTL);
                cmd.Parameters.Add(_maHD);
                if (this.cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
            finally
            {
                closeDB();
            }
            return false;
        }
        //----------------------------------------------------------------
        //HAM PHU
        public void addParameter(SqlCommand cmd, ET_TheLoai eT_TheLoai, String[] strNameParametor)
        {
            ArrayList list = eT_TheLoai.getAllProperties();
            foreach (string item in strNameParametor)
            {
                SqlParameter pt = new SqlParameter(item, list[Array.IndexOf(strNameParametor, item)]);
                cmd.Parameters.Add(pt);
            }
        }
    }
}
