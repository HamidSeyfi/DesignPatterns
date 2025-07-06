namespace DesignPatterns.Behavioral.Memento.Memento04
{
    public class Originator
    {
        public string _state { get; set; }


        public void SetState(string state)
        {
            _state = state;
        }

        public IMemento Save()
        {
            return new Memento(_state);
        }

        public void Restore(IMemento memento)
        {
            _state = ((Memento)memento).State;
        }

        public interface IMemento
        {

        }

        private class Memento : IMemento
        {
            public string State;

            public Memento(string state)
            {
                state = state;
            }
        }
    }

    public class CareTaker
    {
        public Stack<Originator.IMemento> mementos { get; set; }

        public void Push(Originator.IMemento memento)
        {
            mementos.Push(memento);
        }

        public Originator.IMemento Pop()
        {
            return mementos.Pop();
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var originator = new Originator();
            var careTaker = new CareTaker();

            originator.SetState("hamid");
            careTaker.Push(originator.Save());

            originator.Restore(careTaker.Pop());
        }
    }
}
