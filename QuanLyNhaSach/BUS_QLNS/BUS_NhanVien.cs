using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAL_QLNS;
using ET_QLNS;
namespace BUS_QLNS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien DAL_NhanVien = new DAL_NhanVien();
        //---------------------------------------------------------------------------
        //Lay Du Lieu
        public DataTable GetData()
        {
            return DAL_NhanVien.getNhanVien();
        }
        //---------------------------------------------------------------------------
        //Them, Xoa, Sua
        public bool ThemNhanVien(ET_NhanVien et_NhanVien)
        {
            return DAL_NhanVien.ThemNhanVien(et_NhanVien);
        }
        public bool XoaNhanVien(string str_NhanVien)
        {
            return DAL_NhanVien.XoaNhanVien(str_NhanVien);
        }
        public bool SuaNhanVien(ET_NhanVien et_NhanVien)
        {
            return DAL_NhanVien.SuaNhanVien(et_NhanVien);
        }
    }
}
