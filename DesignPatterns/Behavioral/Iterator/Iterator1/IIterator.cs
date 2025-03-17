using System.Collections;

namespace DesignPatterns.Behavioral.Iterator.Iterator1
{
    public interface IIterator
    {
    }

    public class MyClient
    {
        public void Main()
        {
            var itemCollection = new ItemCollection();

        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ItemCollection : IEnumerable<Item>
    {
        public List<Item> Items { get; set; }
        public IEnumerator<Item> GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class ItemIterator : IEnumerator<Item>
    {
        private readonly ItemCollection items;

        public ItemIterator(ItemCollection items)
        {
            this.items = items;
        }
        public Item Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}