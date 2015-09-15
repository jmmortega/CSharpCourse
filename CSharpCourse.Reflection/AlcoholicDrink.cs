using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Reflection
{
    public class AlcoholicDrink : Drink
    {
        private double _vol;

        [Printable(5)]
        public double Vol { get; set; }

        [Printable]
        public bool IsFermented
        {
            get
            {
                return true;
            }

        }

        private void CheckFermented()
        {

        }        
    }
}
