using CSharpCourse.ClassInterfacesAndStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.GenericsII
{
    //We override with more Generic values to override the functionality of class
    public class Library<T,W>
        //This a constraint, there limit the generic Type that allow.
        where T : IVideoMedia    
    {
        public TimeSpan TotalDuration{ get; set; }

        public void Add(T media, W secondMedia)
        {
            //Do anything...    
        }

    }
    
    public class Main
    {
        Library<VHSVideo, GenesisGame> libraries = new Library<VHSVideo, GenesisGame>();


        
    }

    
    
}
