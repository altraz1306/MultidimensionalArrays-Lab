using System;

namespace _7.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangleSize = long.Parse(Console.ReadLine());
            long[][] triangle = new long[triangleSize][];
            triangle[0] = new long[1] { 1 };
            for (int row = 1; row < triangleSize; row++)
            {
                triangle[row] = new long[row + 1];
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    if (triangle[row - 1].Length > col)
                    {
                        triangle[row][col] += triangle[row - 1][col];
                    }
                    if (col > 0)
                    {
                        triangle[row][col] += triangle[row - 1][col - 1];
                    }
                }
            }
            for (int row = 0; row < triangle.Length; row++)
            {
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    Console.Write($"{triangle[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
