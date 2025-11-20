using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mean_of_transportation_
{
    internal class XEMAY : PHUONGTIEN
    {
        private int _phanKhoi;

        public int PhanKhoi { get; set; }

        public XEMAY (string hangSanXuat, int namSanXuat, double giaBan, int phanKhoi) : base(hangSanXuat, namSanXuat, giaBan)
        {
            PhanKhoi = phanKhoi;
        }

        public override void CalcAndDisplay()
        {
            base.CalcAndDisplay();
            double Thue = base.GiaBan * 0.05;
            Console.WriteLine($"-> Tinh thue cho xe may: {Thue}");
        }
    }
}
