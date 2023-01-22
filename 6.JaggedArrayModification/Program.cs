using System;
using System.Linq;

namespace _6.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];


            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            var command = Console.ReadLine();

            while (command != "END")
            {
                string[] cmds = command.Split();
                var row = int.Parse(cmds[1]);
                var col = int.Parse(cmds[2]);
                var value = int.Parse(cmds[3]);

                if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (cmds[0] == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged.Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
