using System;

namespace cat
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, n, t = 1,b;
            float S=0;
            Console.WriteLine("Insert x : ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert n : ");
            n = double.Parse(Console.ReadLine());
            for (double i = 1; i <= n; i++)
            {
                t *= i;
                b = Math.Pow(x, i);
                S += (float)(b / t);
            }
                Console.WriteLine("Sn = : {0}", S);
            Console.ReadLine();
        }
    }
}
