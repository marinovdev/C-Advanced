using System;
using System.Collections.Generic;
using System.Linq;
namespace _06_wardrobe
{
    class Wardrobe
    {
        static void Main()
        {
            //char[] splitter = new char[] { ' ', '-', '>', ',' };
            Dictionary<string, Dictionary<string, int>> wardrobe = 
                new Dictionary<string, Dictionary<string, int>>();
            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> ", ","}, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                var clothes = new List<string>();
                for (int j = 1; j < input.Length; j++)
                {
                    clothes.Add(input[j]);
                }
                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (var cloth in clothes)
                {
                    if(!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 1);
                    }
                    else
                    {
                        wardrobe[color][cloth]++;
                    }
                }

            }
            string[] search = Console.ReadLine()
                .Split();
            string colorToSearch = search[0];
            string clothToSearch = search[1];
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in wardrobe[color.Key])
                {
                    if(colorToSearch == color.Key && clothToSearch == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
