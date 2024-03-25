using System;
using System.Text.RegularExpressions;
public static class Program 
{
    public static string SubstringAfter(this string statement,string data)
    {
        string partMessage = statement.Substring(statement.IndexOf(data)+data.Length);
        return partMessage;
    }

    public static string SubstringBetween(this string statement, string first, string second)
    {
        Match part = Regex.Match(statement, $@"\{first}(.*?)\{second}");
        return part.Groups[1].Value.TrimStart();
    }
    
    
    public static string Message(this string statement)
    {
        string partMessage = statement.Substring(statement.IndexOf("]: ")+2).TrimStart();
        return partMessage;
    }
    
    public static string LogLevel(this string statement)
    {
        Match part = Regex.Match(statement, $@"\[(.*?)\]");
        return part.Groups[1].Value.TrimStart();
    }
    public static void Main(string[] args)
    {
        string statement = "[INFO]: File Deleted.";
        string name = statement.SubstringBetween("[", "]");
        string message = statement.SubstringAfter(": ");
        string message2 = statement.Message();
        string logLevel = statement.LogLevel();
        Console.WriteLine($"Data: {name}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Message2: {message2}");
        Console.WriteLine($"LogLevel: {logLevel}");
    }
}
