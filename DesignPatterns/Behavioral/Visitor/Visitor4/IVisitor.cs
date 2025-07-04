using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Visitor4
{
    public interface IVisitor
    {
        void Visit(Element1 element);
        void Visit(Element2 element);
    }

    public class Visitor1 : IVisitor
    {
        public void Visit(Element1 element)
        {
            Console.WriteLine("Visitor1 " + element.Feature());
        }

        public void Visit(Element2 element)
        {
            Console.WriteLine("Visitor1 " + element.Feature());
        }
    }

    public class Visitor2 : IVisitor
    {
        public void Visit(Element1 element)
        {
            Console.WriteLine("Visitor2 " + element.Feature());
        }

        public void Visit(Element2 element)
        {
            Console.WriteLine("Visitor2 " + element.Feature());
        }
    }

    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class Element1 : IElement
    {
        public string Feature()
        {
            return "Element1 Feature1";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Element2 : IElement
    {
        public string Feature()
        {
            return "Element2 Feature2";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var elemet1 =new Element1();
            var elemet2 =new Element2();
            
            var visitor1 = new Visitor1();
            elemet1.Accept(visitor1);
            elemet2.Accept(visitor1);

        }
    }
}
