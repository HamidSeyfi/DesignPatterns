namespace DesignPatterns.Behavioral.ChainOfResponsibility.ChainOfResponsibility01
{
    public class Client : IClient
    {
        public void Operate()
        {
            throw new NotImplementedException();

            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var auth = new Auth(logger);
        }
    }

    public abstract class Handler
    {
        private readonly Handler handler;

        protected Handler(Handler handler)
        {
            this.handler = handler;
        }

        public void Handle(HttpRequest httpRequest)
        {
            if (!DoHandle(httpRequest))
            {
                return;
            }

            if (handler != null)
            {
                handler.Handle(httpRequest);
            }
        }

        public abstract bool DoHandle(HttpRequest httpRequest);
    }

    public class HttpRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Auth : Handler
    {
        public Auth(Handler handler) : base(handler)
        {

        }
        public override bool DoHandle(HttpRequest httpRequest)
        {
            throw new NotImplementedException();
        }
    }

    public class Logger : Handler
    {
        public Logger(Handler handler) : base(handler)
        {

        }
        public override bool DoHandle(HttpRequest httpRequest)
        {
            throw new NotImplementedException();
        }
    }

    public class Compressor : Handler
    {
        public Compressor(Handler handler) : base(handler)
        {

        }
        public override bool DoHandle(HttpRequest httpRequest)
        {
            throw new NotImplementedException();
        }
    }
}
