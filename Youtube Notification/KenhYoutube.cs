using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_Notification
{

    public delegate void VideoMoiDelegate(string tenVideo);
    internal class KenhYoutube
    {
        public string TenKenh {  get; set; }

        public event VideoMoiDelegate SuKienRaVideo;

        public KenhYoutube (string tenKenh)
        {
            TenKenh = tenKenh;
        }

        public void DangVideo (string tenVideo)
        {
            Console.WriteLine($"[Kenh {TenKenh} vua dang video: {tenVideo}");

            if (SuKienRaVideo != null) SuKienRaVideo(TenKenh);

        }

    }
}
