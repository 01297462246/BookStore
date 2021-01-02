using DAL_QLNS;
using ET_QLNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QLNS
{
    public class BUS_TheLoai
    {
        DAL_TheLoai dal_theLoai = new DAL_TheLoai();
        public DataTable getChiTietHD()
        {
            return dal_theLoai.getTheLoai();
        }
        public bool themChiTietHD(ET_TheLoai eT_TheLoai)
        {
            return dal_theLoai.themTheLoai(eT_TheLoai);
        }
        public bool suaChiTietHD(ET_TheLoai eT_TheLoai)
        {
            return dal_theLoai.suaTheLoai(eT_TheLoai);
        }
        public bool xoaChiTietHD(string strMaTL)
        {
            return dal_theLoai.xoaTheLoai(strMaTL);
        }
    }
}
