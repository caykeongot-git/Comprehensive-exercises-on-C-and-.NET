using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrics
{
    internal class HinhChuNhat : HinhHoc, IDrawable
    {
        public double ChieuDai {  get; set; }
        public double ChieuRong {  get; set; }
                
        public HinhChuNhat (string mau, double chieuDai, double chieuRong) : base (mau)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public override double CalcArea()
        {
            return ChieuDai * ChieuRong;
        }

        public void Draw() { Console.WriteLine("Ve hinh chu nhat..."); }


    }
}
