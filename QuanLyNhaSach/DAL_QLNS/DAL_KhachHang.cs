using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLNS;
using System.Collections;

namespace DAL_QLNS
{
    public class DAL_KhachHang : DBConnect
    {
        string[] strNameParametor = { "@MAKH", "@TENKH", "@NAMSINH", "@DOITUONG", "@SDT" };

        public DataTable getData()
        {
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_KhachHang", _con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _con.Close();
            }
        }

        public bool themKhachHang(ET_KhachHang et_KH)
        {
            try
            {
                _con.Open();
                SqlCommand cmd = HandleCMD.proc("sp_ThemKhachHang", _con);
                addParameter(cmd, et_KH, strNameParametor);

                if (cmdExecuted(cmd))
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                _con.Close();
            }
            return false;
        }

        public bool xoaKhachHang(string MaKH)
        {
            try
            {
                _con.Open();
                SqlCommand cmd = HandleCMD.proc("sp_XoaKhachHang", _con);

                SqlParameter ptMaKH = new SqlParameter("@MAKH", MaKH);

                cmd.Parameters.Add(ptMaKH);

                if (cmdExecuted(cmd))
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                _con.Close();
            }
            return false;
        }

        public bool suaKhachHang(ET_KhachHang et_KH)
        {
            try
            {
                _con.Open();
                SqlCommand cmd = HandleCMD.proc("sp_SuaKhachHang", _con);
                addParameter(cmd, et_KH, strNameParametor);

                if (cmdExecuted(cmd))
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                _con.Close();
            }

            return false;
        }

        //----------------------------------------------------------------
        //HAM PHU
        public void addParameter(SqlCommand cmd, ET_KhachHang et_KH, String[] strNameParametor)
        { //MaGH, TenGH, SoLuongSach

            ArrayList list = et_KH.getAllProperties();

            foreach (string item in strNameParametor)
            {
                SqlParameter pt = new SqlParameter(item, list[Array.IndexOf(strNameParametor, item)]);
                cmd.Parameters.Add(pt);
            }
        }
    }
}
