namespace DesignPatterns.Structural.Bridge.Bridge02_Tata
{
    //Implementor
    public interface ISmsService
    {
        void Send();
    }

    //Concrete Implementor
    public class ConcreteSmsService01 : ISmsService
    {
        public void Send()
        {
            //Send Sms
        }
    }


    //Abstraction
    public abstract class UserService
    {
        protected readonly ISmsService smsService;

        protected UserService(ISmsService smsService)
        {
            this.smsService = smsService;
        }
        public abstract void RegisterUser();
    }

    public class ConcreteUserService01 : UserService
    {
        public ConcreteUserService01(ISmsService smsService) : base(smsService)
        {

        }
        public override void RegisterUser()
        {
            //RegisterUser
            smsService.Send();
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            ISmsService smsService = new ConcreteSmsService01();
            UserService userService = new ConcreteUserService01(smsService);
            userService.RegisterUser();
        }
    }
}
