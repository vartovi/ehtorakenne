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
            //Ask user for input
            Console.Write("Anna luku: ");
            string userInput = Console.ReadLine();
            int numero;
            //Check if input is a number
            if (int.TryParse(userInput, out numero))
            {
                if (numero == 0)
                {
                    Console.WriteLine("Antamasi luku on 0");
                }
                if (numero > 0)
                {
                    Console.WriteLine("Numero " + userInput + " on positiivinen.");
                }
                if (numero < 0)
                {
                    Console.WriteLine("Numero " + userInput + " on negatiivinen.");
                }
            }
            else
            {
                Console.WriteLine("Et antanut numeroa");
            }

            Console.Write("\nAnna uusi luku: ");
            string userInput2 = Console.ReadLine();
            if (int.TryParse(userInput2, out numero))
            {
                if (numero % 2 == 0 || numero == 0)
                {
                    Console.WriteLine("Antamasi luku " + numero + " on parillinen.");
                }
                else
                {
                    Console.WriteLine("Antamasi luku " + numero + " on pariton.");
                }
                
            }
            else
            {
                Console.WriteLine("Et antanut numeroa");
            }

            Console.Write("\nAnna uusi luku: ");
            string userInput3 = Console.ReadLine();
            if (int.TryParse(userInput3, out numero))
            {
                if (numero == 0)
                {
                    Console.WriteLine("Antamasi luku on 0");
                }
                if (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("Antamasi luku " + numero + " on positiivinen ja parillinen.");
                    }
                    else
                    {
                        Console.WriteLine("Antamasi luku " + numero + " on positiivinen ja pariton.");
                    }
                }
                if (numero < 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("Antamasi luku " + numero + " on negatiivinen ja parillinen.");
                    }
                    else
                    {
                        Console.WriteLine("Antamasi luku " + numero + " on negatiivinen ja  pariton.");
                    }
                }

            }
            else
            {
                Console.WriteLine("Et antanut numeroa");
            }

            Console.Write("\nAnna kolme numeroa: ");
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
                    Console.WriteLine("Et antanut numeroa");
                }
            }
                Console.ReadKey();
        }
    }
}
