using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
             var listIterator = new ListyIterator<string>(new List<string>());
            var createArray = Console.ReadLine()
                .Split();
            var input = new string[createArray.Length - 1];
            for (int i = 1; i < createArray.Length; i++)
            {
                input[i - 1] = createArray[i];
            }
            listIterator.Create(input);
            var command = "";
            while((command = Console.ReadLine()) != "END")
            {
                if(command == "HasNext")
                {
                    Console.WriteLine( listIterator.HasNext());
                }
                else if(command == "Move")
                {
                    Console.WriteLine(listIterator.Move());
                }
                else if(command == "Print")
                {
                    listIterator.Print();
                }
                else if(command == "PrintAll")
                {
                    listIterator.PrintAll();
                    Console.WriteLine();
                }
            }
        }
    }
    class ListyIterator<T> : IEnumerable<T>
    {
        private static List<T> list;
        private int currentIndex = 0;
        public ListyIterator(List<T> list)
        {
            this.List = new List<T>();
            this.List = list;
        }

        public bool Move()
        {

            if (currentIndex + 1 < List.Count)
            {
                currentIndex++;
                return true;
            }
            else return false;
        }

        public bool HasNext()
        {
            if (currentIndex + 1< List.Count) return true;
            else return false;
        }

        public void Print()
        {
            if (currentIndex < List.Count)
            {
                Console.WriteLine(List[currentIndex]);
            }
            else
                Console.WriteLine(("Invalid Operation!"));
        }

        public void Create(params T[] arr)
        {
            foreach (var element in arr)
            {
                List.Add(element);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {

            while(currentIndex < List.Count)
            { 
                yield return this.List[currentIndex];
                currentIndex++;
            }
        }

        public void PrintAll()
        {
            foreach (var item in List)
            {
                Console.Write(item + " ");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public List<T> List
        {
            get { return list; }
            set { list = value; }
        }

    }
}
