using System;
using System.Collections.Generic;
//https://judge.softuni.bg/Contests/Compete/Index/1447#8
namespace _08_balanced_paranthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> paranthesisChars = new Queue<char>();
            bool isBalanced = true;
            char[] text = Console.ReadLine().ToCharArray();
            int textLenght = 0;
            foreach (var item in text)
            {
                textLenght += 1;
            }
            if (text.Length % 2 == 0)
            {
                for (int i = 0; i < text.Length / 2; i++)
                {
                    if(text[i] == '(' && text[text.Length - 1 - i] != ')')
                    {
                            isBalanced = false;
                            break;
                    }
                    //else if(text[i] == ')' && text[text.Length - 1 - i] != '(')
                    //{

                    //}
                    else if(text[i] == '[' && text[text.Length - 1 - i] != ']')
                    {
                        isBalanced = false;
                        break;
                    }
                    //else if(text[i] == ']')
                    //{

                    //}
                    else if(text[i] == '{' && text[text.Length - 1 - i] != '}')
                    {
                        isBalanced = false;
                        break;
                    }
                    //else if(text[i] == '}')
                    //{

                    //}

                }
            }
            else
            {
                isBalanced = false;
            }
            if(isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
