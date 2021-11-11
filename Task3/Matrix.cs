using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Matrix
    {
        public int size = 3;
        public int[,] MatrixSquare = new int[3, 3];

        public virtual void CreateMatrix()
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
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(MatrixSquare[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        protected virtual double Determinant()
        {
            return MatrixSquare[0, 0] * MatrixSquare[1, 1] * MatrixSquare[2, 2]
                + MatrixSquare[2, 0] * MatrixSquare[0, 1] * MatrixSquare[1, 2]
                + MatrixSquare[1, 0] * MatrixSquare[2, 1] * MatrixSquare[0, 2]
                - MatrixSquare[2, 0] * MatrixSquare[1, 1] * MatrixSquare[0, 2]
                - MatrixSquare[0, 0] * MatrixSquare[2, 1] * MatrixSquare[1, 2]
                - MatrixSquare[1, 0] * MatrixSquare[0, 1] * MatrixSquare[2, 2];
        }

        public virtual double CalculateDeterminant()
        {
            return Determinant();
        }
    }
}
