using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.ExtensionMethods2
{
    public static class ExtensionMethodsString
    {
        public static string Concat2String(this string myFirstString , string secondString)
        {
            return myFirstString + " " + secondString;
        }                         
    }
}
