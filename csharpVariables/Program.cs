namespace csharpVariables;

class Program
{
    static void Main(string[] args)
    {
        #region 
        



        Console.WriteLine("What is your name?");
        // string userName = "Jhon";
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, " + userName + " ,nice to meet you.");

        // Console.WriteLine(userName);

        #endregion
        System.Console.Write("input a  number:");
        int num1 = Convert.ToInt32(Console.ReadLine()); 
        System.Console.WriteLine("input second number:"); 
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result = num1 + num2;
        Console.Write("The result is: " + result);
        Console.ReadKey();


    }
}
