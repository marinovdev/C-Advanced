using System;

namespace treeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var name = input1[0];
            var lastName = " " + input1[1];
            var address = input1[2];
            var town = input1[3];
            if(input1.Length > 4)
            {
                town += " " + input1[4];
            }

            var input2 = Console.ReadLine().Split();
            var name2 = input2[0];
            var littres = int.Parse(input2[1]);
            var condition = false;
            if (input2[2] == "drunk") condition = true;
            else condition = false;

            var input3 = Console.ReadLine().Split();
            var nameBankUser = input3[0];
            var doubleNum = double.Parse(input3[1]);
            var bankName = input3[2];

            var personInfo = new Treeuple<string, string, string>(name + lastName, address, town);
            var beerInfo = new Treeuple<string, int, bool>(name2, littres, condition);
            var numbersInfo = new Treeuple<string, double, string>(nameBankUser, doubleNum, bankName);
            Console.WriteLine($"{personInfo}");
            Console.WriteLine($"{beerInfo}");
            Console.WriteLine($"{numbersInfo}");
        }
    }
}
