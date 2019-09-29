using System;
using System.Linq;

class JaggedArrayManipulator
{
    static string toDo = string.Empty;
    static int row = 0;
    static int col = 0;
    static int value = 0;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] arr = new int[n][];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arr[i] = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
        // Analize
        for (int a = 0; a < arr.GetLength(0); a++)
        {
            if (a != arr.GetLength(0) - 1 && arr[a].Length == arr[a + 1].Length)
            {
                currentLine(arr, a, true);
                followingLine(arr, a, true);

            }
            if (a != arr.GetLength(0) - 1 && arr[a].Length != arr[a + 1].Length)
            {
                currentLine(arr, a, false);
                followingLine(arr, a, false);
            }
        }
        //
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandArray = command.Split();
            if (commandArray.Length == 4)
            {
                toDo = commandArray[0];
                row = int.Parse(commandArray[1]);
                col = int.Parse(commandArray[2]);
                value = int.Parse(commandArray[3]);
            }
            if (toDo == "Add" &&
                row < arr.Length &&
                row >= 0 &&
                col < arr[row].Length &&               
                col >= 0)
            {
                arr[row][col] += value;
            }
            else if (toDo == "Subtract" &&
                row < arr.Length &&
                row >= 0 &&
                col < arr[row].Length &&           
                col >= 0)
            {
                arr[row][col] -= value;
            }
        }
        //Print
        for (int a = 0; a < arr.GetLength(0); a++)
        {
            for (int b = 0; b < arr[a].Length; b++)
            {
                Console.Write(arr[a][b] + " ");
            }
            Console.WriteLine();
        }
    }

    static void currentLine(int[][] arr, int a, bool condition)
    {
        if (condition)
        {
            for (int b = 0; b < arr[a].Length; b++)
            {
                arr[a][b] = arr[a][b] * 2;
            }
        }
        else
        {
            for (int b = 0; b < arr[a].Length; b++)
            {
                arr[a][b] = arr[a][b] / 2;
            }
        }
    }
    static void followingLine(int[][] arr, int a, bool condition)
    {
        if (condition)
        {
            for (int b = 0; b < arr[a + 1].Length; b++)
            {
                arr[a + 1][b] = arr[a + 1][b] * 2;
            }
        }
        else
        {
            for (int b = 0; b < arr[a + 1].Length; b++)
            {
                arr[a + 1][b] = arr[a + 1][b] / 2;
            }
        }
    }
}

