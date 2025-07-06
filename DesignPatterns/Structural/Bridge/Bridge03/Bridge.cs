using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Bridge03
{
    public abstract class AbstractorService
    {
        protected readonly ISmsService smsService;

        protected AbstractorService(ISmsService smsService)
        {
            this.smsService = smsService;
        }

        public abstract void SendSms(string number);
        
    }

    public class Service01 : AbstractorService
    {
        public Service01(ISmsService smsService) : base(smsService)
        {
        }

        public override void SendSms(string number)
        {
            smsService.SendSms(number);
        }
    }

    public interface ISmsService
    {
        void SendSms(string number);
    }

    public class SmsService01 : ISmsService
    {
        public void SendSms(string number)
        {
            //send sms to number
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            AbstractorService abstractor = new Service01(new SmsService01());
            abstractor.SendSms("123");
        }
    }
}
