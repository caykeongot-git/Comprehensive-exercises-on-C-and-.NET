using System;

namespace Geometrics
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhHoc ht = new HinhTron("Tron", 4);
            Console.WriteLine($"Dien tich hinh tron: {ht.CalcArea()}");
            if (ht is HinhTron tron) {
                tron.Draw();
            }
            HinhHoc hcn = new HinhChuNhat("Hinh Chu Nhat", 6, 3);
            Console.WriteLine($"Dien tich hinh chu nhat: {hcn.CalcArea()}");
            if (hcn is HinhChuNhat chunhat) { chunhat.Draw(); }
        }
    }
}