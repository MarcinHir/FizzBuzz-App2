using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra FizzBuzz wersja 2");
            Console.WriteLine("Podaj liczbę całkowitą:");
            FizzBuzz game = new FizzBuzz();

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                    Console.WriteLine("Miałeś podać liczbę całkowitą!!!");
                else
                {
                    Console.WriteLine(game.GetNumber(number));
                    
                }


            }

        }
    }
}
