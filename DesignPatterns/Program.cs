namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.Structural.Adapter.Adapter02.Client client = new();

            client.Operate();

            Console.Read();
        }
    }
}
