using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DesignPatterns.Behavioral.Memento.Memento2
{
    internal class MementoClient : IClient
    {
        public void Operate()
        {
            var context = new MementoContext();
            var careTaker = new CareTaker();

            context.Name = "Hamid";
            careTaker.Push(context.CreateSnapshot());


            context.Name = "Atiye";
            careTaker.Push(context.CreateSnapshot());


            context.RestoreSnapshot(careTaker.Pop());
        }
    }

    public class MementoContext
    {
        public string Name { get; set; }



        public Memento CreateSnapshot()
        {
            return new Memento(Name);
        }

        public void RestoreSnapshot(Memento memento)
        {
            Name = memento.Name;
        }
    }

    public class Memento
    {
        public Memento(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }

    public class CareTaker
    {
        public Stack<Memento> Mementos { get; set; }

        public void Push(Memento memento)
        {
            Mementos.Push(memento);
        }

        public Memento Pop()
        {
            return Mementos.Pop();
        }
    }



}
