namespace DesignPatterns.Behavioral.Iterator.Iterator01
{
    internal class BrowserHistory
    {
        private Stack<string> _urls = new();

        public void Push(string history)
        {
            _urls.Push(history);
        }
        public string Pop()
        {
            return _urls.Pop();
        }

        public IIterator<string> CreateIterator()
        {
            return new BrowserHistoryIterator(this);
        }

        public class BrowserHistoryIterator : IIterator<string>
        {
            private readonly BrowserHistory _browserHistory;

            public BrowserHistoryIterator(BrowserHistory browserHistory)
            {
                _browserHistory = browserHistory;
            }

            public string Current()
            {
                return _browserHistory._urls.Peek();
            }

            public bool HasNext()
            {
                return _browserHistory._urls.Any();
            }

            public void Next()
            {
                _browserHistory.Pop();
            }
        }

    }

    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }


    public class IteratorClient : IClient
    {
        public void Operate()
        {
            var browserHitory = new BrowserHistory();
            browserHitory.Push("a");
            browserHitory.Push("b");
            browserHitory.Push("c");

            var browserHitoryIterator = browserHitory.CreateIterator();

            while (browserHitoryIterator.HasNext())
            {
                Console.WriteLine(browserHitoryIterator.Current());
                browserHitoryIterator.Next();
            }
        }
    }
}
