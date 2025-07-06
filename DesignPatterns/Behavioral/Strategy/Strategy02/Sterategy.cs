namespace DesignPatterns.Behavioral.Strategy.Strategy02
{
    public class SterategyClient : IClient
    {
        public void Operate()
        {
            var sterategy = new Sterategy1();
            var context = new SterategyContext();
            context.SetSterategy(sterategy);
            context.Execute();
        }
    }

    public interface ISterategy
    {
        void Execute();
    }

    public class Sterategy1 : ISterategy
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class SterategyContext
    {
        public ISterategy Sterategy { get; set; }

        public void SetSterategy(ISterategy sterategy)
        {
            Sterategy = sterategy;
        }

        public void Execute()
        {
            Sterategy.Execute();
        }
    }
}
