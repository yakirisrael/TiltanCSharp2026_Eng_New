// See https://aka.ms/new-console-template for more information

Player p1 = new Player("");
Player p2 = new Player("Dana");
Player p3 = new Player(p2);
//p1.PrintId();
//p2.PrintId();
//Player.PrintGeneratedId();
//Console.WriteLine(p1.MyName);
Console.WriteLine(p2.MyName);
Console.WriteLine(p3.MyName);
p2.MyName = "Yakir";
Console.WriteLine("--------------");
Console.WriteLine(p2.MyName);
Console.WriteLine(p3.MyName);
Player p4 = p2.Copy();
Console.WriteLine($"p4 name = {p4.MyName}, id = {p4.Id}");
Console.WriteLine($"p2 name = {p2.MyName}, id = {p2.Id}");


//Player p = p1 ?? new Player("Empty");


/*
int? age = 20;
if (age.Value > 30)
    Console.WriteLine(age);
else
    Console.WriteLine("null!");
*/

class Player
{
    private string name;

    public string MyName
    {
        get;
        set;
    }

    // id per instance
    private int id;
    public int Id
    {
        get;
        set;
    }

    // shared id between all of the instances
    private static int generated_id = 100;

    public Player Copy()
    {
        return new Player(this.MyName);
    }

    public Player(Player p)
    {
        MyName = p.MyName;
        this.id = p.id;
    }

    public Player(string name)
    {
        generated_id++;
        id = generated_id;
        MyName = name;
    }

    public void PrintId()
    {
        Console.WriteLine("own id = " + id);
    }
    public static void PrintGeneratedId()
    {
        Console.WriteLine("generated id = " + generated_id);
    }
}

