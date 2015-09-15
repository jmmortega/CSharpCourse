using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseLazyPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);

            var numbersAbove5 = numbers.Where(x => x >= 5).ToList();            
            numbers.Remove(7);
            
            foreach(var number in numbersAbove5)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
