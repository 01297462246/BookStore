using System;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_DangNhap
    {
        //--------------------------------------------------------------------
        //Thuoc tinh
        private string _MaNV;
        private string _PassWord;
        private bool _PhanQuyen;
        //--------------------------------------------------------------------
        //Get, Set
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string PassWord { get => _PassWord; set => _PassWord = value; }
        public bool PhanQuyen { get => _PhanQuyen; set => _PhanQuyen = value; }

        //--------------------------------------------------------------------
        //Constructor
        public ET_DangNhap()
        {

        }

        public ET_DangNhap(string maNV, string password, bool phanquyen)
        {
            this._MaNV = maNV;
            this._PassWord = password;
            this.PhanQuyen = phanquyen;
        }
    }
}
