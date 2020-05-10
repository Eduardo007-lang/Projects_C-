using System;
using System.Globalization;

namespace Exercico5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {

                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {

                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {

                total = quantidade * 2.00;
            }
            else
            {
                total = quantidade * 1.5;

            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
