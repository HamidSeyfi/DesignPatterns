namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.Behavioral.Observer.Observer1.Clinet client = new();

            client.Operate();

            Console.Read();
        }
    }


}
