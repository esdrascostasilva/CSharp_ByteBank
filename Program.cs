using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank

{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();

        }//main

        private static void TestDivision (int divider)
        {
            //try execution this, if error, we go to Catch
            try
            {
                int result = divide(10, divider);
                Console.WriteLine("Result of the division of 10 per " + divider + "is"
               + result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("It's not possible to divide by zero!");
            }
          

          

        }

        private static int Divide(int number, int divider)
        {
            return number / divider;
        }

        private static void Method()
        {

        }

    }
}
