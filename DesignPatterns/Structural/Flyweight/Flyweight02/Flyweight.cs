namespace DesignPatterns.Structural.Flyweight.Flyweight02
{
    public class Flyweight
    {
        private readonly string repeatingState;

        public Flyweight(string repeatingState)
        {
            this.repeatingState = repeatingState;
        }

        public void Operation(string uniqeState)
        {
            Console.WriteLine($"{repeatingState}{uniqeState}");
        }
    }

    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweightList = new Dictionary<string, Flyweight>();

        public Flyweight GetFlyweight(string repeatingState)
        {
            if (!flyweightList.ContainsKey(repeatingState))
            {
                flyweightList.Add(repeatingState, new Flyweight(repeatingState));
            }

            return flyweightList[repeatingState];
        }
    }

    public class Context
    {
        private readonly string uniqeIndex;
        private readonly Flyweight flyweight;

        public Context(string repeatingState, string uniqeIndex)
        {
            this.uniqeIndex = uniqeIndex;
            flyweight = new FlyweightFactory().GetFlyweight(repeatingState);//creting factory every time is not good
        }

        public void Operation()
        {
            flyweight.Operation(uniqeIndex);
        }
    }

    public class Clinet : IClient
    {
        public void Operate()
        {
            var context = new Context("red", "1");
            var context2 = new Context("red", "1");
        }
    }
}
