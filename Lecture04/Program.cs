// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();

float inputFloat;
bool succeed = float.TryParse(input, out inputFloat);

do
{
    succeed = float.TryParse(input, out inputFloat);
    
    if (succeed)
    {
        Console.WriteLine("Correct value: " + inputFloat);
    }
    else
    {

        Console.WriteLine("invalid value, try again");
        input = Console.ReadLine();
        
    }
} while (!succeed);

/*
void SayMessage(string message, string userName)
{
    Console.WriteLine(message + ":" +  userName);
}

SayMessage("Hello", "David");
SayMessage("Bye", "David");
SayMessage("Hello", "Yakir");

void Multiply(out double x, double y)
{
    x = 10;
    x *= y;
}

double x;
double y = 30;
Multiply(out x, y);
Console.WriteLine(x);
*/