using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.Proxy02
{

    public interface SharedInterface
    {
        void Do();
    }
    public class Proxy : SharedInterface
    {
        private readonly MainClass mainClass;

        public Proxy(MainClass mainClass)
        {
            this.mainClass = mainClass;
        }
        public void Do()
        {
            //do extra things
            mainClass.Do();
            //do extra things
        }
    }

    public class MainClass : SharedInterface
    {
        public void Do()
        {
            //do the real thing
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var proxy = new Proxy(new MainClass());
            proxy.Do();
        }
    }

}
