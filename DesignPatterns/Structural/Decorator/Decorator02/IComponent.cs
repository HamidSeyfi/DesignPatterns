using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Decorator02
{
    public interface IComponent
    {
        void Execute();
    }

    public class Component1 : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("Component1");
        }
    }

    public abstract class BaseDecorator : IComponent
    {
        private IComponent _component;

        protected BaseDecorator(IComponent component)
        {
            _component = component;
        }

        public virtual void Execute()
        {
            _component.Execute();
        }


    }

    public class BaseDecorator1 : BaseDecorator
    {
        public BaseDecorator1(IComponent component) : base(component)
        {

        }
        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("BaseDecorator1");
        }
    }

    public class BaseDecorator2 : BaseDecorator
    {
        public BaseDecorator2(IComponent component) : base(component)
        {

        }
        public override void Execute()
        {

            base.Execute();
            Console.WriteLine("BaseDecorator2");
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            IComponent component = new Component1();
            var decorator1 = new BaseDecorator1(component);
            var decorator2 = new BaseDecorator2(decorator1);
            decorator2.Execute();
        }
    }
}
