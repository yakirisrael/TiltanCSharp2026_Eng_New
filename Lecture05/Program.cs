// See https://aka.ms/new-console-template for more information


float[] scores = { 123.2f};

string[] result = CreateArray();
PrintArray(result);

string[] CreateArray()
{
    string[] localVar = {"Hello ", "My ", "Friends!"};
    return localVar;
}

void PrintArray(string[] AnyName)
{
    foreach (string name in AnyName)
    {
        Console.Write(name);
    }

   /* for (int i = 0; i < AnyName.Length; i++)
    {
        Console.Write(AnyName[i]);
    }*/

}