using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Fire_Alarm_System
{
    public delegate void SuKienChayHandler (string diaDiem);
    internal class CamBienNhiet
    {
        public string DiaDiem { get; set; }

        public event SuKienChayHandler OnQuaNhiet;

        public CamBienNhiet(string diaDiem)
        {
            DiaDiem = diaDiem;
        }


        public void TheoDoiNhietDo(int doC)
        {
            if (doC >= 50)
            {
                Console.WriteLine($"[Cảm biến {DiaDiem}] đang do... {doC} độ C.");

                //if (OnQuaNhiet != null)
                //{
                //    OnQuaNhiet(DiaDiem);
                //}

                OnQuaNhiet?.Invoke(DiaDiem);
            }
        }

    }
}
