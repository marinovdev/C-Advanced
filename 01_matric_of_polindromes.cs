using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_matric_of_polindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            // read input from the console
            int[] rowsAndColumns = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int row = rowsAndColumns[0];
            int col = rowsAndColumns[1];
            //empty multidimensional array
            string[,] letters = new string[row, col];
            char rowChar = 'a';
            char colChar = 'a';
            // loop and add values to array
            for (int a = 0; a < row; a++)
            {
                for (int b = 0; b < col; b++)
                {
                    char first = (char)(97 + a);
                    char secound = (char)(97 + a + b);
                    letters[a, b] = Convert.ToString(first) + Convert.ToString(secound) + Convert.ToString(first);
                }
            }
            // Print the result
            for (int i = 0; i < letters.GetLength(0); i++)
            {
                for (int x = 0; x < letters.GetLength(1); x++)
                {
                    Console.Write(letters[i,x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
