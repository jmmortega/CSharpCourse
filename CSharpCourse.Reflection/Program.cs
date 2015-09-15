using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace CSharpCourse.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            object jD = new AlcoholicDrink();
            Console.WriteLine(jD.GetType().BaseType);
                                                
            
                
            Console.ReadKey();
        }

        private static void GetProperties(object jD)
        {
            var properties = jD.GetType().GetRuntimeProperties();

            foreach(var property in properties)
            {
                Console.WriteLine(property.Name);
            }
        }

        private static void GetMethods(object jD)
        {
            var methods = jD.GetType().GetRuntimeMethods();

            foreach(var method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }

        private static void GetFullName(object jD)
        {
            Console.WriteLine(jD.GetType().FullName);
        }
        
    }

    
    
}
