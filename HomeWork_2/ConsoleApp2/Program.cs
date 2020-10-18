using System;

namespace ConsoleApp2
{
    class Program
    {
        static double Segment1 (double x)
        {
            double y = -x - 2;
            return y;
        }
        static double Segment2 (double x, double r)
        {
            double a = -2;
            double y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow((x - a), 2));
            return y;
        }
        static double Segment3 ()
        {
            return 1;
        }
        static double Segment4 (double x)
        {
            double y = -2 * x + 3;
            return y;
        }
        static double Segment5 ()
        {
            return -1;
        }

        static void Main (string[] args)
        {
            double x, r;

            //Ввод аргумента
            while (true)
            {
                Console.WriteLine("Введите значение аргумента:");

                if (double.TryParse(Console.ReadLine(), out x) && (x >= -3) && (x <= 5))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректно введеное значение аргумента! (Для повтороного ввода, нажмите любую клавишу)");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            //Ввод радиуса
            while (true)
            {
                Console.WriteLine("Введите значение радиуса:");

                if (double.TryParse(Console.ReadLine(), out r) && (r > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректно введенный радиус! (Для повтороного ввода, нажмите любую клавишу)");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            //Вывод значение при определенном аргументе:
            if (x <= -2)
            {
                Console.WriteLine($"y({x}) = {Segment1(x)}");
            }
            else if (x > -2 && x <= -1)
            {
                //Проверка на вхождение в область определения:
                if (Segment2(x,r) is Double.NaN)
                {
                    Console.WriteLine("Функция неопределена в данной точке!");
                }
                else Console.WriteLine($"y({x}) = {Segment2(x, r)}");
            }
            else if (x > -1 && x <= 1)
            {
                Console.WriteLine($"y({x}) = {Segment3()}");
            }
            else if (x > 1 && x <= 2)
            {
                Console.WriteLine($"y({x}) = {Segment4(x)}");
            }
            else if (x > 2)
            {
                Console.WriteLine($"y({x}) = {Segment5()}");
            }

            //Вывод значений:
            Console.WriteLine();
            for (double X = -3; X <= 5; X += 0.2)
            {
                if (X < -2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", X, Segment1(X));
                }
                else if (X < -1)
                {
                    if (Segment2(X, r) is Double.NaN)
                    {
                        Console.WriteLine("-");
                    }
                    else Console.WriteLine("y({0:0.00}) = {1:0.00}", X, Segment2(X, r));
                }
                else if (X < 1)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", X, Segment3());
                }
                else if (X < 2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", X, Segment4(X));
                }
                else if (X < 5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", X, Segment5());
                }
            }

            Console.ReadKey();
        }
    }
}
