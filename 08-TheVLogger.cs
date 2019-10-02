using System;
using System.Collections.Generic;
using System.Linq;

class VloggerData
{
    public int Followers { get; set; } = 0;
    public SortedSet<string> Following { get; set; }
    public VloggerData(int Followers)
    {
        this.Followers = 0;
        this.Following = new SortedSet<string>();
    }
}
class TheVLogger
{
    static void Main(string[] args)
    {
        Dictionary<string, VloggerData> vloggers = new Dictionary<string, VloggerData>();

        while (true)
        {
            string operation = string.Empty;
            string user2 = string.Empty;
            var command = Console.ReadLine()
                .Split();
            string user = command[0];
            if (command.Length > 1)
            {
                operation = command[1];
            }
            if (operation == "joined")
            {
                if (!vloggers.ContainsKey(user))
                {
                    vloggers.Add(user, new VloggerData(0));
                }
            }
            else if (operation == "followed")
            {
                user2 = command[2];
                if (user != user2 && vloggers.ContainsKey(user) &&
                    vloggers.ContainsKey(user2) &&
                        !vloggers[user2].Following.Contains(user))
                {
                    vloggers[user2].Following.Add(user);
                    vloggers[user].Followers++;
                }
            }
            else if (command.Length == 1 && user == "Statistics")
            {
                var vloggersSorted = vloggers.OrderByDescending(x => x.Value.Following.Count)
                    .ThenBy(x => x.Value.Followers);
                
                Console.WriteLine($"The V-Logger has a total of " +
                    $"{vloggers.Count} vloggers in its logs.");
                Console.WriteLine($"1. {vloggersSorted.First().Key} : " +
                    $"{vloggersSorted.First().Value.Following.Count} followers, " +
                    $"{vloggersSorted.First().Value.Followers} following");
                foreach (var item in vloggersSorted.First().Value.Following.OrderBy(x => x))
                {
                    Console.WriteLine($"*  {item}");
                }
                if (vloggers.Count > 2)
                {
                    for (int a = 1; a < vloggers.Count; a++)
                    {
                        Console.WriteLine($"{a + 1}. {vloggersSorted.ElementAt(a).Key} : " +
                            $"{vloggersSorted.ElementAt(a).Value.Following.Count} followers, " +
                            $"{vloggersSorted.ElementAt(a).Value.Followers} following");
                    }
                }
                break;
            }
        }
    }
}

