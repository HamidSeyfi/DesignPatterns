using System.Drawing;

namespace DesignPatterns.Behavioral.Command.Command4
{
    internal class CommandClient : IClient
    {
        public void Operate()
        {
            var customerService = new CustomerService();
            var command1 = new Command1(customerService);
            var button = new Button(command1);
            button.Click();
        }
    }

    public class Button
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

        public void Undo()
        {
            command.UnExecute();
        }
    }

    public interface ICommand
    {
        void Execute();

        void UnExecute();
    }

    public class Command1 : ICommand
    {
        private readonly CustomerService customerService;

        public Command1(CustomerService customerService)
        {
            this.customerService = customerService;
        }
        public void Execute()
        {
            customerService.AddCustomer();
        }

        public void UnExecute()
        {
            customerService.RemoveCustomer();
        }
    }

    public class CustomerService
    {
        public void AddCustomer()
        {
            Console.WriteLine("Customer Added");
        }

        public void RemoveCustomer()
        {
            Console.WriteLine("Customer Removed");
        }
    }
}
