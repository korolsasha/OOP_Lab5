using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task1
{
    class SquareRotate : SquareMove
    {

        public override void MoveLeft() { Rotate(15); }

        public override void MoveRight() { Rotate(15); }

        public override void MovementInstructions()
        {
            Console.WriteLine("Чтобы повернуть квадрат влево нажмите стрелку влево");
            Console.WriteLine("Чтобы повернуть квадрат вправо нажмите стрелку вправо");
            Console.WriteLine("Чтобы выйти нажмите Escape");
        }

        protected void Rotate(double degrees)
        {
            double radians = degrees / 180d * Math.PI;

            for (int i = 0; i < points.Length; i++)
            {
                double x = points[i].X;
                double y = points[i].Y;

                double x1 = x * Math.Cos(radians) - y * Math.Sin(radians);
                double y1 = x * Math.Sin(radians) + y * Math.Cos(radians);

                points[i].X = Convert.ToSingle(x1);
                points[i].Y = Convert.ToSingle(y1);
            }
        }
    }
}
