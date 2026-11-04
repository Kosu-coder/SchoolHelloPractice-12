namespace SchoolHelloPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как се казваш? ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Здравей, {name}!");
        }
    }
}
