using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrics
{
    internal abstract class HinhHoc
    {
        protected string _mau;

        public HinhHoc(string mau) { this._mau = mau; }

        public abstract double CalcArea();

        public void displayEx()
        {
            Console.WriteLine("Hien thi mau.....");
        }
    }
}
