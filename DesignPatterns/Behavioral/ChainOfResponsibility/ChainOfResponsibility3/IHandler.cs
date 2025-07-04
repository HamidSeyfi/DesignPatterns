namespace DesignPatterns.Behavioral.ChainOfResponsibility.ChainOfResponsibility3
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void Handle(object request);
    }

    public class Handler1 : IHandler
    {
        private IHandler _next;

        public void Handle(object request)
        {
            Console.WriteLine("Handler1 Doing business");

            if (_next != null)
            {
                _next.Handle(request);
            }
        }

        public void SetNext(IHandler handler)
        {
            _next = handler;
        }
    }

    public class Handler2 : IHandler
    {
        private IHandler _next;

        public void Handle(object request)
        {
            Console.WriteLine("Handler2 Doing business");

            if (_next != null)
            {
                _next.Handle(request);
            }
        }

        public void SetNext(IHandler handler)
        {
            _next = handler;
        }
    }

    public class Handler3 : IHandler
    {
        private IHandler _next;

        public void Handle(object request)
        {
            Console.WriteLine("Handler3 Doing business");

            if (_next != null)
            {
                _next.Handle(request);
            }
        }

        public void SetNext(IHandler handler)
        {
            _next = handler;
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var handler1 = new Handler1();
            var handler2 = new Handler2();
            var handler3 = new Handler3();

            handler1.SetNext(handler2);
            handler2.SetNext(handler3);

            handler1.Handle(new { });
        }
    }
}
