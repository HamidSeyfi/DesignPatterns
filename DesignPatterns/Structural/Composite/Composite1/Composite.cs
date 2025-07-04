using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Composite1
{
    public abstract class Component
    {
        protected string _name;

        protected Component(string name)
        {
            _name = name;
        }

        public abstract void Display(int depth);
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
    }

    public class Composite : Component
    {
        private List<Component> _components = new List<Component>();

        public Composite(string name) : base(name)
        {

        }

        public Composite(string name, Component[] components) : base(name)
        {
            foreach (var item in components)
            {
                Add(item);
            }
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
            foreach (var item in _components)
            {
                item.Display(depth + 2);
            }
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            Component component = new Composite
                  ("Root Item", new Component[]
                  {
                    new Leaf("Leaf 1"),
                    new Composite ("Composite 1",new Component[]
                    {
                        new Leaf("Leaf 1-1"),
                        new Leaf("Leaf 1-2"),
                        new Composite("Composite 1-1",new Component[]
                        {
                            new Leaf("Laef 1-1-1-"),
                            new Composite("empty Composite",new Component[]{ }),
                        })
                    }),
                    new Leaf("Leaf 2"),
                    new Leaf("Leaf 3"),
                    new Leaf("Leaf 4"),
                  });
            component.Display(1);
            Console.ReadLine();
        }
    }
}
