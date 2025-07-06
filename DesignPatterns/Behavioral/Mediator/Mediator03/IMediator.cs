namespace DesignPatterns.Behavioral.Mediator.Mediator03
{
    public interface IMediator
    {
        void Notify(IComponent component);
    }

    public class Mediator : IMediator
    {
        private readonly Component1 component1;
        private readonly Component2 component2;

        public Mediator(Component1 component1, Component2 component2)
        {
            this.component1 = component1;
            this.component1.SetMediator(this);

            this.component2 = component2;
            this.component2.SetMediator(this);
        }

        public void Notify(IComponent component)
        {
            if (component is Component1)
            {
                component2.Operation();
            }
            if (component is Component2)
            {
                component1.Operation();
            }

        }
    }

    public interface IComponent
    {
        void Operation();
        void SetMediator(IMediator mediator);
    }

    public class Component1 : IComponent
    {
        private IMediator _mediator;

        public void Operation()
        {
            Console.WriteLine("Component1 Operation");
            _mediator.Notify(this);
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

    public class Component2 : IComponent
    {
        private IMediator _mediator;

        public void Operation()
        {
            Console.WriteLine("Component2 Operation");
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {

            var component1 = new Component1();
            var component2 = new Component2();
            var mediator = new Mediator(component1, component2);

            component1.Operation();

        }
    }
}
