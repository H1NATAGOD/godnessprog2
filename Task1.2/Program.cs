using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool answer = false;
            int[] numb1 = new int[] { 1, 2, 3, 4 };
            int[] numb2 = new int[] { 1,1,1,3,3,4,3, 2, 4,2 };
            int[] numb3 = new int[] { 1, 2, 3, 1 };
            
            Array.Sort(numb1);
            Array.Sort(numb2);
            Array.Sort(numb3);

            for (int i = 0; i < numb1.Length - 1; i++)
            {
                if (numb1[i] == numb1[i + 1])
                {
                    answer = true;
                    break;
                }
                else
                {
                    answer = false;
                }
            }
            Console.WriteLine(answer);
            
            
            for (int i = 0; i < numb2.Length - 1; i++)
            {
                if (numb2[i] == numb2[i + 1])
                {
                    answer = true;
                    break;
                }
                else
                {
                    answer = false;
                }
            }
            Console.WriteLine(answer);
            for (int i = 0; i < numb3.Length - 1; i++)
            {
                if (numb3[i] == numb3[i + 1])
                {
                    answer = true;
                    break;
                }
                else
                {
                    answer = false;
                }
            }
            Console.WriteLine(answer);
        }
    }
}