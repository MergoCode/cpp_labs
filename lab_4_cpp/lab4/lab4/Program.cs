using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    class Program
    {
        public static double f(double x)
        {
            return x * x - 4;
        }

        public static double Newton(Func<double, double> func, double x0, double tol = 1e-10, int maxIter = 1000, double h = 1e-8)
        {
            double x = x0;
            for (int i = 0; i < maxIter; i++)
            {
                double fx = func(x);
                if (Math.Abs(fx) < tol) return x;
                double dfx = (func(x + h) - func(x - h)) / (2 * h);
                x = x - fx / dfx;
            }
            throw new Exception("Не сходиться");
        }

        public static (double, double)? Tabulate(double start, double end, double step)
        {
            Console.WriteLine("\nТабуляція f(x):");
            double a = start;
            double b = a + step;
            while (b <= end)
            {
                double fa = f(a);
                double fb = f(b);
                Console.WriteLine($"x={a:F4}, f(x)={fa:F4} | x={b:F4}, f(x)={fb:F4}");
                if (fa * fb <= 0) return (a, b); 
                a = b;
                b = a + step;
            }
            return null; 
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Виберіть метод: 1 - Ділення навпіл, 2 - Ньютона");
                int method = Convert.ToInt32(Console.ReadLine());

                if (method == 1)
                {
                    Console.WriteLine("Введіть початок, кінець інтервалу та точність eps:");
                    double start = Convert.ToDouble(Console.ReadLine());
                    double end = Convert.ToDouble(Console.ReadLine());
                    double Eps = Convert.ToDouble(Console.ReadLine());

                    var interval = Tabulate(start, end, 0.1);
                    if (interval == null)
                    {
                        Console.WriteLine("Кореня на інтервалі не знайдено");
                        return;
                    }

                    double a = interval.Value.Item1;
                    double b = interval.Value.Item2;
                    int Lich = 0;
                    double c = 0;
                    while (Math.Abs(b - a) > Eps)
                    {
                        c = 0.5 * (a + b);
                        Lich++;
                        if (Math.Abs(f(c)) < Eps)
                        {
                            Console.WriteLine("x = " + c + " Lich = " + Lich);
                            return;
                        }
                        else if (f(a) * f(c) < 0) b = c;
                        else a = c;
                    }
                    Console.WriteLine("x = " + (a + b) / 2 + " Lich = " + Lich);
                }
                else if (method == 2)
                {
                    Console.WriteLine("Введіть початкове x0 і точність eps:");
                    double x0 = Convert.ToDouble(Console.ReadLine());
                    double eps = Convert.ToDouble(Console.ReadLine());
                    try
                    {
                        double root = Newton(f, x0, eps);
                        Console.WriteLine("x = " + root);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Невірний вибір методу");
                }
            }
        }
    }
}
