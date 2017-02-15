using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ehtorakenne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1. Ask for number and check if number is positive or negative
            Console.Write("Type a number ");
            string userInput = Console.ReadLine();
            int number;
            //Check if input is a number, psoitive or negative.
            if (int.TryParse(userInput, out number))
            {
                if (number == 0)
                {
                    Console.WriteLine("Your number is 0");
                }
                if (number > 0)
                {
                    Console.WriteLine("Number " + userInput + " is positive.");
                }
                if (number < 0)
                {
                    Console.WriteLine("Number " + userInput + " is negative.");
                }
            }
            else
            {
                Console.WriteLine("You didn't type a number");
            }

            //Task 2. Ask for a number and check if its positive or negative
            Console.Write("\nType new number: ");
            string userInput2 = Console.ReadLine();
            if (int.TryParse(userInput2, out number))
            {
                if (number % 2 == 0 || number == 0)
                {
                    Console.WriteLine("Number " + number + " is even.");
                }
                else
                {
                    Console.WriteLine("Number " + number + " is odd.");
                }
                
            }
            else
            {
                Console.WriteLine("You didn't write a number");
            }
            //Task 3. Combined tasks 1 and 2
            Console.Write("\nType new number: ");
            string userInput3 = Console.ReadLine();
            if (int.TryParse(userInput3, out number))
            {
                if (number == 0)
                {
                    Console.WriteLine("Number is 0");
                }
                if (number > 0)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Number " + number + " is positíve and even.");
                    }
                    else
                    {
                        Console.WriteLine("Number " + number + " is positive and odd.");
                    }
                }
                if (number < 0)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Number " + number + " is negative and even.");
                    }
                    else
                    {
                        Console.WriteLine("Number " + number + " is negative and odd.");
                    }
                }

            }
            else
            {
                Console.WriteLine("You didn't type a number");
            }

            //Task 4. Ask for 3 numbers and arrange them in ascending order
            Console.Write("\nGive 3 numbers separated with spaces: ");
            string userInput4 = Console.ReadLine();
            string[] numbers = userInput4.Split(' ');
            Array.Sort(numbers);
            foreach (string s in numbers)
            {
                if (int.TryParse(s, out number))
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("You didn't type a number");
                }
            }
                Console.ReadKey();
        }
    }
}
