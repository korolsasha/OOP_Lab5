using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Что будет происходить с квадратом при нажатии стрелки влево/вправо?");
            Console.WriteLine("1. Перемещение");
            Console.WriteLine("2. Поворот");
            Console.WriteLine();
            Console.Write("Ваш выбор: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            SquareMove move = null;

            if (choice == 1)
            {
                move = new SquareMove();
            }
            else if (choice == 2)
            {
                move = new SquareRotate();
            }
            else { Console.WriteLine("Неверный выбор."); }

            move.ReadParametrs();

            Console.ReadLine();
        }
    }
}
