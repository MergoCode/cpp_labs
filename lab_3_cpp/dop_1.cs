using System;

namespace BisectionMethod
{
    class Program
    {        static double f(double x)
        {
            return x * x * x - x - 2;
        }

        static void Main(string[] args)
        {
            double a = 1, b = 2, c = 0, eps = 1e-6;

            if (f(a) * f(b) >= 0)
            {
                Console.WriteLine("f(a) and f(b) have same signs");
                return;
            }
            
            while ((b - a) >= eps)
            {
                c = (a + b) / 2;

                if (f(c) == 0.0)
                    break;
                else if (f(c) * f(a) < 0)
                    b = c;
                else
                    a = c;
            }
            
            Console.WriteLine("Root: " + c);
            Console.WriteLine("Press <ENTER>");
            Console.ReadLine();
        }
    }
}
