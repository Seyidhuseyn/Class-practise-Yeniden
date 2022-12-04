namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Melumatlari daxil edin:");

            User user = new User("fgb", "grege");

            user.Username = Console.ReadLine();
            user.Password = Console.ReadLine();
            
            Product product = new Product();
        }
    }
}