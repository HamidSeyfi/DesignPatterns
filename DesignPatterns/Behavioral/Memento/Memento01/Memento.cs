namespace DesignPatterns.Behavioral.Memento.Memento01
{
    internal class MementoClient : IClient
    {
        public void Operate()
        {
            Originator originator = new();
            CareTaker careTaker = new();

            originator.SetContent("a");
            careTaker.Push(originator.CreateState());
            Console.WriteLine(originator.GetContent());

            originator.SetContent("b");
            careTaker.Push(originator.CreateState());
            Console.WriteLine(originator.GetContent());

            originator.SetContent("c");
            careTaker.Push(originator.CreateState());
            Console.WriteLine(originator.GetContent());

            originator.Restore(careTaker.Pop());
            Console.WriteLine(originator.GetContent());

            originator.Restore(careTaker.Pop());
            Console.WriteLine(originator.GetContent());
        }
    }

    public class Originator
    {
        private string _content;

        public void SetContent(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }

        public Memento CreateState()
        {
            return new Memento(_content);
        }

        public void Restore(Memento editorState)
        {
            _content = editorState.GetContent();
        }
    }

    public class Memento
    {
        private string _content { get; set; }

        public Memento(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }

    public class CareTaker
    {
        private List<Memento> _states { get; set; } = new();

        public void Push(Memento editorState)
        {
            _states.Add(editorState);
        }

        public Memento Pop()
        {
            var result = _states.Last();
            _states.Remove(result);
            return result;
        }
    }

    #region Test
    public class ClientTest
    {
        public void Operate()
        {
            var originator = new OriginatorTest();
        }
    }

    public class OriginatorTest
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public string FoneSize { get; set; }


        public MementoTest TakeSnapshot()
        {
            return new MementoTest(Content, FontName, FoneSize);
        }

        public void Undo(MementoTest memento)
        {
            Content = memento.Content;
            FontName = memento.FontName;
            //
        }
    }

    public class MementoTest
    {
        public MementoTest(string content, string fontName, string foneSize)
        {
            Content = content;
            FontName = fontName;
            FoneSize = foneSize;
        }

        public string Content { get; set; }
        public string FontName { get; set; }
        public string FoneSize { get; set; }


    }

    public class CareTakerTest
    {
        public List<MementoTest> States { get; set; } = new();

        public void Push(MementoTest memento)
        {
            States.Add(memento);
        }

        public MementoTest Restore()
        {
            return States.Last();
        }
    }
    #endregion
}
