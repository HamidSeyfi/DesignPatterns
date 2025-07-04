namespace DesignPatterns.Structural.Composite.Composite2
{
    public interface Resource
    {
        void Deploy();
    }

    public class Team : Resource
    {
        private List<Resource> _resouces = new();

        public void Add(Resource resouce)
        {
            _resouces.Add(resouce);
        }
        public void Deploy()
        {
            Console.WriteLine("Team Deploy");
            foreach (var item in _resouces)
            {
                item.Deploy();
            }
        }
    }

    public class Human : Resource
    {
        public void Deploy()
        {
            Console.WriteLine("Human Deploy");
        }
    }

    public class Truck : Resource
    {
        public void Deploy()
        {
            Console.WriteLine("Truck Deploy");
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var team1 = new Team();
            team1.Add(new Truck());
            team1.Add(new Human());
            team1.Add(new Human());

            var team2 = new Team();
            team2.Add(new Truck());
            team2.Add(new Human());
            team2.Add(new Human());

            var team3 = new Team();
            team3.Add(team1);
            team3.Add(team2);
            team3.Deploy();
        }
    }
}
