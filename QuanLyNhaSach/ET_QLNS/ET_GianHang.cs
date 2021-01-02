using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_GianHang
    {
        //Mã gian hàng, tên gian hàng, số lượng sách
        private string _MaGH, _TenGH;
        private int _SoLuongSach;
        //-------------------------------------------------------------------------
        //GET, SET
        public string MaGH { get => _MaGH; set => _MaGH = value; }
        public string TenGH { get => _TenGH; set => _TenGH = value; }
        public int SoLuongSach { get => _SoLuongSach; set => _SoLuongSach = value; }
        //-------------------------------------------------------------------------
        //METHOD
        public ArrayList getAllProperties()
        {
            ArrayList list = new ArrayList() { MaGH, TenGH, SoLuongSach};
            return list;
        }
        //--------------------------------------------------------------------------
        //CONSTRUCTOR
        public ET_GianHang()
        {

        }
        public ET_GianHang(string maGH, string tenGH, int soluongSach)
        {
            _MaGH = maGH;
            _TenGH = tenGH;
            _SoLuongSach = soluongSach;
        }
    }
}
