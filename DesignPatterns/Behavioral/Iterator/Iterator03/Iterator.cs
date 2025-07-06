namespace DesignPatterns.Behavioral.Iterator.Iterator03
{
    public interface IIterator
    {
        object GetNext();
        bool HasNext();
    }

    public interface ICollection
    {
        IIterator CreateIterator();
    }

    public class ConcreteIterator : IIterator
    {
        private readonly ICollection collection;

        public ConcreteIterator(ICollection collection)
        {
            this.collection = collection;
        }
        public object GetNext()
        {
            //get next
            return null;
        }

        public bool HasNext()
        {
            //has next
            return true;
        }
    }

    public class ConcreteCollection : ICollection
    {
        private List<string> strings;

        public void AddItem(string item)
        {
            strings.Add(item);
        }

        public List<string> GetItems()
        {
            return strings;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }

    public class Client : IClient
    {
        public void Operate()
        {
            var collection = new ConcreteCollection();
            collection.AddItem("hamid");

            var itrator = collection.CreateIterator();
            while (itrator.HasNext())
            {
                var value = itrator.GetNext();
            }
        }
    }
}
