using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class UpperTriangularMatrixDeterminant : UpperTriangularMatrix
    {
        public override double CalculateDeterminant()
        {
            double result = Determinant();
            return result;
        }
    }
}
