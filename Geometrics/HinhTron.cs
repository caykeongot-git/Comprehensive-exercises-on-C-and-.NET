using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrics
{
    internal class HinhTron : HinhHoc, IDrawable
    {
        private double _banKinh;

        public double BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value; }
        }

        public HinhTron(string mau, double banKinh) : base(mau)
        {
            BanKinh = banKinh;
        }

        public override double CalcArea()
        {

            return BanKinh * BanKinh * 3.14;
        }

        public void Draw()
        {
            Console.WriteLine("Ve hinh tron...");
        }

    }
}
