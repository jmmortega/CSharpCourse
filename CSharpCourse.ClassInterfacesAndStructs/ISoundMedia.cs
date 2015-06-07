using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ClassInterfacesAndStructs
{
    //It's a interface, may allow include properties that implements of different way. 
    public interface ISoundMedia
    {
        int Tracks { get; set; }
        string ArtistName { get; set; }
    }
}
