namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Worker walter = new Worker();
            walter.Name = "Walter";
            walter.Surname = "White";
            walter.Rate = 213;
            walter.Days = 12;
            
            walter.GetSalary();
            walter.Cout();
        }
    }
}