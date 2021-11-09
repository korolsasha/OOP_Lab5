using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Выберите тип конуса:");
            Console.WriteLine("1. Конус");
            Console.WriteLine("2. Усечённый конус");
            Console.WriteLine();
            Console.Write("Ваш выбор: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Cone cone = null;

            if (choice == 1)
            {
                cone = new Cone();
            }
            else if (choice == 2)
            {
                cone = new Frustum();
            }
            else { Console.WriteLine("Неверный выбор"); }

            cone.ReadParametrs();

            cone.PrintParametrs();

            Console.WriteLine();
            Console.WriteLine($"Объём фигуры = {cone.CalcVolume()}");
            Console.WriteLine($"Площадь основания = {cone.CalcLBS()}");

            Console.ReadLine();
        }
    }
}
