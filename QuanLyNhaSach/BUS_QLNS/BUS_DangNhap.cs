using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL_QLNS;
namespace BUS_QLNS
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dp = new DAL_DangNhap();
        public DataTable GetData(string maNV, string password, bool type)
        {
            return dp.GetData(maNV, password, type);
        }
    }
}
