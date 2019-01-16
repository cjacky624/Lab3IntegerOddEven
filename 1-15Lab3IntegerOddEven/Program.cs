using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_15Lab3IntegerOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            
            bool run = true;
            while (run == true)
            {
                Console.WriteLine();
                Console.WriteLine(name + " please enter an integer between 1 and 100.");
                string userInput = Console.ReadLine();
                int number = int.Parse(userInput);


                if (number % 2 == 1 && number <= 100 && number > 0)
                {
                    Console.WriteLine(number + " Odd");
                }

                while (true)
                {
                    if (number > 100 || number < 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine(name + " that is not a valid input, please try again.");
                        break;
                    }
                    if (number % 2 == 0 && number != 0 && number >= 2 && number <= 24)
                    {
                        Console.WriteLine("Even and less than 25.");
                        break;
                    }
                    if (number % 2 == 0 && number != 0 && number >= 26 && number <= 60)
                    {
                        Console.WriteLine("Even.");
                        break;
                    }
                    if (number % 2 == 0 && number != 0 && number > 60 && number <= 100)
                    {
                        Console.WriteLine(number + " Even");
                        break;
                    }

                }

                
            }
        }
    }
}
