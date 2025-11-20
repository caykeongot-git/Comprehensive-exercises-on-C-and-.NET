using System;
using System.Text;

namespace Smart_Fire_Alarm_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            CamBienNhiet cbn = new CamBienNhiet("Quận 1");
            ChuongBaoDong cbd = new ChuongBaoDong();
            VoiPhunNuoc vpn = new VoiPhunNuoc();

            cbn.OnQuaNhiet += cbd.HuCoi;
            cbn.OnQuaNhiet += vpn.PhunNuoc;

            cbn.TheoDoiNhietDo(50);
        }
    }
}