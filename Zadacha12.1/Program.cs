using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите величину радиуса: ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату по X точки для проверке ее принадлежности кругу с заданным радиусом: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату по Y точки для проверке ее принадлежности кругу с заданным радиусом: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату по X центра круга с заданным радиусом: ");
            int x0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату по Y центра круга с заданным радиусом: ");
            int y0 = Convert.ToInt32(Console.ReadLine());
            Circle.R = R;
            double L = Circle.GetLength();
            double S = Circle.GetArea();
            bool belong = Circle.OwnOrNot(x, y, x0, y0);
            Console.WriteLine();
            Console.WriteLine("Длина окружности с заданным радиусом равна: {0:f3}.",L);
            Console.WriteLine("Площадь круга с заданным радиусом равна: {0:f3}.", S);
            if (belong == true)
            {
                Console.WriteLine("Точка принадлежит окружности.");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит окружности.");
            }
            Console.ReadKey();
        }
        static class Circle
        {
            static double r;
            public static double R
            {
                set
                {
                    if (value<0)
                    {
                        Console.WriteLine("Ошибка! Величина радиуса не может быть отрицательной. Полученное значение обнулено.");
                        r = 0;
                    }
                    else
                    {
                        r = value;
                    }
                }
                get
                {
                    return r;
                }
            }
            public static double GetLength()
            {
                double L = 2 * Math.PI * r;
                return L;
            }
            public static double GetArea()
            {
                double S = Math.PI * Math.Pow(r, 2);
                return S;
            }
            public static bool OwnOrNot(int x, int y, int x0, int y0)
            {
                double length = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));
                if (length>r)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
