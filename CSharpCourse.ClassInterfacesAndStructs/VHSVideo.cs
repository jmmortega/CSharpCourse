using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ClassInterfacesAndStructs
{
    public class VHSVideo : Media , IVideoMedia
    {        
        public VHSVideo(TimeSpan duration) : base(duration , MediaQuality.LowQuality)
        {

        }
        
        public string DirectorName { get; set; }
        public VideoGenre Genre { get; set; }
    }
}
