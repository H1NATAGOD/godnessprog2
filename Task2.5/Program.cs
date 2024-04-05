using System;
using ConsoleApplication8;

internal class Program
{
    public static void Main(string[] args)
    {
        Client hinata = new Client();
        Console.WriteLine($"Имя: {hinata.Name}, возраст: {hinata.Age}");
        Client sakura= new Client("Sakura");
        Console.WriteLine($"Имя: {sakura.Name}, возраст: {sakura.Age}");
        Client itaci = new Client("Itaci", 10000);
        Console.WriteLine($"Имя: {itaci.Name}, возраст: {itaci.Age}");
       
       
    }
}

