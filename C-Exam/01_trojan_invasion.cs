using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_trojan_invasion
{
    class Program
    {
        public static List<int> deffence = new List<int>();
        public static List<int> trojans = new List<int>();
        public static int waves = 0;
        public static int currentWave = 0;

        static void Main(string[] args)
        {
            waves = int.Parse(Console.ReadLine());
            deffence = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (currentWave < waves && deffence.Count != 0)
            {
                currentWave++;

               var trojansInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
                trojans.AddRange(trojansInput);
                if (currentWave % 3 == 0)
                {
                    var newLines = Console.ReadLine().Split().Select(int.Parse)
                        .ToList();
                    deffence.AddRange(newLines);
                }

                while(trojans.Count > 0)
                {
                    if (trojans.Count == 0 || deffence.Count == 0) break;

                    AttackLine(trojans.Count - 1);

                }
            }

            if (deffence.Count > 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            }
            else
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");

            if (trojans.Count > 0)
            {

                trojans.Reverse();
                Console.WriteLine($"Warriors left: {string.Join(", ", trojans)}");
            }
            if (deffence.Count > 0)
            {

                Console.WriteLine($"Plates left: {string.Join(", ", deffence)}");
            }




        }

        public static void AttackLine(int a)
        {
            var defIndex = 0;

            if (deffence[defIndex] > trojans[a])
            {

                deffence[defIndex] -= trojans[a];
                trojans.RemoveAt(a);

            }
            else if (deffence[defIndex] < trojans[a])
            {
                trojans[a] -= deffence[defIndex];
                deffence.RemoveAt(defIndex);
            }
            else
            {
                deffence.RemoveAt(defIndex);
                trojans.RemoveAt(a);
            }

        }
    }
}
