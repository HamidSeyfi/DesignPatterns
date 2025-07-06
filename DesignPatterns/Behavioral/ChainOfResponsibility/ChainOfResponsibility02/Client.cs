namespace DesignPatterns.Behavioral.ChainOfResponsibility.ChainOfResponsibility02
{
    public class Client
    {
    }

    public class HttpRequest
    {
        public string Name { get; set; }
    }

    public interface IHandler
    {
        public void SetHandler(IHandler handler);
        public void Handle(HttpRequest httpRequest);
    }

    public abstract class Handler : IHandler
    {
        protected IHandler _handler;

        public virtual void Handle(HttpRequest httpRequest)
        {
            if (_handler != null)
            {
                _handler.Handle(httpRequest);
            }

        }

        public void SetHandler(IHandler handler)
        {
            _handler = handler;
        }
    }

    public class MonkeyHandler : Handler
    {
        public override void Handle(HttpRequest httpRequest)
        {
            if (httpRequest.Name == "Hamid")
            {
                //do someThing
            }
            else
            {
                base.Handle(httpRequest);
            }
        }
    }


}
