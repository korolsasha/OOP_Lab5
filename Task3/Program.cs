using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            IdentityMatrix idmat = new IdentityMatrix();
            UpperTriangleMatrix uptrmat = new UpperTriangleMatrix();

            matrix.CreateMatrix();
            matrix.PrintMatrix();

            Console.WriteLine();

            idmat.CreateMatrix();
            idmat.PrintMatrix();

            Console.WriteLine();

            uptrmat.CreateMatrix();
            uptrmat.PrintMatrix();

            Console.ReadKey();
        }
    }
}
