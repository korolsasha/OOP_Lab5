using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class IdentityMatrix : Matrix
    {
        public override void CreateMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        MatrixSquare[i, j] = 1;
                    }

                    if (i != j)
                    {
                        MatrixSquare[i, j] = 0;
                    }
                }
            }
        }
    }
}
