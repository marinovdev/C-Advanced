using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06_song_queue
{
    class SongQueue
    {
        static void Main()
        {
            string pattern = @"([A-z]*)[ ]{0,}(.*)";
            Queue<string> songs = new Queue<string>();
            string[] songsInput = Console.ReadLine()
                .Split(", ");
            
            foreach (var item in songsInput)
            {
                songs.Enqueue(item);
            }
            
            while (songs.Count > 0)
            {
                string command = Console.ReadLine();
                Match match = Regex.Match(command, pattern);
                string order = match.Groups[1].Value;
                string value = match.Groups[2].Value;
                    if (order == "Play")
                    {
                        if (songs.Count > 0)
                        {
                            songs.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("No more songs!");
                        }
                    }
                    else if (order == "Add")
                    {
                        if (!songs.Contains(value))
                        {
                            songs.Enqueue(value);
                        }
                        else
                        {
                            Console.WriteLine($"{value} is already contained!");
                        }
                    }
                    else if (order == "Show")
                    {
                        string[] output = new string[songs.Count];
                        for (int i = 0; i < output.Length; i++)
                        {
                            output[i] = songs.Peek();
                            songs.Enqueue(songs.Dequeue());
                        }
                        Console.WriteLine(String.Join(", ", output));
                    }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
