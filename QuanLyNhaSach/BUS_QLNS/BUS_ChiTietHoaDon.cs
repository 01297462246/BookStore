using DAL_QLNS;
using ET_QLNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QLNS
{
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon dal_ChiTietHD = new DAL_ChiTietHoaDon();
        public DataTable getChiTietHD()
        {
            return dal_ChiTietHD.getChiTietHoaDon();
        }
        public bool themChiTietHD(ET_ChiTietHoaDon et_ChiTietHD)
        {
            return dal_ChiTietHD.themChiTietHoaDon(et_ChiTietHD);
        }
        public bool suaChiTietHD(ET_ChiTietHoaDon et_ChiTietHD)
        {
            return dal_ChiTietHD.suaChiTietHoaDon(et_ChiTietHD);
        }
        public bool xoaChiTietHD(string strMaSach, string strMaChiTietHD)
        {
            return dal_ChiTietHD.xoaChiTietHoaDon(strMaSach, strMaChiTietHD);
        }
    }
}
