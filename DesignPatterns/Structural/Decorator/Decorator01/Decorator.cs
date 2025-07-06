namespace DesignPatterns.Structural.Decorator.Decorator01
{
    public abstract class Notifier
    {
        public abstract void Execute();
    }

    public class EmptyNotifier : Notifier
    {
        public override void Execute()
        {
        }
    }

    public class SmsNotifier : Notifier
    {
        public override void Execute()
        {
            Console.WriteLine("Send Sms");
        }
    }

    public class EmailNotifier : Notifier
    {
        public override void Execute()
        {
            Console.WriteLine("Send Email");
        }
    }

    public class SlackNotifier : Notifier
    {
        public override void Execute()
        {
            Console.WriteLine("Send Slack");
        }
    }

    public class BaseDecorator : Notifier
    {
        public Notifier _notifier { get; set; }

        public BaseDecorator(Notifier notifier)
        {
            _notifier = notifier;
        }

        public override void Execute()
        {
            _notifier.Execute();
        }
    }

    public class SMSDecorator : BaseDecorator
    {
        public SMSDecorator(Notifier notifier) : base(notifier)
        {
        }

        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("Send Sms");
        }
    }

    public class EmailDecorator : BaseDecorator
    {
        public EmailDecorator(Notifier notifier) : base(notifier)
        {
        }

        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("Send Email");
        }
    }

    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(Notifier notifier) : base(notifier)
        {
        }

        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("Send Slack");
        }
    }

    public class Clinet : IClient
    {
        public void Operate()
        {
            Notifier notifier = new EmptyNotifier();
            notifier = new SMSDecorator(notifier);
            notifier = new EmailDecorator(notifier);
            notifier.Execute();
        }
    }
}
