// See https://aka.ms/new-console-template for more information

string[][] arrayItems = new string[2][] 
{
    new string[]{ "I", "Decide", "On", "It"},
    new string[]{ "Different", "Size"}
};

foreach (var items in arrayItems)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    } 
    
}

/*
Queue<int> numbers = new Queue<int>();

Console.WriteLine("Count: " + numbers.Count);
numbers.Enqueue(100);
numbers.Enqueue(-20);
numbers.Enqueue(50);

Console.WriteLine("Count: " + numbers.Count);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

var top = numbers.Peek();
Console.WriteLine("Top: " + top);

Console.WriteLine("Count: " + numbers.Count);

Console.WriteLine("Start dequeue");
while (numbers.Count > 0)
{
    numbers.Dequeue();
}
Console.WriteLine("Count: " + numbers.Count);

*/