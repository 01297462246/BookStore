using System;
using System.Collections.Generic;
using System.Text;
using ET_QLNS;
using DAL_QLNS;
using System.Data;
namespace BUS_QLNS
{
    public class BUS_GiangHang
    {
        DAL_GiangHang dal_GH = new DAL_GiangHang();
        public DataTable getGH()
        {
            return dal_GH.getGH();
        }
        public bool themGH(ET_GianHang et_GH)
        {
            return dal_GH.themGH(et_GH);
        }
        public bool suaGH(ET_GianHang et_GH)
        {
            return dal_GH.suaGH(et_GH);
        }
        public bool xoaGH(string strMaGH)
        {
            return dal_GH.xoaGH(strMaGH);
        }
    }
}
