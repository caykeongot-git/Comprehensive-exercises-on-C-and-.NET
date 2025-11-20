using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mean_of_transportation_
{
    internal class PHUONGTIEN
    {
        protected string _hangSanXuat;
        protected int _namSanXuat;
        protected double _giaBan;

        public string HangSanXuat { get; set; }
        public int NamSanXuat { get; set; }
        public double GiaBan { get; set; }

        public PHUONGTIEN (string hangSanXuat, int namSanXuat, double giaBan)
        {
            HangSanXuat = hangSanXuat;
            NamSanXuat = namSanXuat;
            GiaBan = giaBan;
        }

        public void display() { Console.WriteLine($"Thong tin: {HangSanXuat} - {NamSanXuat} - {GiaBan}"); }
        public virtual void CalcAndDisplay() { Console.WriteLine($"Dang tinh toan thue co ban..."); }


    }
}
