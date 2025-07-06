namespace DesignPatterns.Behavioral.Command.Command01
{
    internal class Button
    {
        private readonly ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void Click()
        {
            command.Execute();
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class CustomerService
    {
        public void AddCustomer()
        {
            Console.WriteLine("Customer Addded");
        }
    }

    public class ConcereteCommand : ICommand
    {
        private readonly CustomerService customerService;

        public ConcereteCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }
        public void Execute()
        {
            customerService.AddCustomer();
        }
    }


    public class CommandClinet : IClient
    {
        public void Operate()
        {
            var customerSerice = new CustomerService();
            var concrerteCommand = new ConcereteCommand(customerSerice);
            var button = new Button(concrerteCommand);
            button.Click();
        }
    }
}
