using System;
using System.Collections.Generic;
using System.Text;
using DAL_QLNS;
using ET_QLNS;
using System.Data;
using System.Data.SqlClient;
namespace BUS_QLNS
{
    public class BUS_Sach
    {
        DAL_Sach dal_Sach = new DAL_Sach();

        public int getGiaSach(String maSach) {

            return dal_Sach.getPrice(maSach);
        }

        public DataTable getSach()
        {
            return dal_Sach.getSach();
        }
        public bool xoaSach(string str_MaSach)
        {
            return dal_Sach.xoaSach(str_MaSach);
        }
        public bool themSach(ET_Sach et_Sach)
        {
            return dal_Sach.themSach(et_Sach);
        }
        public bool suaSach(ET_Sach et_Sach)
        {
            return dal_Sach.suaSach(et_Sach);
        }
    }
}
