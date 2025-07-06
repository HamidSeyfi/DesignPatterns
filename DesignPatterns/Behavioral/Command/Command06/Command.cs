namespace DesignPatterns.Behavioral.Command.Command06
{
    public class Invoker
    {
        private readonly Stack<ICommand> _history = new();

        public void ExecuteCommand(ICommand command)
        {
            _history.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var command = _history.Pop();
                command.Undo();
            }
        }
    }

    public interface ICommand
    {
        void Execute();
        void Undo();
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
            _receiver.DoTheRealJob1();
        }

        public void Undo()
        {
            _receiver.UndoTheRealJob1();
        }
    }

    public class Command2 : ICommand
    {
        private readonly Receiver _receiver;

        public Command2(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.DoTheRealJob2();
        }

        public void Undo()
        {
            _receiver.UndoTheRealJob2();
        }
    }

    public class Receiver
    {
        public void DoTheRealJob1()
        {
            Console.WriteLine("Do the real job 1");
        }

        public void UndoTheRealJob1()
        {
            Console.WriteLine("Undo the real job 1");
        }

        public void DoTheRealJob2()
        {
            Console.WriteLine("Do the real job 2");
        }

        public void UndoTheRealJob2()
        {
            Console.WriteLine("Undo the real job 2");
        }

    }

    public class Client : IClient
    {
        public void Operate()
        {
            var receiver = new Receiver();
            var command1 = new Command1(receiver);
            var command2 = new Command2(receiver);
            var invoker = new Invoker();
            invoker.ExecuteCommand(command1);
            invoker.ExecuteCommand(command2);
            invoker.Undo();
            invoker.Undo();
        }
    }
}
