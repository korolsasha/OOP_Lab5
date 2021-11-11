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
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            Matrix matrix = new Matrix();
            IdentityMatrix idmat = new IdentityMatrix();
            UpperTriangularMatrix uptrmat = new UpperTriangularMatrix();

            matrix.CreateMatrix();
            matrix.PrintMatrix();
            Console.WriteLine("Определитель обычной матрицы = " + matrix.CalculateDeterminant());

            Console.WriteLine();

            idmat.CreateMatrix();
            idmat.PrintMatrix();
            Console.WriteLine("Определитель единичной матрицы = " + idmat.CalculateDeterminant());

            Console.WriteLine();

            uptrmat.CreateMatrix();
            uptrmat.PrintMatrix();
            Console.WriteLine("Определитель верхней треугольной матрицы = " + uptrmat.CalculateDeterminant());

            Console.ReadKey();
        }
    }
}
