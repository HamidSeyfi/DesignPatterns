using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.Flyweight03
{
    public class Flyweight
    {
        private readonly string repeating;

        public Flyweight(string repeating)
        {
            this.repeating = repeating;
        }

        public void Operation(string unique)
        {
            Console.WriteLine($"{repeating} {unique}");
        }
    }

    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights = new();

        public Flyweight Get(string repeating)
        {
            if (!flyweights.ContainsKey(repeating))
            {
                flyweights.Add(repeating, new Flyweight(repeating));
            }
            return flyweights[repeating];
        }

        
    }

    public class Context
    {
        private Flyweight flyweight;
        private readonly string uniqe;

        public Context(string repeating, string uniqe, FlyweightFactory flyweightFactory)
        {
            this.uniqe = uniqe;
            flyweight = flyweightFactory.Get(repeating);
        }        

        public void Operation ()
        {
            flyweight.Operation(uniqe);
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            FlyweightFactory fyweightFactory = new();

            var context01 = new Context("01", "01", fyweightFactory);
            var context02 = new Context("01", "02", fyweightFactory);
            var context03 = new Context("02", "03", fyweightFactory);

            context01.Operation();
            context02.Operation();
            context03.Operation();
        }
    }
}
