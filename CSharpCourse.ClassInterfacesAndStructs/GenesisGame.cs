using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ClassInterfacesAndStructs
{
    public class GenesisGame : Media , IVideoGame
    {
        public GenesisGame()
            : base()
        { }

        public int Stages { get; set; }
    }
}
