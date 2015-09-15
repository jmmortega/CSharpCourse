using CSharpCourse.ClassInterfacesAndStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.GenericsI
{
    //Generic allows reuse code that works in a same way.
    public class Library<T> 
    {
        public int CountOfTitles { get; set; }
        public T LastTitleAdded { get; set; }

        public void Add(T title)
        {
            LastTitleAdded = title;
            CountOfTitles++;            
        }        
    }            
}
