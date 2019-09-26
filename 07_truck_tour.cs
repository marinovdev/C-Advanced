using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_truck_tour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            var pumps = new Queue<int[]>();
            int nOperations = int.Parse(Console.ReadLine());
            for (int i = 0; i < nOperations; i++)
            {
                pumps.Enqueue(Console.ReadLine()
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray());
            }
            for (int a = 0; a < nOperations; a++)
            {
                if(SolutionFound(pumps))
                {
                    Console.WriteLine(a);
                    break;
                }
                int[] currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
            }
        }

        static bool SolutionFound(Queue<int[]> pumps)
        {
            int fuelAvalible = 0;
            bool stats = true;
            for (int i = 0; i < pumps.Count; i++)
            {
                int[] currentPump = pumps.Dequeue();
                fuelAvalible += currentPump[0] - currentPump[1];
                pumps.Enqueue(currentPump);
                if (fuelAvalible < 0)
                {
                    stats = false;
                }
            }
            return stats;
        }
    }
}
