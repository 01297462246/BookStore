using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ET_QLNS;
namespace DAL_QLNS
{
    public class DAL_NhaCungCap : DBConnect
    {
        string[] strNameParametor = {
            "@MaNCC" ,
            "@TenNXB"  ,
            "@SDT"  ,
            "@SoFax" ,
            "@DiaChi" ,   
            "@NgayNhap" ,
            "@TongSoLuong" ,
            "@GiaTien" ,
            "@MaNV"
        };
        //---------------------------------------------------------------
        //LAY DU LIEU
        public DataTable getNCC()
        {
            DataTable dt = new DataTable();
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_TruyXuatNhaCungCap", _con);
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
                closeDB();
            }
        }
        //----------------------------------------------------------------
        //THEM, XOA, SUA
        public bool themNCC(ET_NhaCungCap et_NCC)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_ThemNhaCungCap", _con);

                addParameter(cmd, et_NCC, strNameParametor);

                if (this.cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                closeDB();
            }
            return false;
        }
        public bool suaNCC(ET_NhaCungCap et_NCC)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_CapNhatNhaCungCap", _con);
                addParameter(cmd, et_NCC, strNameParametor);

                if (this.cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                closeDB();
            }
            return false;
        }
        public bool xoaNCC(string maNCC)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_XoaNhaCungCap", _con);
                SqlParameter pt = new SqlParameter("@MaNCC", maNCC);
                cmd.Parameters.Add(pt);
                if (this.cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
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
        public void addParameter(SqlCommand cmd, ET_NhaCungCap nhaCungCap, String[] strNameParametor)
        { //MaGH, TenGH, SoLuongSach

            ArrayList list = nhaCungCap.getAllProperties();

            foreach (string item in strNameParametor)
            {
                SqlParameter pt = new SqlParameter(item, list[Array.IndexOf(strNameParametor, item)]);
                cmd.Parameters.Add(pt);
            }
        }
    }
}
