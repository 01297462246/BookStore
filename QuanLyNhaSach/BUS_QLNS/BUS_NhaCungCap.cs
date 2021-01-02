using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL_QLNS;
using ET_QLNS;

namespace BUS_QLNS
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dal_NCC = new DAL_NhaCungCap();
        //---------------------------------------------------------------------------
        //Lay Du Lieu
        public DataTable getNCC()
        {
            return dal_NCC.getNCC();
        }
        //---------------------------------------------------------------------------
        //Them, Xoa, Sua
        public bool themNCC(ET_NhaCungCap et_NCC)
        {
            return dal_NCC.themNCC(et_NCC);
        }

        public bool suaNCC(ET_NhaCungCap et_NCC)
        {
            return dal_NCC.suaNCC(et_NCC);
        }

        public bool xoaNCC(string strMaNCC)
        {
            return dal_NCC.xoaNCC(strMaNCC);
        }
    }
}
