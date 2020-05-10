using System;

namespace Funções_Sintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite tres numeros: ");
            //contagem do primeiro numero 
            int n1 = int.Parse(Console.ReadLine());
            //conta
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;

            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m; 

        }
    }
}
