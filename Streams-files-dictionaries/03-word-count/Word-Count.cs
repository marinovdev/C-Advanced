using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_word_count
{
    class Program
    {
        static void Main(string[] args)
        {
            var expectedDic = new Dictionary<string, int>();
            var actualDic = new Dictionary<string, int>();
            var words = new StreamReader(@"..\..\..\words.txt");
           // var text = new StreamReader(@"..\..\..\text.txt"); // <========
            var actualResult = new StreamWriter(@"..\..\..\actualResult.txt");
            var expectedResult = new StreamWriter(@"..\..\..\expectedResult.txt");
            while(!words.EndOfStream)
            {
                var currentWord = words.ReadLine();
                expectedDic.Add(currentWord, 0);
                var allText = File.ReadAllText(@"..\..\..\text.txt");
                int occurances = Regex.Matches(allText.ToLower(), (@"[^\w]" + currentWord.ToLower()) + @"[^\w]").Count;
                expectedDic[currentWord] = occurances;
            }
            foreach (var word in expectedDic)
            {
                expectedResult.WriteLine(word.Key + " - " + word.Value);
            }
            actualDic = expectedDic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var word in actualDic)
            {
                actualResult.WriteLine(word.Key + " - " + word.Value);
            }
            expectedResult.Close();
            actualResult.Close();

        }
    }
}
