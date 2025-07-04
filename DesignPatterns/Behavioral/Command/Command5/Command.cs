namespace DesignPatterns.Behavioral.Command.Command5
{
    public class Invoker
    {
        private readonly ICommand _command;

        public Invoker(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class Command1 : ICommand
    {
        private readonly Receiver _receiver;

        public Command1(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.DoTheRealJob();
        }
    }

    public class Receiver
    {
        public void DoTheRealJob()
        {
            Console.WriteLine("Doing the real job");
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var receiver = new Receiver();
            var command = new Command1(receiver);
            var invoker = new Invoker(command);
            invoker.ExecuteCommand();
        }
    }
}
