namespace DesignPatterns.Behavioral.Memento.Memento03
{
    public class Originator
    {
        private string _state;

        public IMemento Save()
        {
            return new Memento(_state);
        }

        public void Restore(IMemento memento)
        {
            if (memento is Memento concreteMemento)
            {
                _state = concreteMemento.State;
            }
        }

        public void SetState(string state)
        {
            _state = state;
        }

        public interface IMemento { }

        private class Memento : IMemento
        {
            public string State { get; }

            public Memento(string state)
            {
                State = state;
            }
        }
    }

    public class CareTaker
    {
        public Stack<Originator.IMemento> Mementos { get; set; } = new();

        public void Push(Originator.IMemento memento)
        {
            Mementos.Push(memento);
        }

        public Originator.IMemento Pop()
        {
            return Mementos.Pop();
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var originator = new Originator();
            var careTaker = new CareTaker();

            originator.SetState("Hamid");
            careTaker.Push(originator.Save());

            originator.SetState("Atena");
            careTaker.Push(originator.Save());

            originator.Restore(careTaker.Pop());
        }
    }
}
