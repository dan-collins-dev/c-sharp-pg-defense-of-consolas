namespace TheDefenseOfConsolas;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "The Defense of Consolas";
        // Console.BackgroundColor = ConsoleColor.DarkRed;
        // Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("The Uncoded One is attacking!\n");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Console.Write("Which row of the city is the Uncoded One attacking: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Which column of the city is the Uncoded One attacking: ");
        int column = Convert.ToInt32(Console.ReadLine());


        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Deploying squads to the following coordinates:");
        Console.WriteLine($"({row}, {column - 1})");
        Console.WriteLine($"({row - 1}, {column})");
        Console.WriteLine($"({row}, {column + 1})");
        Console.WriteLine($"({row + 1}, {column})");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Beep();
    }
}
