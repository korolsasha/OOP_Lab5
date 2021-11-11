using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class UpperTriangularMatrix : Matrix
    {
        public override void CreateMatrix()
        {
            Random random = new Random();
            int rand;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    rand = random.Next(0, 10);
                    MatrixSquare[i, j] = rand;
                }
            }

            int a = 1;

            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    MatrixSquare[i, j] = 0;
                }

                a++;
            }
        }

        public override void PrintMatrix()
        {
            Console.WriteLine("Верхняя треугольная матрица");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(MatrixSquare[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
