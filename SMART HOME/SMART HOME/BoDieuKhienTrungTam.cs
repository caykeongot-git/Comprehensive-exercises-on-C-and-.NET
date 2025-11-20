using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_HOME
{
    public delegate void SuCoHandler(string thongBao);
    internal class BoDieuKhienTrungTam
    {
        public event SuCoHandler OnSuCoKhanCap;

        public void PhatBaoDong (string lyDo)
        {
            Console.WriteLine($"ALARM: {lyDo}");
            if (OnSuCoKhanCap != null)
            {
                OnSuCoKhanCap(lyDo);
            }
        }
    }
}
