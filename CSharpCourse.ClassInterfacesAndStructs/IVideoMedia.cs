using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ClassInterfacesAndStructs
{
    public interface IVideoMedia
    {
        string DirectorName { get; set; }
        VideoGenre Genre { get; set; }
    }
}
