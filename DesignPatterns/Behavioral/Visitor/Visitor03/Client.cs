namespace DesignPatterns.Behavioral.Visitor.Visitor03
{
    public class Client : IClient
    {
        public void Operate()
        {

        }
    }

    public class WavFile
    {
        private List<Segment> segments = new();

        public static WavFile read(string fileName)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile.segments.Add(new FormatSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());

            return wavFile;
        }

        public void Execute(IOperation operation)
        {
            foreach (Segment segment in segments)
            {
                segment.Execute(operation);
            }
        }
    }



    public interface IOperation
    {
        public void Apply(FormatSegment segment);
        public void Apply(FactSegment segment);
    }

    public class reduceNoise : IOperation
    {
        public void Apply(FormatSegment segment)
        {
            throw new NotImplementedException();
        }

        public void Apply(FactSegment segment)
        {
            throw new NotImplementedException();
        }
    }



    public abstract class Segment
    {
        public abstract void Execute(IOperation operation);
    }

    public class FormatSegment : Segment
    {
        public override void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }

    public class FactSegment : Segment
    {
        public override void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }



}
