namespace DesignPatterns.Behavioral.Iterator.Iterator02
{
    public class IteratorClinet : IClient
    {
        public void Operate()
        {
            var collection = new ConcereteCollection();
            var iterator = collection.GetIterator();


        }
    }

    public interface IIterator
    {
        bool HasNext();
        bool MoveNext();
    }

    public class ConIIterator1 : IIterator
    {
        public ConIIterator1(ConcereteCollection concereteCollection)
        {

        }
        public bool HasNext()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
    }

    public interface ICollection
    {
        IIterator GetIterator();

    }

    public class ConcereteCollection : ICollection
    {
        public List<string> MyList { get; set; }

        public IIterator GetIterator()
        {
            return new ConIIterator1(this);
        }
    }
}
