using System;

namespace ConsoleApplication1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int count = 0;
      string j = Console.ReadLine();
      string s = Console.ReadLine();
   
      foreach(char stone in s)
      {
        foreach(char diamond in j)
        {
          if(stone == diamond)
          {
            count++;
          }    
        }    
      }
      Console.WriteLine(count);
    }
  }
}