using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mean_of_transportation_
{
    internal class OTO : PHUONGTIEN
    {
        private int _soChoNgoi; 
        private string _dongCo;

        public int SoChoNgoi { get; set; }

        public string DongCo { get; set; }

        public OTO (string hangSanXuat, int namSanXuat, double giaBan, int soChoNgoi, string dongCo) : base (hangSanXuat, namSanXuat, giaBan)
        {
            SoChoNgoi = soChoNgoi;
            DongCo = dongCo;
        }

        public override void CalcAndDisplay()
        {
            base.CalcAndDisplay();
            double Thue = base.GiaBan * 0.4 + base.GiaBan * 0.1;
            Console.WriteLine($"-> Tinh thue cho o to: {Thue}");
        }



    }
}
