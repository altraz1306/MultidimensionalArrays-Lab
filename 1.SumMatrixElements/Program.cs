using System;
using System.Linq;

namespace _1.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(array[0]);
            var cols = int.Parse(array[1]);

            var matrix = new int[rows, cols];
            var sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);

            //PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
