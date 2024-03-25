using System;
using System.Text.RegularExpressions;
public static class Program 
{
    public static void Main(string[] args)
    {
        string texto = "[ERROR]: File not Found";
        string partMessage = texto.Substring(texto.IndexOf(":")+1);
        Console.WriteLine($"Message Expected: {partMessage}");
    }
}