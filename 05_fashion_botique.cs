using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_fashion_botique
{
    class Botique
    {
       static Stack<int> clothesInBotique = new Stack<int>();
       static int racksCount = 1;
       static int currentRackCompleteness = 0;
        static void Main(string[] args)
        {
            int[] clothesInput = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();
            int rackSize = int.Parse(Console.ReadLine());
            foreach (var item in clothesInput)
            {
                clothesInBotique.Push(item);
            }
            while(clothesInBotique.Count > 0)
            {
                if(clothesInBotique.Peek() + currentRackCompleteness <= rackSize)
                {
                    currentRackCompleteness += clothesInBotique.Pop();
                }
                else
                {
                    racksCount++;
                    currentRackCompleteness = 0;
                        currentRackCompleteness += clothesInBotique.Pop();
                }
                //if (clothesInBotique.Count == 0) break;
            }
            Console.WriteLine(racksCount);
        }
    }
}
