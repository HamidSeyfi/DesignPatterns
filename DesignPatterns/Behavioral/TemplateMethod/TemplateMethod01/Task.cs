namespace DesignPatterns.Behavioral.TemplateMethod.TemplateMethod01
{



    public class AuditTrail
    {

        public void Record()
        {
            Console.WriteLine("Record");
        }
    }


    public abstract class Task
    {
        private readonly AuditTrail auditTrail;

        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void DoExecute()
        {
            auditTrail.Record();
            Execute();
        }

        protected abstract void Execute();
    }

    public class MoneyTransfer : Task
    {
        public MoneyTransfer(AuditTrail auditTrail) : base(auditTrail)
        {

        }
        protected override void Execute()
        {
            //transfer
        }
    }

    //-------------------------------------------

    public class Client : IClient
    {
        public void Operate()
        {
            var windows = new SomeWindows1();
            windows.close();
        }
    }

    public abstract class Window
    {
        public void close()
        {
            //TODO: custom windows may need to execute some code before the window
            // is closed.

            BeforeWindowsClose();

            Console.WriteLine();

            AfterWindowsClose();
            //TODO: custom windows may need to execute some code after the window
            // is closed.
        }

        protected virtual void BeforeWindowsClose() { }
        protected virtual void AfterWindowsClose() { }

    }

    public class SomeWindows1 : Window
    {
        protected override void AfterWindowsClose()
        {
            throw new NotImplementedException();
        }

        protected override void BeforeWindowsClose()
        {
            throw new NotImplementedException();
        }
    }


}
