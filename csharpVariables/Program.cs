namespace csharpVariables;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        // string userName = "Jhon";
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, " + userName + " ,nice to meet you.");

        // Console.WriteLine(userName);
        Console.ReadKey();
    }
}
