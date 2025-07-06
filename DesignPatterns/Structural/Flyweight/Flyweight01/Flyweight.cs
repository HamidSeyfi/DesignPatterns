namespace DesignPatterns.Structural.Flyweight.Flyweight01
{
    public interface ISoldier
    {
        void Render(int x, int y);
    }

    public class Soldier01 : ISoldier
    {
        private readonly string color;
        private readonly string type;

        public Soldier01(string color, string type)
        {
            this.color = color;
            this.type = type;
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"solider {color} {type} {x} {y}");
        }
    }

    public class SoldierFactory
    {
        private Dictionary<string, ISoldier> soldiers = new Dictionary<string, ISoldier>();
        public ISoldier Create(string color, string type)
        {
            var uniqeKey = $"{color}{type}";

            if (soldiers.ContainsKey(uniqeKey))
            {
                return soldiers[uniqeKey];
            }
            else
            {
                ISoldier soldier = new Soldier01(color, type);
                soldiers.Add(uniqeKey, soldier);
                return soldier;
            }
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            SoldierFactory soldierFactory = new();


            var soldiers = new List<ISoldier>();
            soldiers.Add(soldierFactory.Create("red", "01"));
            soldiers.Add(soldierFactory.Create("red", "01"));
            soldiers.Add(soldierFactory.Create("yellow", "02"));

            foreach (var soldier in soldiers)
            {
                soldier.Render(1, 2);
            }
        }
    }
}