using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new Form1();
            
            Console.WindowWidth = 1;
            Console.WindowHeight = 1;
            
            
            form.ShowDialog();                                                
        }

        static void form_OnEventHandler(object sender, string e)
        {
            
        }
    }
}
