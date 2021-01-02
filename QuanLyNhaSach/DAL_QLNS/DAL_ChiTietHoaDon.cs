using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DAL_QLNS;
using ET_QLNS;

namespace DAL_QLNS
{
    public class DAL_ChiTietHoaDon : DBConnect
    {
        String[] strNameParametor = { "MaSach", "MaHD", "SoLuong" };

        public DataTable getChiTietHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_LayThongTinBangChiTietHoaDon", _con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR`1: " + ex.Message);
                return null;
            }
            finally
            {
                closeDB();
            }
        }
        //----------------------------------------------------------------
        //THEM, XOA, SUA
        public bool themChiTietHoaDon(ET_ChiTietHoaDon eT_ChiTietHoaDon)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_ThemChiTietHoaDon", _con);

                addParameter(cmd, eT_ChiTietHoaDon, strNameParametor);

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
        public bool suaChiTietHoaDon(ET_ChiTietHoaDon eT_ChiTietHoaDon)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_CapNhapChiTietHoaDon", _con);
                addParameter(cmd, eT_ChiTietHoaDon, strNameParametor);

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
        public bool xoaChiTietHoaDon(string maHD,String maKH)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_XoaChiTietHoaDon", _con);
                SqlParameter _maHD = new SqlParameter("@MaHD", maHD);
                SqlParameter _maKH = new SqlParameter("@MaKH", maKH);
                cmd.Parameters.Add(_maHD);
                cmd.Parameters.Add(_maKH);
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
        public void addParameter(SqlCommand cmd, ET_ChiTietHoaDon eT_ChiTietHoaDon, String[] strNameParametor)
        { 

            ArrayList list = eT_ChiTietHoaDon.getAllProperties();

            foreach (string item in strNameParametor)
            {
                SqlParameter pt = new SqlParameter(item, list[Array.IndexOf(strNameParametor, item)]);
                cmd.Parameters.Add(pt);
            }
        }
    }
}
