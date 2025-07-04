using DesignPatterns.Behavioral.Command.Command6;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.Structural.Composite.Composite2.Client client = new();

            client.Operate();

            Console.Read();
        }
    }


}
