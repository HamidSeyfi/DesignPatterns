namespace DesignPatterns.Structural.Adapter.Adapter01
{

    public interface ISmsService
    {
        void SendSms();
    }

    public class SmsServiceAdapter : ISmsService
    {
        public void SendSms()
        {
            var thirdPartySmsSenderAdaptee = new ThirdPartySmsSenderAdaptee();
            thirdPartySmsSenderAdaptee.SendSms();
        }
    }

    public class ThirdPartySmsSenderAdaptee
    {
        public void SendSms()
        {
            Console.WriteLine("ThirdPartySmsSender Send sms");
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            ISmsService smsService = new SmsServiceAdapter();
            smsService.SendSms();
        }
    }
}
