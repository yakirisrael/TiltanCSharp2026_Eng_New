// See https://aka.ms/new-console-template for more information


string input = Console.ReadLine();
if (Validate(input))
    Console.WriteLine("valid");
bool Validate(string str)
{
    int MaxLength = 20;

    bool result = true;
    
    if (str.Length > MaxLength)
    {
        Console.WriteLine($"{str} is too long");
        result = false;
    }

    if (!IsASCIILetter(str, out char invalidChar))
    {
        Console.WriteLine($"{invalidChar} is not ASCII");
        result = false;
    }

    return result;
}

bool IsASCIILetter(string str, out char invalidChar)
{
    invalidChar = ' ';
    
    foreach (char c in str)
    {
        if (!IsLowerCase(c) && !IsUpperCase(c))
        {
            invalidChar = c;
            return false;
        }
    }
    return true;
}

bool IsUpperCase(char c)
{
    return (c >= 'A' && c <= 'Z');
}
bool IsLowerCase(char c)
{
    return (c >= 'a' && c <= 'z');
}