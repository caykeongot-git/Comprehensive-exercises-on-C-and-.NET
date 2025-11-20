using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management
{
    internal class Product
    {
        private string _maSP;
        private string _tenSP;
        private double _giaNhap;
        private int _soLuongTon = 0;
        private static int _tongSoLuongSanPham = 0;

        public string MaSP { get { return _maSP; } }
        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }

        public double GiaBan { get; private set; }

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set
            {
                if (value >= 0) _soLuongTon = value;
                else _soLuongTon = 0;
            }
        }

        public static int TongSoLuongSanPham { get { return _tongSoLuongSanPham; } }

        public Product (string maSP, string tenSP, double giaNhap)
        {
            this._maSP = maSP;
            this._tenSP = tenSP;
            this._giaNhap = giaNhap;
            ++_tongSoLuongSanPham;
        }

        public void NhapKho (int soLuong) { _soLuongTon += soLuong; }
        public bool XuatKho (int soLuong) { 
            _soLuongTon -= soLuong;
            if (_soLuongTon >= 0) return true;
            _soLuongTon += soLuong;
            return false;
        }
        private double TinhGiaBan () { return _giaNhap * 1.5; }

        public void display ()
        {
            this.GiaBan = TinhGiaBan();
            Console.WriteLine($"{_maSP} - {_tenSP} - {this.GiaBan} - {_soLuongTon}");
        }


    }
}
