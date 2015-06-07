using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ClassInterfacesAndStructs
{
    public class NesGame : Media , IVideoGame
    {
        public int Stages { get; set; }
    }
}
