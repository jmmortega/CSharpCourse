using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Reflection
{
    public class Printable : Attribute
    {
        public Printable()
        {

        }

        public Printable(int a)
        {
            A = a;
        }

        public int A { get; set; }
    }            
}
