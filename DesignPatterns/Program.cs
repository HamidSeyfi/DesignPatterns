namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.Structural.Proxy.Proxy01.Client client = new();

            client.Operate();

            Console.Read();
        }
    }


}
