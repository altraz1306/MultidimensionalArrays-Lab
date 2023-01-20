using System;
using System.Linq;

namespace _5.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = ReadingMatrix();
            var sum = 0;
            var row = 0;
            var col = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    var currentSum = 0;

                    if (rows >= matrix.GetLength(0) - 1 || cols >= matrix.GetLength(1) - 1)
                    {
                        continue;
                    }
                    currentSum += matrix[rows, cols];
                    currentSum += matrix[rows + 1, cols];
                    currentSum += matrix[rows, cols + 1];
                    currentSum += matrix[rows + 1, cols + 1];

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        row = rows;
                        col = cols;
                    }
                }
            }
            Console.WriteLine($"{matrix[row, col]} {matrix[row, col + 1]}");
            Console.WriteLine($"{matrix[row + 1, col]} {matrix[row + 1, col + 1]}");
            Console.WriteLine(sum);
        }

        public static int[,] ReadingMatrix()
        {
            string[] matrixSize = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var row = int.Parse(matrixSize[0]);
            var col = int.Parse(matrixSize[1]);

            var matrix = new int[row, col];

            for (int rows = 0; rows < row; rows++)
            {
                int[] data = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int cols = 0; cols < col; cols++)
                {
                    matrix[rows, cols] = data[cols];
                }
            }
            return matrix;
        }
    }
}
