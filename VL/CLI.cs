namespace AccountsManagerApp.VL;

public static class CLI
{
    private static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ResetColor();
    }
    private static void PrintLine(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void PrintInfo(string message)
    {
        PrintLine(message, ConsoleColor.Blue);
    }
    public static void PrintWarning(string message)
    {
        PrintLine(message, ConsoleColor.Yellow);
    }
    public static void PrintError(string message)
    {
        PrintLine(message, ConsoleColor.Red);
    }
    public static void PrintSuccess(string message)
    {
        PrintLine(message, ConsoleColor.Green);
    }

    public static string InputString(string message)
    {
        Print(message, ConsoleColor.Cyan);
        return Console.ReadLine();
    }
}