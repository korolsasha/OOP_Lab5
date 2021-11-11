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
            Console.WriteLine("Обычная матрица");
            Console.WriteLine();
            matrix.PrintMatrix();
            Console.WriteLine();
            Console.WriteLine("Определитель обычной матрицы = " + matrix.CalculateDeterminant());
            Console.WriteLine();

            idmat.CreateMatrix();
            Console.WriteLine("Единичная матрица");
            Console.WriteLine();
            idmat.PrintMatrix();
            Console.WriteLine();
            Console.WriteLine("Определитель единичной матрицы = " + idmat.CalculateDeterminant());
            Console.WriteLine();

            uptrmat.CreateMatrix();
            Console.WriteLine("Верхняя треугольная матрица");
            Console.WriteLine();
            uptrmat.PrintMatrix();
            Console.WriteLine();
            Console.WriteLine("Определитель верхней треугольной матрицы = " + uptrmat.CalculateDeterminant());

            Console.ReadKey();
        }
    }
}
