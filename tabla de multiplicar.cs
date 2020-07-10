using System;

namespace Tabla_de_multiplar
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla;
            int i;

            i = 1;
            tabla = 7;

            while (i <= 12)
            {
                Console.WriteLine("7 x " + i + " = " + tabla * i);
                i++;
            }
            Console.ReadKey();
        }
    }
}