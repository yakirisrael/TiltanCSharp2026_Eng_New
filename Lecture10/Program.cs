// See https://aka.ms/new-console-template for more information


Dictionary<int, Dictionary<string, string>> Dialogues = new ();
Dialogues[100] = new();
Dialogues[100]["English"] = "One";
Dialogues[100]["Japanese"] = "Eich";
Dialogues[101] = new();
Dialogues[101]["English"] = "Two";
Dialogues[101]["Japanese"] = "Ni";

if (Dialogues.ContainsKey(101))
{
    Console.WriteLine(Dialogues[101]["English"]);
    Console.WriteLine(Dialogues[101]["Japanese"]);
}


Dictionary<E_Weapon, int> weaponsAmount = new Dictionary<E_Weapon, int>();
weaponsAmount[E_Weapon.Sword] = 1000;
weaponsAmount[E_Weapon.BareHands] = 3;
weaponsAmount[E_Weapon.Axe] = 0;

//Console.WriteLine(weaponsAmount[E_Weapon.BareHands]);

HashSet<string> names = new HashSet<string>();
names.Add("Yakir");
names.Add("Batchen");
names.Add("Yakir");
//Console.WriteLine(names.Count);
names.Remove("Yakir");
//Console.WriteLine(names.Contains("Yakir"));

public enum E_Weapon
{
    BareHands,
    Axe,
    Sword,
}


struct Data
{
    public int x;
    public int y;
    
    
}
/*

LinkedList<Player> players = new LinkedList<Player>();
players.AddLast(new Player("Dan", E_Weapon.Sword));
players.AddLast(new Player("Denis", E_Weapon.Axe));



string nameToCheck = "Dan";

Player.RemovePlayer(players, nameToCheck);

string name = players.First.Value.GetInfo().name;
string nextName = players.First.Previous.Value.GetInfo().name;


foreach (var player in players)
{
    Console.WriteLine("name = " + player.GetInfo().name +
                      " weapon = " + player.GetInfo().weapon); 
}

Console.WriteLine("Count: " + players.Count);



public struct PlayerData
{
    public string name;
    public E_Weapon weapon;
}

class Player
{
    PlayerData data = new PlayerData();
    public  Player(string name, E_Weapon weapon)
    {
        this.data.name = name;
        this.data.weapon = weapon;
    }

    public PlayerData GetInfo()
    {
        return data;
    }
    
    public static Player FindPlayer(LinkedList<Player> players, string name)
    {
        foreach (var player in players)
        {
            if (player.GetInfo().name == name)
                return player;
        }
        return null;
    }
    
    public static void RemovePlayer(LinkedList<Player> players, string name)
    {
        Player p =  FindPlayer(players, name); // O(n)
        
        // if found player, then remove it
        if (p != null)
            players.Remove(p); // O(1)

    }


}
*/