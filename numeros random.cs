using System;

namespace Numero_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int num;
            char res;
            num = Convert.ToInt32(aleatorio.Next(50, 100));

            Console.WriteLine("El numero generado es " + num);
            Console.WriteLine(" ");


            {
                do
                {


                    Console.WriteLine("Desea generar otro numero?");
                    Console.WriteLine(" ");
                    Console.WriteLine("SI: Marque a.    NO: marque S.");


                    res = Convert.ToChar(Console.Read());
                    Random al = new Random();
                    num = Convert.ToInt32(al.Next(50, 100));
                    if (res == 'a')
                    {

                        Console.WriteLine("El numero generado es: " + num);
                        Console.ReadLine();
                    }
                    else
                    {

                    }
                } while (res != 's');
                Console.WriteLine("El programa a terminado");


                Console.ReadKey();
            }
        }
    }
