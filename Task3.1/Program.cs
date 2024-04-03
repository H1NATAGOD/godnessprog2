namespace ConsoleApplication9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Worker walter = new Worker();
            walter.name = "Walter";
            walter.surmname = "White";
            walter.rate = 213;
            walter.days = 12;
            
            walter.GetSalary();
        }
    }
}