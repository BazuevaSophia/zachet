using System;

namespace задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            Console.WriteLine("Enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("числа между a и b");
            for (i = b - 1; i > a; i--)
                Console.WriteLine(i);
            Console.WriteLine("Количество чисел \n");
            Console.WriteLine(b - a - 1);
            Console.ReadKey();
        }
    }
}
