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

            //Console.WriteLine(jD.GetType().FullName);

            GetMethods(jD);
            //GetProperties(jD);

            
            
            //Console.WriteLine(jD.GetType().BaseType);
                                                                            
            Console.ReadKey();
        }

        private static void GetProperties(object jD)
        {
            var properties = jD.GetType().GetRuntimeProperties();

            Console.WriteLine(jD.GetType().GetProperty("Price").GetMethod.Invoke(jD, null).ToString());

            foreach(var property in properties)
            {
                Console.WriteLine(property.Name);

                if(property.Name == "Price")
                {
                    property.SetMethod.Invoke(jD, new object[] { 5.3} );
                }
            }

            Console.WriteLine(jD.GetType().GetProperty("Price").GetMethod.Invoke(jD, null).ToString());
        }

        private static void GetMethods(object jD)
        {
            var methods = jD.GetType().GetRuntimeMethods();

            jD.GetType().BaseType.GetRuntimeMethods().First(x => x.Name == "GetADrink" && x.GetParameters().Count() == 0).Invoke(jD, null);
                        
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
