using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento.Memento5
{
    public class Originator
    {
        private string _state;

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
            _state = ((Memento)memento).GetState();
        }


        public interface IMemento { }

        private class Memento : IMemento
        {
            private string _state;

            public Memento(string state)
            {
                _state = state;
            }

            public string GetState()
            {
                return _state;
            }
        }

    }

    public class CareTaker
    {
        private Stack<Originator.IMemento> _mementos { get; set; }

        public void Push(Originator.IMemento memento)
        {
            _mementos.Push(memento);
        }

        public Originator.IMemento Pop()
        {
            return _mementos.Pop();
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

            originator.SetState("Ali");
            careTaker.Push(originator.Save());

            originator.Restore(careTaker.Pop());
        }
    }
}
