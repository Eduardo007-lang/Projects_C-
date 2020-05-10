using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else {
                Console.WriteLine("Impar!");
            }

        }
    }
}
