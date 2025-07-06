namespace DesignPatterns.Behavioral.Strategy.Strategy01
{
    internal class ImageStore
    {
        public void Store(string fileName, ICompress compress, IFilter filter)
        {

        }
    }

    public interface ICompress
    {
        void Compress();
    }

    public class JPEGCompress : ICompress
    {
        public void Compress()
        {
            throw new NotImplementedException();
        }
    }

    public class PNGCompress : ICompress
    {
        public void Compress()
        {
            throw new NotImplementedException();
        }
    }

    public interface IFilter
    {
        void Filter();
    }

    public class Filter1 : IFilter
    {
        public void Filter()
        {
            throw new NotImplementedException();
        }
    }

    public class Filter2 : IFilter
    {
        public void Filter()
        {
            throw new NotImplementedException();
        }
    }
}
