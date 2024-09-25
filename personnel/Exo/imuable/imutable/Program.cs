using System.Linq;

// 4 players
List<Player> players = new List<Player>()
{
    new Player("Joe", 32),
    new Player("Jack", 30),
    new Player("William", 37),
    new Player("Averell", 25)
};

/*// Initialize search
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
*/

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
}