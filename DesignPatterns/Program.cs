using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Command.Command3;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Test.Command2;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Command3Client client = new();
            
            client.Operate();

            Console.Read();
        }
    }


}
