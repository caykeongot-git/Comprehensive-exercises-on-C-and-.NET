using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_Notification
{
    internal class NguoiDung
    {
        public string TenNguoiDung { get; set; }

        public NguoiDung(string tenNguoiDung) {
        
            TenNguoiDung = tenNguoiDung;

        }
        public void XemVideo (string tenVideo)
        {
            Console.WriteLine($"{TenNguoiDung} dang xem video: {tenVideo}");
        }
    }
}
