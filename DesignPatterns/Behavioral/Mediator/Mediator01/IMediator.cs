namespace DesignPatterns.Behavioral.Mediator.Mediator01
{
    public class MediatorClient : IClient
    {
        public void Operate()
        {
            var mediator = new Mediator();

            var componet1 = new Component1();
            componet1.SetMediator(mediator);

            var componet2 = new Component2();
            componet1.SetMediator(mediator);


            componet1.SomeOperation();

        }
    }

    public interface IMediator
    {
        void Notify(Component component, string message);
    }

    public class Mediator : IMediator
    {

        public void Notify(Component component, string message)
        {
            if (component.GetType() == typeof(Component1))
            {
                C1Operation();
            }

            if (component.GetType() == typeof(Component2))
            {
                C2Operation();
            }
        }

        public void C1Operation()
        {

        }

        public void C2Operation()
        {

        }
    }

    public abstract class Component
    {
        protected Mediator Mediator;
        public void SetMediator(Mediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void SomeOperation();
    }

    public class Component1 : Component
    {
        public override void SomeOperation()
        {
            Mediator.Notify(this, nameof(Component1));
        }
    }

    public class Component2 : Component
    {
        public override void SomeOperation()
        {
            Mediator.Notify(this, nameof(Component2));
        }
    }
}
