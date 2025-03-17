namespace DesignPatterns.Behavioral.TemplateMethod.TemplateMethod2
{
    internal class TemplateMethodClint : IClient
    {
        public void Operate()
        {
            var x = new Imp1();
            x.TemplateMethod();
        }
    }

    public abstract class TemplateMethodAbstractClass
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Hook1();
        }

        public virtual void Step1()
        {

        }

        public abstract void Step2();

        public virtual void Hook1()
        {

        }
    }

    public class Imp1 : TemplateMethodAbstractClass
    {
        public override void Step2()
        {
            throw new NotImplementedException();
        }
    }

}
