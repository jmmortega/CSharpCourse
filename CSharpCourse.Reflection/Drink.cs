using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Reflection
{
    public class Drink
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual void DoDrink()
        {

        }

        private void GetADrink()
        {
            Console.WriteLine("Full glass");
        }

        public void GetADrink(int volume)
        {
            Console.WriteLine(volume);
        }
    }
}
