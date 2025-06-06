using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Observer2
{
    public interface IObserver
    {
        void Update(object model);
    }

    public class ConObserver1 : IObserver
    {
        public void Update(object model)
        {
            Console.WriteLine(nameof(ConObserver1));
        }
    }


    public abstract class Subject
    {
        public List<IObserver> Observers { get; set; }
        public void AddObserver(IObserver observer) { }
        public void RemoveObserver(IObserver observer) { }
        public void Norify(object model)
        {
            foreach (var item in Observers)
            {
                item.Update(model);
            }
        }
    }

    public  class CovSubjet : Subject
    {
        void AddSomething()
        {
            //...
            Norify(this);
        }
    }
}
