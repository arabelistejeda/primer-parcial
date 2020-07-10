using System;

namespace Recorrer_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            num = 0;
            for (num = 1; num <= 50; num++)
            {
                Console.WriteLine(" " + num);
            }

            Console.ReadKey();
        }
    }
}
