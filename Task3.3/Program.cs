using System;

namespace ConsoleApplication11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculation calc = new Calculation("Что-то то");
            calc.SetCalculationLine("Проверочная строка");
            Console.WriteLine($"Установка значения: {calc.GetCalculationLine()}");
            calc.SetLastSymbolCalculationLine('!');
            Console.WriteLine($"Прибавление последнего символа: {calc.GetCalculationLine()}");
            Console.WriteLine($"Получение последнего символа: {calc.GetLastSymbol()}");
            calc.DeleteLastSymbol();
            Console.WriteLine($"Удаление последнего символа: {calc.GetCalculationLine()}");
            
        }
    }
}