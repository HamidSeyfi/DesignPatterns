namespace DesignPatterns.Behavioral.Visitor.Visitor02
{
    public class Client : IClient
    {
        public void Operate()
        {
            HtmlDocument htmlDocument = new();
            htmlDocument.Add(new HtmlAnchorLink());
            htmlDocument.Add(new HtmlBold());

            var operation = new HilightOperation();
            htmlDocument.Execute(operation);

        }
    }

    public class HtmlDocument
    {
        private List<HtmlNode> htmlNodes = new List<HtmlNode>();
        public void Add(HtmlNode htmlNode)
        {
            htmlNodes.Add(htmlNode);
        }

        public void Execute(IOperation operation)
        {
            foreach (var node in htmlNodes)
            {
                node.Execute(operation);
            }

        }
    }

    public abstract class HtmlNode
    {
        public abstract void Execute(IOperation visitor);

    }

    public class HtmlAnchorLink : HtmlNode
    {
        public override void Execute(IOperation visitor)
        {
            visitor.Apply(this);
        }
    }

    public class HtmlBold : HtmlNode
    {
        public override void Execute(IOperation visitor)
        {
            visitor.Apply(this);
        }
    }

    public interface IOperation
    {
        void Apply(HtmlAnchorLink node);
        void Apply(HtmlBold node);
    }

    public class HilightOperation : IOperation
    {
        public void Apply(HtmlAnchorLink node)
        {
            throw new NotImplementedException();
        }

        public void Apply(HtmlBold node)
        {
            throw new NotImplementedException();
        }
    }

    public class MakeBoldOperation : IOperation
    {
        public void Apply(HtmlAnchorLink node)
        {
            throw new NotImplementedException();
        }

        public void Apply(HtmlBold node)
        {
            throw new NotImplementedException();
        }
    }
}
