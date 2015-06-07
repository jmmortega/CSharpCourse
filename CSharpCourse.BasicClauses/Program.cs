using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.BasicClauses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a action");
            int option = -1;

            do
            {                
                Console.WriteLine("1 - If statement");
                Console.WriteLine("2 - For statement");
                Console.WriteLine("3 - For each statement");
                Console.WriteLine("0 Exit");

                ConsoleKeyInfo keyInfo = Console.ReadKey();                
                option = int.Parse(keyInfo.KeyChar.ToString());

                Console.Clear();

                switch (option)
                {
                    case 1:
                        IfStatement();
                        break;
                    case 2:
                        ForStatement();
                        break;
                    case 3:
                        ForEachStatement();
                        break;
                }

                


            } while (option != 0);            
        }

        private static void IfStatement()
        {
            //This is a If statement. If you see is the same like C or Java

            int value = 2;
            int value2 = 3;

            if(value == value2)
            {
                Console.WriteLine("Value is the same");
            }


            if(value.Equals(value2))
            {
                Console.WriteLine("Value is the same");
            }

            //'Equals' and '==' works in the same way

        }

        private static void ForStatement()
        {
            //Remember? This is a for statement

            for(int i = 0 ; i < 10; i++)
            {
                Console.WriteLine("Look mom, I do a For!");
            }
        }

        private static void ForEachStatement()
        {
            int[] arrayOfInt = new int[] { 2, 3, 4, 5, 6 };

            //ForEach statement allow iterate any Collection.

            foreach(int item in arrayOfInt)
            {
                Console.WriteLine(item);
            }
        }
    }
}
