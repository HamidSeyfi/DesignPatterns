using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Adapter02
{
    public interface IAdapter
    {
        void Execute();
    }

    public class Adapter : IAdapter
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public void Execute()
        {            
            adaptee.DoTheRealWork();
        }
    }

    public class Adaptee
    {
        public void DoTheRealWork()
        {
            Console.WriteLine("Do The Real Work");
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            IAdapter adapter = new Adapter(new Adaptee());
            adapter.Execute();
        }
    }
}
