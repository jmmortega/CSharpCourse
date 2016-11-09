using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ClassInterfacesAndStructs
{
    public class CasetteMedia : Media, ISoundMedia
    {
        public CasetteMedia()
            : base()
        { }

        public CasetteMedia(TimeSpan duration)
            : base(duration, MediaQuality.LowMidQuality)
        {

        }

        public int Tracks { get; set; }
        public string ArtistName { get; set; }
    }    
}
