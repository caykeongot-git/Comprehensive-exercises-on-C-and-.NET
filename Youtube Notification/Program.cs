using System;

namespace Youtube_Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            KenhYoutube accYTB = new KenhYoutube("F8 Official");
            NguoiDung Nam = new NguoiDung("Nam");
            NguoiDung Nu = new NguoiDung("Nu");
            NguoiDung AntiFan = new NguoiDung("AntiFan");

            accYTB.SuKienRaVideo += Nam.XemVideo;
            accYTB.SuKienRaVideo += Nu.XemVideo;

            accYTB.DangVideo("Hoc C# co ban");

            accYTB.SuKienRaVideo -= Nu.XemVideo;
            accYTB.SuKienRaVideo += AntiFan.XemVideo;

            accYTB.DangVideo("Học Delegate nâng cao");


        }
    }
} 