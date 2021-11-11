using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task1
{
    class SquareMove
    {
        protected PointF[] points;
        public void ReadParametrs()
        {
            Console.Write("x: ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("y: ");
            float y = float.Parse(Console.ReadLine());

            Console.Write("Длинна стороны: ");
            float side = float.Parse(Console.ReadLine());

            points = new PointF[]
            {
                new PointF( x, y ),
                new PointF( x + side, y ),
                new PointF( x, y - side ),
                new PointF( x + side, y - side )
            };
        }

        public void PrintParametrs()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write($"{points[i].X}, " + $"{points[i].Y};");
                Console.WriteLine(points[i]);
            }
        }

        public void MovementInstructions()
        {
            Console.WriteLine("Чтобы передвинуть квадрат влево нажмите стрелку влево");
            Console.WriteLine("Чтобы передвинуть квадрат вправо нажмите стрелку вправо");
            Console.WriteLine("Чтобы выйте нажмите Escape");
        }

        public virtual void MoveLeft()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X -= 1;
            }
        }

        public virtual void MoveRight()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += 1;
            }
        }
    }
}
