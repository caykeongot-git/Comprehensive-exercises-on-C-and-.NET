using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_HOME
{
    internal abstract class ThietBi : IWifi
    {
        public string TenThietBi {  get; set; }
        public bool DangBat { get; protected set; } 

        public ThietBi(string tenThietBi)
        {
            TenThietBi = tenThietBi;
            DangBat = false;
        }

        public abstract void KhoiDong();

        public void TatNguon ()
        {
            DangBat = false;
            Console.WriteLine("Thiết bị đã tắt nguồn");
        }

        public void KetNoiWifi () { 
            Console.WriteLine($"{TenThietBi} đang kết nối Server...");
        }
    }
}
