using System;
using System.Linq;

namespace _3.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rowAndColCount = int.Parse(Console.ReadLine());

            var matrix = new int[rowAndColCount, rowAndColCount];
            var sum = 0;

            for (int row = 0; row < rowAndColCount; row++)
            {
                int[] data = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < rowAndColCount; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            for (int row = 0; row < rowAndColCount; row++)
            {
                sum += matrix[row, row];
            }
            Console.WriteLine(sum);
        }
    }
}
