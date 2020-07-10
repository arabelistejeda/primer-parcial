using System;

namespace numero_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int  a = 0;
            Console.WriteLine("ingrese un numero entero positivo: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; 1 < (numero+1); a++)
            {
                if (numero%1 == 0)
                {
                    a++;
                }
            }
            if (a !=2)
            {
                Console.WriteLine("el numero {0} no es primo ", numero);
            }
            else
            {
                Console.WriteLine("el numero {0} no es primo ", numero);
            }
            Console.ReadKey();
            
        }
    }
}
