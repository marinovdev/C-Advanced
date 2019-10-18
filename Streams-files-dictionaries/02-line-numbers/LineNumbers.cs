using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_line_numbers
{
    class Program
    {
        public static Dictionary<int, LetterPunctuation> dict = new Dictionary<int, LetterPunctuation>();
        static void Main(string[] args)
        {
            //Line 1: -I was quick to judge him, but it wasn't his fault. (37)(4)
            //Line 2: -Is this some kind of joke?!Is it ? (24)(4)
            //Line 3: -Quick, hide here. It is safer. (22)(4)
            var letter = @"[a-zA-Z]";
            string symbol = @"[^\w\s]";
            using (var streamReader = new StreamReader(@"..\..\..\text.txt"))
            {
                int line = 1;
                using (var streamWriter = new StreamWriter(@"..\..\..\output.txt"))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var currentReadRaw = streamReader.ReadLine();
                        var currentRead= currentReadRaw.Split();
                        dict.Add(line, new LetterPunctuation());
                        foreach (var word in currentRead)
                        {
                            foreach (var ch in word)
                            {
                                Match letterMatch = Regex.Match(ch.ToString(), letter);
                                Console.WriteLine(ch.ToString());
                                Match symbolMatch = Regex.Match(ch.ToString(), symbol);
                                if (letterMatch.Success)
                                {
                                    dict[line].LetterCount++;
                                }
                                else if (symbolMatch.Success)
                                {
                                    dict[line].PunctCount++;
                                }
                            }
                        }
                        streamWriter.WriteLine($"Line {line}: {currentReadRaw} " +
                            $"({dict[line].LetterCount})({dict[line].PunctCount})");
                        line++;
                    }
                }
            }

        }
    }

    class LetterPunctuation
    {
        public int LetterCount { get; set; }
        public int PunctCount { get; set; }

        public LetterPunctuation()
        {
            this.LetterCount = 0;
            this.PunctCount = 0;
        }
    }
}
