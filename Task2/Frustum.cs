using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Frustum : Cone
    {
        public float ubr { get; set; } = 0f;

        public override void ReadParametrs()
        {
            Console.WriteLine("Введите следующие параметры:");

            Console.Write("Высота: ");
            h = float.Parse(Console.ReadLine());

            Console.Write("Радиус нижнего основания: ");
            lbr = float.Parse(Console.ReadLine());

            Console.Write("Радиус верхнего основания: ");
            ubr = float.Parse(Console.ReadLine());
        }

        public override void PrintParametrs()
        {
            Console.WriteLine();
            Console.WriteLine($"Высота = { h }");
            Console.WriteLine($"Радиус нижнего основания = { lbr }");
            Console.WriteLine($"Радиус верхнего основания = { ubr }");
        }

        public override double CalcVolume()
        {
            double Sqr(double a)
            {
                return a * a;
            }

            return 1d / 3d * Math.PI * h * ( Sqr(lbr) + lbr * ubr + Sqr(ubr) );
        }
    }
}
