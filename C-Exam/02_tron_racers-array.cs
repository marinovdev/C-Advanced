using System;

namespace _02_tron_racers
{
    class Program
    {
        public static bool matchAlive = true;
        public static char f = 'f';
        public static char s = 's';
        public static int[] fCoordinates = new int[2] { -1, -1 };
        public static int[] sCoordinates = new int[2] { -1, -1 };
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            char[,] arr = new char[n, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = input[j];
                }
            }
            while (matchAlive)
            {
                var command = Console.ReadLine().Split();
                var firstDirection = command[0];
                var secoundDirection = command[1];
                Football.Movement(ref arr, f, firstDirection);
                if (!matchAlive) break;
                Football.Movement(ref arr, s, secoundDirection);
            }
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{arr[i, j]}");
                    }
                    Console.WriteLine();
                }
        }
    }

    public static class Football
    {

        public static void Movement(ref char[,] arr, char player, string direction)
        {
            int[] currentCoor = new int[2];
            int[] newLocation = new int[2];
            if (player == 'f' && Program.fCoordinates[0] == -1)
            {
                currentCoor = arr.Locate(player);
                Program.fCoordinates = arr.Locate(player);
            }
            else if (player == 's' && Program.sCoordinates[0] == -1)
            {
                currentCoor = arr.Locate(player);
                Program.sCoordinates = arr.Locate(player);
            }

            if (direction == "up")
            {
                if (player == 'f')
                {
                    newLocation = new int[] { Program.fCoordinates[0] - 1, Program.fCoordinates[1] };
                }
                else if (player == 's')
                {
                    newLocation = new int[] { Program.sCoordinates[0] - 1, Program.sCoordinates[1] };
                }

                //in matrix
                if (arr.GetLength(0) > newLocation[0] && arr.GetLength(1) > newLocation[1]
                    && 0 <= newLocation[0] && 0 <= newLocation[1])
                {
                    // check condition
                    //in game
                    if (arr[newLocation[0], newLocation[1]] == '*' ||
                        arr[newLocation[0], newLocation[1]] == player)
                    {
                        arr[newLocation[0], newLocation[1]] = player;
                        AsignNewLocationToPlayer(player, newLocation);
                    }
                    else
                    {
                        arr[newLocation[0], newLocation[1]] = 'x';
                        AsignNewLocationToPlayer(player, newLocation);
                        Program.matchAlive = false;
                    }
                }
                //out of matrix
                else
                {
                    int[] teleport = newLocation;
                    Teleport(ref newLocation, ref arr, player);
                }

            }
            ////////
            ////
            ///

            if (direction == "down")
            {
                if (player == 'f')
                {
                    newLocation = new int[] { Program.fCoordinates[0] + 1, Program.fCoordinates[1] };
                }
                else if (player == 's')
                {
                    newLocation = new int[] { Program.sCoordinates[0] + 1, Program.sCoordinates[1] };
                }

                //in matrix
                if (arr.GetLength(0) > newLocation[0] && arr.GetLength(1) > newLocation[1]
                    && 0 <= newLocation[0] && 0 <= newLocation[1])
                {
                    // check condition
                    //in game
                    if (arr[newLocation[0], newLocation[1]] == '*' ||
                        arr[newLocation[0], newLocation[1]] == player)
                    {
                        arr[newLocation[0], newLocation[1]] = player;
                        AsignNewLocationToPlayer(player, newLocation);
                    }
                    else
                    {
                        arr[newLocation[0], newLocation[1]] = 'x';
                        AsignNewLocationToPlayer(player, newLocation);
                        Program.matchAlive = false;
                    }
                }
                //out of matrix
                else
                {
                    int[] teleport = newLocation;
                    Teleport(ref newLocation, ref arr, player);
                }
            }


            if (direction == "left")
            {
                if (player == 'f')
                {
                    newLocation = new int[] { Program.fCoordinates[0], Program.fCoordinates[1] - 1};
                }
                else if (player == 's')
                {
                    newLocation = new int[] { Program.sCoordinates[0], Program.sCoordinates[1] - 1 };
                }

                //in matrix
                if (arr.GetLength(0) > newLocation[0] && arr.GetLength(1) > newLocation[1]
                    && 0 <= newLocation[0] && 0 <= newLocation[1])
                {
                    // check condition
                    //in game
                    if (arr[newLocation[0], newLocation[1]] == '*' ||
                        arr[newLocation[0], newLocation[1]] == player)
                    {
                        arr[newLocation[0], newLocation[1]] = player;
                        AsignNewLocationToPlayer(player, newLocation);
                    }
                    else
                    {
                        arr[newLocation[0], newLocation[1]] = 'x';
                        AsignNewLocationToPlayer(player, newLocation);
                        Program.matchAlive = false;
                    }
                }
                //out of matrix
                else
                {
                    int[] teleport = newLocation;
                    Teleport(ref newLocation, ref arr, player);
                }
            }


            if (direction == "right")
            {
                if (player == 'f')
                {
                    newLocation = new int[] { Program.fCoordinates[0], Program.fCoordinates[1] + 1};
                }
                else if (player == 's')
                {
                    newLocation = new int[] { Program.sCoordinates[0], Program.sCoordinates[1] + 1};
                }

                //in matrix
                if (arr.GetLength(0) > newLocation[0] && arr.GetLength(1) > newLocation[1]
                    && 0 <= newLocation[0] && 0 <= newLocation[1])
                {
                    // check condition
                    //in game
                    if (arr[newLocation[0], newLocation[1]] == '*' ||
                        arr[newLocation[0], newLocation[1]] == player)
                    {
                        arr[newLocation[0], newLocation[1]] = player;
                        AsignNewLocationToPlayer(player, newLocation);
                    }
                    else
                    {
                        arr[newLocation[0], newLocation[1]] = 'x';
                        AsignNewLocationToPlayer(player, newLocation);
                        Program.matchAlive = false;
                    }
                }
                //out of matrix
                else
                {
                    int[] teleport = newLocation;
                    Teleport(ref newLocation, ref arr, player);
                }
            }
        }
            public static int[] Locate(this char[,] arr, char player)
            {
                int[] output = new int[2];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] == player)
                        {
                            output = new int[] { i, j };
                            return output;
                        }
                    }
                }
                return output;
            }

            public static void AsignNewLocationToPlayer(char player, int[] coordinates)
            {
                if (player == 'f')
                {
                    Program.fCoordinates = new int[] { coordinates[0], coordinates[1] };
                }
                else
                {
                    Program.sCoordinates = new int[] { coordinates[0], coordinates[1] };
                }
            }

            public static void Teleport(ref int[] newLocation, ref char[,] arr, char player)
            {
                int[] teleport = newLocation;
                if (newLocation[0] < 0)
                {
                    teleport = new int[] { arr.GetLength(0) - 1, newLocation[1] };
                }
                else if (newLocation[0] >= arr.GetLength(1))
                {
                    teleport = new int[] { 0, newLocation[1] };
                }
                if (newLocation[1] < 0)
                {
                    teleport[1] = arr.GetLength(1) - 1;
                }
                if (newLocation[1] >= arr.GetLength(1))
                {
                    teleport[1] = 0;
                }
                AsignNewLocationToPlayer(player, teleport);
                // goto location
                if (
                     arr[teleport[0], teleport[1]] != player
                     && arr[teleport[0], teleport[1]] != '*'
                    )
                {
                    Program.matchAlive = false;
                    arr[teleport[0], teleport[1]] = 'x';
                }
                else
                {
                    arr[teleport[0], teleport[1]] = player;
                }
            }



        }
    }
