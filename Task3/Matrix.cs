﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Matrix
    {
        int size = 5;
        int[,] MatrixSquare = new int[5, 5];

        public virtual void CreateMatrix()
        {
            Random random = new Random();
            int rand;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    rand = random.Next(0, 100);
                    MatrixSquare[i, j] = rand;
                }
            }
        }

        public virtual void PrintMatrix()
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
    }
}
