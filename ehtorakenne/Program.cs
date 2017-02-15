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
            Console.Write("Type number ");
            string userInput = Console.ReadLine();
            int numero;
            //Check if input is a number, psoitive or negative.
            if (int.TryParse(userInput, out numero))
            {
                if (numero == 0)
                {
                    Console.WriteLine("Your number is 0");
                }
                if (numero > 0)
                {
                    Console.WriteLine("Number " + userInput + " is positive.");
                }
                if (numero < 0)
                {
                    Console.WriteLine("Number " + userInput + " is negative.");
                }
            }
            else
            {
                Console.WriteLine("You didn't write a number");
            }

            //Task 2. Ask for a number and check if its positive or negative
            Console.Write("\nType new number: ");
            string userInput2 = Console.ReadLine();
            if (int.TryParse(userInput2, out numero))
            {
                if (numero % 2 == 0 || numero == 0)
                {
                    Console.WriteLine("Number " + numero + " is even.");
                }
                else
                {
                    Console.WriteLine("Number " + numero + " is odd.");
                }
                
            }
            else
            {
                Console.WriteLine("You didn't write a number");
            }
            //Task 3. Combined tasks 1 and 2
            Console.Write("\nWrite new number: ");
            string userInput3 = Console.ReadLine();
            if (int.TryParse(userInput3, out numero))
            {
                if (numero == 0)
                {
                    Console.WriteLine("Number is 0");
                }
                if (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("Number " + numero + " is positíve and even.");
                    }
                    else
                    {
                        Console.WriteLine("Number " + numero + " is positive and odd.");
                    }
                }
                if (numero < 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("Number " + numero + " is negative and even.");
                    }
                    else
                    {
                        Console.WriteLine("Number " + numero + " is negative and odd.");
                    }
                }

            }
            else
            {
                Console.WriteLine("You didn't write a number");
            }

            //Task 4. Ask for 3 numbers and arrange them in ascending order
            Console.Write("\nGive 3 numbers separated with spaces: ");
            string userInput4 = Console.ReadLine();
            string[] numerot = userInput4.Split(' ');
            Array.Sort(numerot);
            foreach (string s in numerot)
            {
                if (int.TryParse(s, out numero))
                {
                    Console.WriteLine(numero);
                }
                else
                {
                    Console.WriteLine("You didn't give a number");
                }
            }
                Console.ReadKey();
        }
    }
}
