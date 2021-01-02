using System;
using System.Collections.Generic;
using System.Text;
using ET_QLNS;
using DAL_QLNS;
using System.Data;
using System.Data.SqlClient;
namespace BUS_QLNS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
        //---------------------------------------------------------------------------
        //Lay Du Lieu

        public DataTable getData()
        {
            return dal_KhachHang.getData();
        }

        //---------------------------------------------------------------------------
        //Them, Xoa, Sua

        public bool themKhachHang(ET_KhachHang et_KhachHang)
        {
            return dal_KhachHang.themKhachHang(et_KhachHang);
        }

        public bool xoaKhachHang(string MaKH)
        {
            return dal_KhachHang.xoaKhachHang(MaKH);
        }

        public bool suaKhachHang(ET_KhachHang et_KhachHang)
        {
            return dal_KhachHang.suaKhachHang(et_KhachHang);
        }
    }
}
