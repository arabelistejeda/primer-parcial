using System;

namespace Cantidad_positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, d = 0;
            Console.WriteLine("Digite un numero");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 <= 0)
            {
                Console.WriteLine("tiene 0 digitos ");
            }
            else
            {
                do
                {
                    n1 = n1 / 10;
                    d = d + 1;

                } while (n1 > 0);
                Console.WriteLine("Este numero tiene " + d + " digitos");
            }
            Console.ReadKey();
        }
    }
}
