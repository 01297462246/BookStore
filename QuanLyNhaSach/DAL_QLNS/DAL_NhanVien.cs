using System;
using System.Collections.Generic;
using System.Text;
using ET_QLNS;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DAL_QLNS
{
    public class DAL_NhanVien : DBConnect
    {
        string[] properties_QL = { "@MANV", "@TENNV", "@CMND", "@SDT", "@DC", "@MAGH", "@MAQL" };
        string[] properties = { "@MANV", "@TENNV", "@CMND", "@SDT", "@DC", "@MAGH" };

        //-----------------------------------------------------------------------------
        //Lay nhan vien
        public DataTable getNhanVien()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = HandleCMD.proc("sp_TruyXuatNhanVien", _con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //-----------------------------------------------------------------------------
        //Them,Xoa, Sua
        public bool ThemNhanVien(ET_NhanVien et_NhanVien)
        {
            try
            {
                openDB();
                //cmd
                SqlCommand cmd = null; 
                if (et_NhanVien.MaQL == null) //Không có MaQL
                {
                    //cmd
                    cmd = HandleCMD.proc("sp_ThemQuanLy", _con);
                    addParameter(cmd, et_NhanVien, properties); // add parameter.
                }
                else //Có MaQL.
                {
                    cmd = HandleCMD.proc("sp_ThemNhanVien", _con);
                    addParameter(cmd, et_NhanVien, properties_QL); // add parameter.
                }
                if (cmdExecuted(cmd))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return false;
            }
            finally
            {
                closeDB();
            }

            return false;
        }
        public bool XoaNhanVien(string strNhanVien)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_XoaNhanVien", _con);
                SqlParameter pt = new SqlParameter("@MaNV", strNhanVien);
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
        public bool SuaNhanVien(ET_NhanVien et_NhanVien)
        {
            try
            {
                openDB();
                SqlCommand cmd = null;
                //parameter
                if (et_NhanVien.MaQL == null) //Không có MaQL
                {
                    //cmd
                    cmd = HandleCMD.proc("sp_SuaQuanLy", _con);
                    addParameter(cmd, et_NhanVien, properties); // add parameter.
                }
                else //Có MaQL.
                {
                    cmd = HandleCMD.proc("sp_SuaNhanVien", _con);
                    addParameter(cmd, et_NhanVien, properties_QL); // add parameter.
                }
                if (cmdExecuted(cmd))
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
        //----------------------------------------------------------------------------
        //Ham Bo tro
        public void addParameter(SqlCommand cmd, ET_NhanVien nhanvien, String[] strNameParametor)
        { //MaNV, TenNV, CMND, SDT, DC, MaGH 

            ArrayList list = nhanvien.getAllPropertie();

            foreach (string item in strNameParametor)
            {
                SqlParameter pt = new SqlParameter(item, list[Array.IndexOf(strNameParametor, item)]);
                cmd.Parameters.Add(pt);
            }
        }
    }
}
