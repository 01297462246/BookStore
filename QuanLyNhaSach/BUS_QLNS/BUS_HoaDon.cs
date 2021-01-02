using System;
using System.Collections.Generic;
using System.Text;
using ET_QLNS;
using DAL_QLNS;
using System.Data;
namespace BUS_QLNS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dal_HD = new DAL_HoaDon();

        public String getEndID() {
            return dal_HD.getEndHoaDonID();
        }
        public DataTable getHD()
        {
            return dal_HD.getHoaDon();
        }
        public bool themHD(ET_HoaDon et_HD)
        {
            return dal_HD.themHD(et_HD);
        }
        public bool suaHD(ET_HoaDon et_HD)
        {
            return dal_HD.suaHD(et_HD);
        }
        public bool xoaHD(string strMaHD)
        {
            return dal_HD.xoaHD(strMaHD);
        }
    }
}
