using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_NhanVien
    {
        //Mã NV, Tên NV, CMND, SĐT, Địa chỉ, MaGH, MaQL
        private string _MaNV, _TenNV, _CMND, _SDT, _DC, _MaGH, _MaQL;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DC { get => _DC; set => _DC = value; }
        public string MaGH { get => _MaGH; set => _MaGH = value; }
        public string MaQL { get => _MaQL; set => _MaQL = value; }

        public ArrayList getAllProperties()
        {
            return new ArrayList() { MaNV, TenNV, CMND, SDT, DC, MaGH , MaQL};
        }

        public ArrayList getAllPropertie()
        {
            return new ArrayList() { MaNV, TenNV, CMND, SDT, DC, MaGH};
        }

        public ET_NhanVien()
        {

        }

        public ET_NhanVien(string MaNV, string TenNV, string CMND, string SDT, string DC, string MaGH, string MaQL)
        {
            this._MaNV = MaNV;
            this._TenNV = TenNV;
            this._CMND = CMND;
            this._SDT = SDT;
            this._DC = DC;
            this._MaGH = MaGH;
            this._MaQL = MaQL;
         }

        public ET_NhanVien(string MaNV, string TenNV, string CMND, string SDT, string DC)
        {
            this._MaNV = MaNV;
            this._TenNV = TenNV;
            this._CMND = CMND;
            this._SDT = SDT;
            this._DC = DC;
            this._MaGH = MaGH;
        }
    }
}
