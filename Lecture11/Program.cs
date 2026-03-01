// See https://aka.ms/new-console-template for more information

using Lecture11;
//Console.WriteLine("default directory: " + Environment.CurrentDirectory);
using System.Text.Json;
using FileSystem;

Player playerFromBinary = new Player();
Player player2FromBinary = new Player();

FileSystemClass ourFS = new FileSystemClass();

string path = "..\\..\\..\\SaveFiles\\OurSaveFile.sav";
BinaryReader binaryReader = ourFS.ReadToBinaryFile(path);

using (binaryReader)
{
    playerFromBinary.health = binaryReader.ReadInt32();
    player2FromBinary.health = binaryReader.ReadInt32();
    playerFromBinary.item = new Item {Type = (ItemType)binaryReader.ReadInt32()};
}

#warning "This is my own error"

/*
Item itm1 = new Item { Type = ItemType.Staff, description = "do cool magic tricks" };
Player p1 = new Player { name = "Denis", health = 200, item = itm1 };

Item itm2 = new Item { Type = ItemType.Stick, description = "think it looks cool" };
Player p2 = new Player{ name = "Dan", health = 2, item = itm2 };

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





string p1Serialized = JsonSerializer.Serialize(p1);
string p2Serialized = JsonSerializer.Serialize(p2);

File.Delete(path);
File.WriteAllText(path, p1Serialized);


*/
/*string serializedPlayer = File.ReadAllText(path);
Console.WriteLine(serializedPlayer);
Player playerFromFile = JsonSerializer.Deserialize<Player>(serializedPlayer);
Console.ReadLine();
*/





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