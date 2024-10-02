using System.Linq;
/*
// 4 players
List<Player> players = new List<Player>()
{
    new Player("Joe", 32),
    new Player("Jack", 30),
    new Player("William", 37),
    new Player("Averell", 25)
};

// Initialize search
Player elder = players.First();
int biggestAge = elder.Age;

// search
foreach (Player d in players)
{
    if (d.Age > biggestAge) // memorize new elder
    {
        elder = d;
        biggestAge = d.Age; // for future loops
    }
}


Player p = players.OrderBy(p => p.Age).Last();
Console.WriteLine($"Le plus agé est {p.Name} qui a {p.Age} ans");

Console.ReadKey();


public class Player
{
    private readonly string _name;
    private readonly int _age;

    public Player(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string Name => _name;

    public int Age => _age;
}*/


using System;
using System.Threading;

class Program
{
    static int linesOfCode = 9210;
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine($"Opening shop with {linesOfCode} lines in our program");
        Thread thread1 = new Thread(Bob);
        Thread thread2 = new Thread(Alice);

        // Start both threads
        thread1.Start();
        Thread.Sleep(300); // Alice starts her day a bit later
        thread2.Start();

        // Wait until both threads terminate
        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Closing shop with {linesOfCode} lines in our program");
        Console.ReadLine();
    }
    public static int push(int lineOfCode,int editedLine)
    {
        lineOfCode += editedLine;
        return lineOfCode;
    }
    static int Bob()
    {
        int myLineCounter = 0; // Bob starts working
        int workingHours = 0;

        while (workingHours < 9) // He has a 9-hours day ahead of him
        {
            Thread.Sleep(1000); // Bob works for "1 hour"
            workingHours++;
            int BobProduction = random.Next(10, 50);
            Console.WriteLine($"Bob commits {BobProduction} lines of code.");
            myLineCounter += BobProduction;
        }
        //linesOfCode = push(linesOfCode, myLineCounter);
        Console.WriteLine($"Bob checks out, he claims the program has now {linesOfCode + myLineCounter} lines");
        return myLineCounter;
    }

    // Method to be executed by thread2 - increments by 2 every 3 seconds
    static int Alice()
    {
        int myLineCounter = 0; // Alice starts working
        int workingHours = 0;
        while (workingHours < 7) // She has a 7-hours day ahead of her
        {
            Thread.Sleep(1000); // Alice works for "1 hour"
            workingHours++;
            int AliceProduction = random.Next(20, 80);
            Console.WriteLine($"Alice commits {AliceProduction} lines of code.");
            myLineCounter += AliceProduction;
        }
        //linesOfCode = push(linesOfCode, myLineCounter);
        Console.WriteLine($"Bob checks out, he claims the program has now {linesOfCode + myLineCounter} lines");
        return myLineCounter;
    }
}
