using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Composite03
{
    public interface IComponent
    {
        void Execute();
    }

    public class Leaf : IComponent
    {
        public void Execute()
        {
            Console.WriteLine($"Do the real work");
        }
    }

    public class Composite : IComponent
    {
        private List<IComponent> components = new();        

        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public void Remove(IComponent component)
        {
            components.Remove(component);
        }

        public void Execute()
        {
            foreach (IComponent component in components)
            {
                component.Execute();
            }

        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var root = new Composite();

            var leaf1 = new Leaf();
            root.Add(leaf1);

            var composite = new Composite();
            composite.Add(new Leaf());
            composite.Add(new Leaf());
            root.Add(composite);


            root.Execute();

        }
    }
}
