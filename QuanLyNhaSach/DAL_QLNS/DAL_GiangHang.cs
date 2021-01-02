using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLNS;
using System.Collections;
namespace DAL_QLNS
{
    public class DAL_GiangHang : DBConnect
    {
        string[] strNameParametor = { "@MAGH", "@TENGH", "@SOLUONG" };
        //---------------------------------------------------------------
        //LAY DU LIEU
        public DataTable getGH()
        {
            DataTable dt = new DataTable();
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_TruyXuatGH", _con);
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
        public bool themGH(ET_GianHang et_GH)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_ThemGH", _con);

                addParameter(cmd, et_GH, strNameParametor);

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
        public bool suaGH(ET_GianHang et_GH)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_SuaGH", _con);
                addParameter(cmd, et_GH, strNameParametor);

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
        public bool xoaGH(string maGH)
        {
            try
            {
                openDB();
                SqlCommand cmd = HandleCMD.proc("sp_xoaGH", _con);
                SqlParameter pt = new SqlParameter("@MAGH", maGH);
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
        public void addParameter(SqlCommand cmd, ET_GianHang gianHang, String[] strNameParametor)
        { //MaGH, TenGH, SoLuongSach

            ArrayList list = gianHang.getAllProperties();

            foreach (string item in strNameParametor)
            {
                SqlParameter pt = new SqlParameter(item, list[Array.IndexOf(strNameParametor, item)]);
                cmd.Parameters.Add(pt);
            }
        }
    }
}
