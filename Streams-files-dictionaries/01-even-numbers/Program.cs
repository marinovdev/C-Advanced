using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01_even_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"..\..\..\text.txt";
            string writerFile = @"..\..\..\output.txt";
            int counter = 0;
            var letterChar = new char[] { '-', ',', '.', '!', '?' };
            using (StreamReader reader = new StreamReader(fileName))
            {
                using (StreamWriter writer = new StreamWriter(writerFile))
                {
                    while (!reader.EndOfStream)
                    {
                        var readLine = reader.ReadLine()
                                .Split().ToList();
                        readLine.Reverse();

                        if (counter % 2 == 0)
                        {
                            for (int i = 0; i < readLine.Count; i++)
                            {
                                var word = readLine[i];
                                foreach (var symbol in letterChar)
                                {
                                    word = word.Replace(symbol, '@');
                                }
                                readLine[i] = word;
                            }
                            string output = string.Join(" ", readLine);
                            writer.WriteLine(output);
                            readLine.Clear();
                        }
                        counter++;
                    }
                }
            }
        }

    }
}
