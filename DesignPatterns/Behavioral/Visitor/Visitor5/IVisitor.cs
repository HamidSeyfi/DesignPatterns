using DesignPatterns.Behavioral.Visitor.Vistitor3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Visitor5
{
    public interface IVisitor
    {
        void Visit(FactSegment factSegment);
        void Visit(FormatSegment formatSegment);
    }

    public class ReduceNoise : IVisitor
    {
        public void Visit(FactSegment factSegment)
        {
            Console.WriteLine("ReduceNoise factSegment");

        }
        public void Visit(FormatSegment formatSegment)
        {
            Console.WriteLine("ReduceNoise formatSegment");
        }
    }

    public interface Segment
    {
        void Accept(IVisitor visitor);
    }

    public class FactSegment : Segment
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class FormatSegment : Segment
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var semgents = new List<Segment>();
            semgents.Add(new FormatSegment());
            semgents.Add(new FactSegment());
            semgents.Add(new FactSegment());
            semgents.Add(new FactSegment());

            var reduceNoiceEditor = new ReduceNoise();
            foreach (var item in semgents)
            {
                item.Accept(reduceNoiceEditor);
            }




        }
    }
}
