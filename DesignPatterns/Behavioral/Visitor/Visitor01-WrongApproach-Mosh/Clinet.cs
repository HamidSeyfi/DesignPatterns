namespace DesignPatterns.Behavioral.Visitor.Visitor1
{
    public class Clinet : IClient
    {
        public void Operate()
        {
            throw new NotImplementedException();
        }

        public class HtmlDocument
        {
            public void Draw()
            {
                var htmlNodes = new List<HtmlNode>();
                htmlNodes.Add(new HtmlAnchorLink());
                htmlNodes.Add(new HtmlBold());

                foreach (HtmlNode node in htmlNodes)
                {
                    node.HighLight();
                }

                foreach (HtmlNode node in htmlNodes)
                {
                    node.GetText();
                }
            }
        }

        public interface HtmlNode
        {
            void HighLight();
            void GetText();
        }

        public class HtmlAnchorLink : HtmlNode
        {
            public void GetText()
            {
                throw new NotImplementedException();
            }

            public void HighLight()
            {
                throw new NotImplementedException();
            }
        }

        public class HtmlBold : HtmlNode
        {
            public void GetText()
            {
                throw new NotImplementedException();
            }

            public void HighLight()
            {
                throw new NotImplementedException();
            }
        }
    }


}
