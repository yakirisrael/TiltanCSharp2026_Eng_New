// See https://aka.ms/new-console-template for more information


//Console.WriteLine("default directory: " + Environment.CurrentDirectory);

using System.Text.Json;

string path = "..\\..\\..\\SaveFiles\\OurSaveFile.sav";


Item itm1 = new Item { Type = ItemType.Staff, description = "do cool magic tricks" };
Player p1 = new Player { name = "Denis", health = 200, item = itm1 };

Item itm2 = new Item { Type = ItemType.Stick, description = "think it looks cool" };
Player p2 = new Player{ name = "Dan", health = 2, item = itm2 };

/*
FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
using (fs)
{
    BinaryWriter bw = new BinaryWriter(fs);
    using (bw)
    {
        bw.Write(p1.health);
        bw.Write(p2.health);
        bw.Write((int)p1.item.Type);
    }
}


*/


//string p1Serialized = JsonSerializer.Serialize(p1);
//string p2Serialized = JsonSerializer.Serialize(p2);

//File.Delete(path);
//File.WriteAllText(path, p1Serialized);


//File.AppendAllText(path, "," + p2Serialized);

/*string serializedPlayer = File.ReadAllText(path);
Console.WriteLine(serializedPlayer);
Player playerFromFile = JsonSerializer.Deserialize<Player>(serializedPlayer);
Console.ReadLine();
*/
FileStream fs = null;

try
{
    Player playerFromBinary = new Player();
    Player player2FromBinary = new Player();
    
    fs = new FileStream(path, FileMode.Open);
    using (fs)
    {
        BinaryReader br = new BinaryReader(fs);
        using (br)
        {
            playerFromBinary.health = br.ReadInt32();
            player2FromBinary.health = br.ReadInt32();
            playerFromBinary.item = new Item {Type = (ItemType)br.ReadInt32()};
        }
    }

}
catch (Exception e)
{
   // Console.WriteLine(e.Message);
   if (fs != null)
   {
       Console.WriteLine("Corrupted file, closing");
       fs.Close();
   }
   else // null - file not found
   {
       //Console.WriteLine("Missing file");
       throw new IOException("Missing File");
   }
   
}
enum ItemType
{
    Axe,
    Bow,
    Staff,
    Stick,
    Sword,
}

class Item
{
    public ItemType Type { get; set; }
    public string description { get; set; }
}

class Player
{
    public string name { get; set; }
    public int health { get; set; }
    public Item item { get; set; }
}

/*
string content = "This is our awesome description";

Console.WriteLine("Writing to path: " + path);
//File.WriteAllText(path, content);
//File.AppendAllText(path, " Keep writing....");

string[] readFromFile = File.ReadAllLines(path);

foreach (var line in readFromFile)
{
    Console.WriteLine(line);
}
*/