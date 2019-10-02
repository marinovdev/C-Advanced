using System;
using System.Collections.Generic;
using System.Linq;

public class UserData : Ranking
{
    public int TotalPoints { get; private set; } = 0;
    public Dictionary<string, int> ContestLog { get; set; }
    public UserData()
        {
        this.TotalPoints = TotalPoints;
        this.ContestLog = new Dictionary<string, int>();
        }

    public void AddPoints(int points)
    {
        this.TotalPoints += points;
    }
    public void AddEvent(string EventName,string EventPass, int points)
    {
        if (
            contest.ContainsKey(EventName) &&
            contest[EventName] == EventPass
            )
        {
            ContestLog.Add(EventName, points);
        }
    }
}
public class Ranking
{
    public static Dictionary<string, string> contest = new Dictionary<string, string>();
    static void Main(string[] args)
    {
        var userData = new Dictionary<string, UserData>();

        string input = "";
        while ((input = Console.ReadLine()) != "end of contests")
        {
            string[] inputArr = input.Split(':');
            string contestName = inputArr[0];
            string contestPass = inputArr[1];

            if (!contest.ContainsKey(contestName))
            {
                contest.Add(contestName, contestPass);
            }
        }
        while ((input = Console.ReadLine()) != "end of submissions")
        {
            string[] inputArr = input.Split("=>");
            string contestName = inputArr[0];
            string contestPass = inputArr[1];
            string userName = inputArr[2];
            int userPoints = int.Parse(inputArr[3]);
            // first occurance for given username
            if (contest.ContainsKey(contestName) &&
                contest[contestName] == contestPass &&
                !userData.ContainsKey(userName))
            {
                userData.Add(userName, new UserData());
            }
            // first occurance for given contest
            if (contest.ContainsKey(contestName) &&
            contest[contestName] == contestPass &&
            userData.ContainsKey(userName)&&
            !userData[userName].ContestLog.ContainsKey(contestName))
            {
                userData[userName].AddEvent(contestName, contestPass, 0);
            }
            //secound occurance for given contest
            if(contest.ContainsKey(contestName) &&
            contest[contestName] == contestPass &&
            userData.ContainsKey(userName) &&
            userData[userName].ContestLog.ContainsKey(contestName))
            {
                if (userData[userName].ContestLog[contestName] < userPoints)
                {
                    userData[userName].AddPoints(userPoints - userData[userName].ContestLog[contestName]);
                    userData[userName].ContestLog[contestName] = userPoints;
                   
                }
            }
        }
        var usersSorted = userData.OrderByDescending(x => x.Value.TotalPoints);
        Console.WriteLine($"Best candidate is {usersSorted.First().Key} with total " +
            $"{usersSorted.First().Value.TotalPoints} points.");
        Console.WriteLine("Ranking:");
        foreach (var item in userData.OrderBy(x => x.Key))
        {
            Console.WriteLine(item.Key);
            foreach (var contest in item.Value.ContestLog.OrderByDescending(y => y.Value))
            {
                Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
            }
        }
    }
}

