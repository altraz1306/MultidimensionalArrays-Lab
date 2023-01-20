using System;

namespace _4.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var rows = matrixSize;
            var cols = matrixSize;

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var symbols = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    var currentSymbol = symbols[col];
                    matrix[row, col] = currentSymbol;
                }
            }
            var symbol = char.Parse(Console.ReadLine());
            int intSymbol = symbol;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
