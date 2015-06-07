using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ClassInterfacesAndStructs
{
    public class BetaVideo : Media , IVideoMedia
    {
        public BetaVideo(TimeSpan duration)
            : base(duration, MediaQuality.LowMidQuality)
        { }

        public string DirectorName { get; set; }
        public VideoGenre Genre { get; set; }
    }
}
