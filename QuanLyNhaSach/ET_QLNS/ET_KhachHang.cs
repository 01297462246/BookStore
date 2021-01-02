using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_KhachHang
    {
        private string _MaKH;
        private string _TenKH;
        private DateTime _NamSinh;
        private string _DoiTuong;
        private string _SDT;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public DateTime NamSinh { get => _NamSinh; set => _NamSinh = value; }
        public string DoiTuong { get => _DoiTuong; set => _DoiTuong = value; }
        public string SDT { get => _SDT; set => _SDT = value; }

        public ET_KhachHang()
        {

        }

        public ArrayList getAllProperties()
        {
            return new ArrayList() { MaKH, TenKH, NamSinh, DoiTuong, SDT };
        }

        public ET_KhachHang(string maKH, string tenKH, DateTime namsinh, string doituong, string sdt)
        {
            this._MaKH = maKH;
            this._TenKH = tenKH;
            this._NamSinh = namsinh;
            this._DoiTuong = doituong;
            this._SDT = sdt;
        }
    }
}
