using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_make_a_salad
{
    class Program
    {
        public static Dictionary<string, int> vegCalories = new Dictionary<string, int>()
        {

           {"tomato", 80},
           {"carrot", 136  },
           {"lettuce",109  },
            {"potato", 215  }

        };
        static void Main(string[] args)
        {
            var usedCalories = new Stack<int>();
            var vegetableEntry = Console.ReadLine().Split().ToList();
            var vegetable = new Queue<string>(vegetableEntry);

            var caloriesEntry = Console.ReadLine().Split().Select(int.Parse).ToList();
            var calories = new Stack<int>(caloriesEntry);

            var vegValue = vegCalories.Where(v => v.Key == vegetable.Peek())
            .First().Value; // 80
            int residue = 0;
            while (vegetable.Count != 0 && calories.Count != 0)
            {
                //tomato potato carrot lettuce tomato
                //250 563 478 330 470 112

                //carrot tomato potato potato lettuce tomato potato potato
                //105 130 200 110
                if (residue > 0)
                {
                    if (residue <= vegValue)
                    {
                        residue = 0;
                        vegetable.Dequeue();
                        if (vegetable.Count > 0)
                        {
                            vegValue = vegCalories.Where(v => v.Key == vegetable.Peek())
            .First().Value;
                        }
                    }
                    else if (residue > vegValue)
                    {
                        residue -= vegValue;
                        vegetable.Dequeue();
                        if (vegetable.Count > 0)
                        {
                            vegValue = vegCalories.Where(v => v.Key == vegetable.Peek())
             .First().Value;
                        }
                    }
                }
                else
                {
                    if (calories.Peek() <= vegValue)
                    {
                        vegetable.Dequeue();
                        usedCalories.Push(calories.Pop());
                        if (vegetable.Count > 0)
                        {
                            vegValue = vegCalories.Where(v => v.Key == vegetable.Peek())
            .First().Value;
                        }
                    }
                    else if (calories.Peek() > vegValue)
                    {
                        residue += calories.Peek() - vegValue; // 32
                        usedCalories.Push(calories.Pop());
                        vegetable.Dequeue();
                        if (vegetable.Count > 0)
                        {
                            vegValue = vegCalories.Where(v => v.Key == vegetable.Peek())
            .First().Value;
                        }


                    }
                }
            }
            if (usedCalories.Count > 0) // V
            {
                Console.WriteLine(string.Join(" ", usedCalories.Reverse()));
            }

            if (vegetable.Count > 0)
            {
                Console.WriteLine(string.Join(" ", vegetable));
            }

            if (calories.Count > 0) // V
            {
                Console.WriteLine(string.Join(" ", calories));
            }

        }
    }
}
