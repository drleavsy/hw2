using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = "";
            string divd = "";
            int numb = 0;
            int diiv = 0;
            Console.Write("Please enter your number: ");
            inp = Console.ReadLine();

            while (inp != "q")
            {
                if (int.TryParse(inp, out numb) && numb >= 0 && numb <= 100)
                {
                    if ((numb % 3 == 0) && (numb % 5 == 0))
                    {
                        Console.WriteLine("Fizz Buzz");
                    }
                    else if (numb % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (numb % 3 == 0)
                    {
                        Console.WriteLine("Fizz ");
                    }
                    else
                    {
                        //Console.WriteLine(numb);
                    }
                }
                else
                {
                    Console.WriteLine("The input is not a number, or not an integer less than 0 or more than 100");
                }
                Console.WriteLine("Press any number from 1 to 100 or 'q' in order to quit");
                inp = Console.ReadLine();
            }
        }
    }
}
