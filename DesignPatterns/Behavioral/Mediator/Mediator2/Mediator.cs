using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Mediator2
{
    public abstract class College
    {
        protected Mediator mediator;
        public virtual void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send()
        {
            mediator.NotifyChange(this);
        }
    }

    public class ConCollege1 : College
    {
        public override void Send()
        {
            base.Send();
        }
    }

    public class ConCollege2 : College
    {
        public override void Send()
        {
            base.Send();
        }
    }

    public abstract class Mediator
    {
        public abstract void NotifyChange(College college);
    }

    public class ConMediator : Mediator
    {
        private readonly ConCollege1 conCollege1;
        private readonly ConCollege2 conCollege2;

        public ConMediator(ConCollege1 conCollege1, ConCollege2 conCollege2)
        {
            this.conCollege1 = conCollege1;
            this.conCollege2 = conCollege2;
        }

        public override void NotifyChange(College college)
        {
            if (college == conCollege1)
            {
                //do someThing with college1
            }
            if (college == conCollege2)
            {
                //do someThing with college2
            }
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var concol1 = new ConCollege1();
            var concol2 = new ConCollege2();
            var conMed = new ConMediator(concol1 , concol2);
            concol1.SetMediator(conMed);
            concol2.SetMediator(conMed);

            concol1.Send();

        }
    }
}
