using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Cone
    {
        public float h { get; set; } = 0f;
        public float lbr { get; set; } = 0f;

        public virtual void ReadParametrs()
        {
            Console.WriteLine("Введите следующие параметры:");

            Console.Write("Высота: ");
            h = float.Parse(Console.ReadLine());

            Console.Write("Радиус основания: ");
            lbr = float.Parse(Console.ReadLine());
        }

        public virtual void PrintParametrs()
        {
            Console.WriteLine();
            Console.WriteLine($"Высота = { h }");
            Console.WriteLine($"Радиус основания = { lbr }");
        }

        public virtual double CalcVolume()
        {
            return 1d / 3d * Math.PI * lbr * lbr * h;
        }

        public double CalcLBS()
        {
            return Math.PI * lbr * lbr;
        }
    }
}
