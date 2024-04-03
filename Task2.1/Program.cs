using System;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student Sam = new Student();
            Sam.surname = "Porter";
            Sam.datebirth = new DateTime(2005, 12, 3);
            Sam.performance = new int[] { 4, 5, 3, 4, 4 };
            Sam.group = 253;

            int func = Int32.Parse(Console.ReadLine());
            switch (func)
            {
                case 1:
                    Console.WriteLine($" {Sam.surname} {Sam.group} {Sam.datebirth}");
                    break;
                case 2:
                    Sam.surname = Console.ReadLine();
                    Sam.datebirth = DateTime.Parse(Console.ReadLine());
                    for (int i = 0; i < 5; i++)
                    {
                        Sam.performance[i] = Int32.Parse(Console.ReadLine());
                    }
                    Sam.group = int.Parse(Console.ReadLine()); 
                    Console.WriteLine($" {Sam.surname} {Sam.group} {Sam.datebirth}");
                    break;
                case 3:
                    Sam.surname = Console.ReadLine();
                    Console.WriteLine($" {Sam.surname} {Sam.group} {Sam.datebirth}");
                    break;
                case 4:
                    Sam.datebirth = DateTime.Parse(Console.ReadLine());   
                    Console.WriteLine($" {Sam.surname} {Sam.group} {Sam.datebirth}");
                    break;
                case 5:
                    Sam.group = int.Parse(Console.ReadLine()); 
                    Console.WriteLine($" {Sam.surname} {Sam.group} {Sam.datebirth}");
                    break;
                default:
                    Console.WriteLine($"Нет действия((( ну блин(((");
                    break;
            }
 
        }
    }
}