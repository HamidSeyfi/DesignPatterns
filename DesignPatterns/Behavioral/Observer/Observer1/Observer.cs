using DesignPatterns.Behavioral.Memento.Memento1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Observer1
{
    public interface IObserver
    {
        void Update();
    }


    public class ConceretObserver1 : IObserver
    {
        private readonly ConvereteSubjet convereteSubjet;

        public ConceretObserver1(ConvereteSubjet convereteSubjet)
        {
            this.convereteSubjet = convereteSubjet;
        }
        public void Update()
        {
            Console.WriteLine(nameof(ConceretObserver1));
        }
    }

    public abstract class Subject
    {
        public List<IObserver> Observers { get; set; } = new();
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.Update();
            }
        }
    }

    public class ConvereteSubjet : Subject
    {
        public void DoSomething()
        {
            Console.WriteLine(nameof(DoSomething));
            Notify();
        }
    }

    public class Clinet : IClient
    {
        public void Operate()
        {
            var converetSubber = new ConvereteSubjet();
            converetSubber.AddObserver(new ConceretObserver1(converetSubber));
            converetSubber.DoSomething();
        }
    }
}
