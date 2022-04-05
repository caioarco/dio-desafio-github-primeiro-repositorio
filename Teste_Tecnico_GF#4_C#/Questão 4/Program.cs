class Program
{
    static void Main()
    {
        string a = "";
        Console.WriteLine("Digite uma letra");
        a = Console.ReadLine().ToLower();
        if (a == "a") Console.WriteLine("É vogal");
        else if (a == "e") Console.WriteLine("É vogal");
        else if (a == "i") Console.WriteLine("É vogal");
        else if (a == "o") Console.WriteLine("É vogal");
        else if (a == "u") Console.WriteLine("É vogal");
        else Console.WriteLine("é consoante ");   
    }
}
