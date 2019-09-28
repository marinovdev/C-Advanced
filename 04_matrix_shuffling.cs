using System;
using System.Linq;

namespace _04_matrix_shuffling
{
    class MatrixShuffling
    {
        static void Main()
        {
            var boundaries = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[boundaries[0], boundaries[1]];

            for (int i = 0; i < boundaries[0]; i++)
            {
                var entry = Console.ReadLine()
                    .Split()
                    .ToArray();
                for (int j = 0; j < boundaries[1]; j++)
                {
                    matrix[i, j] = entry[j];
                }

            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] array = command.Split();
                int row1 = 0;
                int row2 = 0;
                int col1 = 0;
                int col2 = 0;
                bool matricScope = false;
                bool condition = false;
                if (array.Length == 5)
                {
                    condition = int.TryParse(array[1], out row1) &&
                    int.TryParse(array[2], out col1) &&
                    int.TryParse(array[3], out row2) &&
                    int.TryParse(array[4], out col2) ?
                    true : false;

                    matricScope = row1 < matrix.GetLength(0) &&
                    row2 < matrix.GetLength(0) &&
                    col1 < matrix.GetLength(1) &&
                    col2 < matrix.GetLength(1) ?
                    true : false;
                }
                if (matricScope && array[0] == "swap" && condition && matricScope)
                {
                    string tempValue = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = tempValue;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
