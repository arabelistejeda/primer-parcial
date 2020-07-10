using System;

namespace ceros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int a = 1;
            int i = 0;
            while (num >= a)
            {
                Console.WriteLine(num);
                if (100 % 10 == 0)
                {
                    i++;
                }
                num -= 10;
            }
            i++;
            Console.WriteLine($"hay {i} ceros.");
        }
    }
}
