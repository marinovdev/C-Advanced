using System;
using System.Collections.Generic;
using System.Linq;

    public class Program
    {
        public static bool operationAction = true;
        public static bool spaceShipIsVoid = false;
        public static int starPowerColected = 0;
        public static int[] blackHoleEntryLocation = new int[2] { 0,0};
       public  static void Main()
        {
            var list = new List<string>();
          
            var n = int.Parse(Console.ReadLine());
            Space.SpaceCoordinates = new char[n,n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                for (int y = 0; y < n; y++)
                {
                    Space.SpaceCoordinates[i, y] = Convert.ToChar(input[y]);
                }
            }

            while(operationAction && !spaceShipIsVoid)
            {
                var movement = Console.ReadLine();
                Space.SpaceCoordinates.Move( movement);
            }
            if(spaceShipIsVoid)
            {
                Console.WriteLine($"Bad news, the spaceship went to the void.");
            }
            else if (starPowerColected >= 50)
            {
                Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power!");
            }
            Console.WriteLine($"Star power collected: {starPowerColected}");
            for (int a = 0; a < Space.SpaceCoordinates.GetLength(0); a++)
            {
                for (int b = 0; b < Space.SpaceCoordinates.GetLength(1); b++)
                {
                    Console.Write(Space.SpaceCoordinates[a,b]);
                }
                Console.WriteLine();
            }
        }

    }
public static class Space
{
    private  static char[,] space;

    public  static char[,] SpaceCoordinates { get => space; set => space = value; }
    public static void Move(this char[,] SpaceCoordinates, string movement)
    {
        var xy = SpaceCoordinates.SpaceshipLocation();
        int[] nextLocation = new int[] { xy[0], xy[1]};
        if (movement == "up") nextLocation[0]--;
        else if (movement == "down") nextLocation[0]++;
        else if (movement == "left") nextLocation[1]--;
        else if (movement == "right") nextLocation[1]++;
        if (nextLocation.InSpaceRange(SpaceCoordinates))
        {
            if (nextLocation.IsNum(SpaceCoordinates))
            {
                Program.starPowerColected += int.Parse(SpaceCoordinates
                    [nextLocation[0], nextLocation[1]].ToString());
                SpaceCoordinates[nextLocation[0], nextLocation[1]] = 'S';
                SpaceCoordinates[xy[0], xy[1]] = '-';
            }
            else if (nextLocation.IsBlackHole(SpaceCoordinates))
            {
                SpaceCoordinates[xy[0], xy[1]] = '-';
                SpaceCoordinates[nextLocation[0], nextLocation[1]] = '-';
                var blackHoleLocation = SpaceCoordinates
                    .FindBlackHole(nextLocation);
                SpaceCoordinates[blackHoleLocation[0], blackHoleLocation[1]] = 'S';
            }
            else
            {
                SpaceCoordinates[nextLocation[0], nextLocation[1]] = 'S';
                SpaceCoordinates[xy[0], xy[1]] = '-';
            }
        }
        else
        {
            SpaceCoordinates[xy[0], xy[1]] = '-';
            Program.spaceShipIsVoid = true;
        }
        if (Program.starPowerColected >= 50)
        {
            Program.operationAction = false;
        }

    }

    public static bool InSpaceRange(this int[] value, char[,] space)
    {
        if (value[0] >= 0 && value[0] < space.GetLength(0)
            && value[1] >= 0 && value[1] < space.GetLength(1))
        {
            return true;
        }
        return false;
    }

    public static bool IsNum(this int[] value, char[,] space)
    {
        int num = 0;
        if (int.TryParse(space[value[0], value[1]].ToString(), out num))
        {
            return true;
        }
        return false;
    }
    public static bool IsBlackHole(this int[] value, char[,] space)
    {
        int num = 0;
        if (space[value[0], value[1]].ToString() == "O")
        {
            return true;
        }
        return false;
    }
    public static int[] FindBlackHole(this char[,] value,
       int[] blackHoleEntryLocation)
    {
        int[] output = new int[2];
        for (int a = 0; a < value.GetLength(0); a++)
        {
            for (int b = 0; b < value.GetLength(1); b++)
            {
                if (value[a, b] == 'O'
                    && (a != blackHoleEntryLocation[0]
                    || b != blackHoleEntryLocation[1]))
                {
                    output[0] = a;
                    output[1] = b;
                    break;
                }
            }
        }
        return output;
    }
    public  static int[] SpaceshipLocation(this char[,] value)
    {
        int[] output = new int[2];
        for (int a = 0; a < value.GetLength(0); a++)
        {
            for (int b = 0; b < value.GetLength(1); b++)
            {
                if (value[a, b] == 'S')
                {
                    output[0] = a;
                    output[1] = b;
                    goto End;
                }
            }
        }
    End:
        return output;
    }
}



