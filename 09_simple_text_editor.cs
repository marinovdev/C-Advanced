using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_simple_text_editor
{
    class TextEditor
    {
        static void Main()
        {
            Stack<string> textLog = new Stack<string>();
            string currentText = string.Empty;
            int nRepetitions = int.Parse(Console.ReadLine());
            for (int i = 0; i < nRepetitions; i++)
            {
                string[] command = Console.ReadLine()
                    .Split();
                string order = command[0];
                if(order == "1")
                {
                    string input = Convert.ToString(command[1]);
                    if (textLog.Count > 0)
                    {
                        currentText = textLog.Peek() + input;
                    }
                    else
                    {
                        currentText = input;
                    }
                    textLog.Push(currentText);
                }
                else if(order == "2")
                {
                    string newText = string.Empty;
                    int removeIndexes = int.Parse(command[1]);
                    currentText = textLog.Peek();
                    for (int a  = 0;
                        a < currentText.Length - removeIndexes;
                        a++)
                    {
                        newText += currentText[a];
                    }
                    textLog.Push(newText);
                }
                else if(order == "3")
                {
                    currentText = textLog.Peek();
                    Console.WriteLine(currentText[int.Parse(command[1]) - 1]);
                }
                else if(order == "4")
                {
                    textLog.Pop();
                }
            }
        }
    }
}
