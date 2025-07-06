namespace DesignPatterns.Structural.Bridge.Bridge01
{
    public interface IDrawer //Implementor
    {
        void Draw();
    }

    public class WindowsDrawer : IDrawer //ConcreteImplementor
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Shape //Abstraction
    {
        protected IDrawer _drawer;

        protected Shape(IDrawer drawer)
        {
            _drawer = drawer;
        }

        public abstract void Draw();
    }

    public class Circle : Shape //RefindedAbstraction
    {
        public Circle(IDrawer drawer) : base(drawer)
        {

        }

        public override void Draw()
        {
            _drawer.Draw();
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            IDrawer drawer = new WindowsDrawer();
            Shape circle = new Circle(drawer);
            circle.Draw();
        }
    }
}
