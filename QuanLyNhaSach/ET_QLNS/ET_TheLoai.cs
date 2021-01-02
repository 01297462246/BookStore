using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_TheLoai
    {
        String _MaTL;
        String _MaNCC;
        String _TenTL;

        public ET_TheLoai()
        {
        }

        public ET_TheLoai(string maTL, string maNCC, string tenTL)
        {
            _MaTL = maTL;
            _MaNCC = maNCC;
            _TenTL = tenTL;
        }

        public string MaTL { get => _MaTL; set => _MaTL = value; }
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public string TenTL { get => _TenTL; set => _TenTL = value; }

        public ArrayList getAllProperties()
        {
            ArrayList list = new ArrayList() { MaTL, MaNCC, TenTL };
            return list;
        }
    }
}

