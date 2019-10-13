using System;
using System.Linq;
using System.Collections.Generic;

namespace _11_party_reservation_filter_module
{
    class ReservationFilter
    {
       public static List<string> startsWithList = new List<string>();
       public static List<string> endsWithList = new List<string>();
       public static List<string> Contains = new List<string>();
       public static List<int> Length = new List<int>();
        static void Main(string[] args)
        {
            

            var names = Console.ReadLine()
                .Split()
                .ToList();
            string command = "";
            Func<string, List<string>, bool> startsWithFunc = (name, condition) =>
        condition.All(c => !name.StartsWith(c));
            Func<string, List<string>, bool> endsWithFunc = (name, condition) =>
        condition.All(c => !name.EndsWith(c));
            Func<string, List<string>, bool> containsFunc = (name, condition) =>
        condition.All(c => !name.Contains(c));
            Func<string, List<int>, bool> lengthFunc = (name, condition) =>
        condition.All(c => c != name.Length);
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] comInfo = command.Split(new[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
                string action = comInfo[0];
                string condition = "";
                if(comInfo.Length > 2)
                {
                    condition = comInfo[2];
                }

                if (action == "Add")
                {
                    if(condition == "Starts")
                    {
                        string value = comInfo[4];
                        startsWithList.Add(value);
                    }
                    else if(condition == "Ends")
                    {
                        string value = comInfo[4];
                        endsWithList.Add(value);
                    }
                    else if (condition == "Length")
                    {
                        int value = int.Parse(comInfo[3]);
                        Length.Add(value);
                    }
                    else if (condition == "Contains")
                    {
                        string value = comInfo[3];
                        Contains.Add(value);
                    }
                }
                else if (action == "Remove")
                {
                    if (condition == "Starts")
                    {
                        string value = comInfo[4];
                        startsWithList.Remove(value);
                    }
                    else if (condition == "Ends")
                    {
                        string value = comInfo[4];
                        endsWithList.Remove(value);
                    }
                    else if (condition == "Length")
                    {
                        int value = int.Parse(comInfo[3]);
                        Length.Remove(value);
                    }
                    else if (condition == "Contains")
                    {
                        string value = comInfo[3];
                        Contains.Remove(value);
                    }
                }

            }
            Console.WriteLine(string.Join(" ", names.Where(x => (startsWithFunc(x, startsWithList))
            && (endsWithFunc(x, startsWithList)
            && (containsFunc(x, Contains))
            && (lengthFunc(x, Length))))));
        }
    }
}
