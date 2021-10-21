using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.Write("Введите радиус r=");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координату точки х=");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координату точки y=");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Длина окружности равна {0:f2}", MethodMath.LongCircle(r));
                    Console.WriteLine("Площадь круга равна {0:f2}", MethodMath.SqCircle(r));
                    MethodMath.AffDot(x, y, r);
                    Console.ReadKey();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    Console.ReadKey();
                    continue;
                }
                
            }            
        }
    }
    public static class MethodMath
    {

        static public double LongCircle(double r)
        {
            double L = 2 * Math.PI * r;
            return L;
        }
        static public double SqCircle(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            return S;
        }
        static public void AffDot(double x, double y, double r)
        {
            double H = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (H > r)
            {
                Console.WriteLine("Точка с координатами ({0}:{1}) не принадлежит кругу",x,y);
                return;
            }
            else
            {
                Console.WriteLine("Точка с координатами ({0}:{1}) принадлежит кругу", x, y);
                return;
            }
        }
    }
}
