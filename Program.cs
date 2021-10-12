using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFizzBuzz
{
    class Program
    {
         public static void Main()
        {
            while (true)
            { 

                Console.WriteLine("Podaj liczbę: ");
                var FizzBuzz = new FizzBuzz();
                var number = CheckNumber();
                FizzBuzz.WhyNumber(number);
                Console.WriteLine(FizzBuzz.WhyNumber(number));
            }
          
        }


        private static int CheckNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int Number))
                {
                    Console.WriteLine("Wpisałeś błędną liczbę!");
                 
                    continue;
                }
                else
                {
                    return Number;
                }
            }
           
        }
    }

}
