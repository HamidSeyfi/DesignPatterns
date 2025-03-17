using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento.Memento1
{
    public class Document
    {
        private string content;
        private string fontName;
        private int fontSize;

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
        }

        public string getFontName()
        {
            return fontName;
        }

        public void setFontName(string fontName)
        {
            this.fontName = fontName;
        }

        public int getFontSize()
        {
            return fontSize;
        }

        public void setFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public MementoMoshTest CreateState()
        {
            var mementiState = new MementoMoshTest(content, fontName, fontSize);
            return mementiState;
        }

        public void RestoreState(MementoMoshTest model)
        {
            content = model.Content;
            fontName = model.FontName;
            fontSize = model.FontSize;
        }

        public override string ToString()
        {
            return "Document{" +
                    "content='" + content + '\'' +
                    ", fontName='" + fontName + '\'' +
                    ", fontSize=" + fontSize +
                    '}';
        }
    }

    public class MementoMoshTest
    {
        public MementoMoshTest(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }
    }

    public class CareTakerMoshTest
    {
        public Stack<MementoMoshTest> Mementos { get; set; }

        public MementoMoshTest Pop()
        {
            return Mementos.Pop();
        }

        public void Push(MementoMoshTest model)
        {
            Mementos.Push(model);
        }
    }

    public class ClinetMoshTest : IClient
    {
        public void Operate()
        {
            //var documtn = new Document();
            //documtn.setContent();
        }
    }
}
