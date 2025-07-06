namespace DesignPatterns.Structural.Proxy.Proxy01
{
    public interface ISubject
    {
        void DoAction();
    }

    public class RealObject : ISubject
    {
        public void DoAction()
        {
            Console.WriteLine("Do the real work");
        }
    }

    public class Proxy : ISubject
    {
        private RealObject _realObject;

        public void DoAction()
        {
            //do extra things like log,cache,checking access, ...

            if (_realObject == null)
            {
                _realObject = new RealObject();
            }
            _realObject.DoAction();
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            ISubject subject = new Proxy();
            subject.DoAction();
        }
    }
}
