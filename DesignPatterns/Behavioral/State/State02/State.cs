namespace DesignPatterns.Behavioral.State.State02
{

    #region Good
    public class StateClient : IClient
    {
        public void Operate()
        {

            var canvas = new Canvas();
            canvas.SetCurrectTool(new Brush());
            canvas.MouseUp();
            //...

        }
    }

    public class Canvas
    {
        public Tool CurrentTool { get; set; }

        public void SetCurrectTool(Tool tool)
        {
            CurrentTool = tool;
        }

        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }

        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }
    }

    public abstract class Tool
    {
        private Canvas _canvas;
        public void SetCanvas(Canvas canvas)
        {
            _canvas = canvas;
        }

        public abstract void MouseUp();
        public abstract void MouseDown();
    }

    public class Brush : Tool
    {
        public override void MouseDown()
        {
            throw new NotImplementedException();
        }

        public override void MouseUp()
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : Tool
    {
        public override void MouseDown()
        {
            throw new NotImplementedException();
        }

        public override void MouseUp()
        {
            throw new NotImplementedException();
        }
    }
    #endregion


    #region Bad
    internal enum ToolType
    {
        Brush,
        Rectangel
    }

    //internal class BadStateClient : IClient
    //{
    //    public void Operate()
    //    {
    //        var canvas = new BadCanvas();
    //        canvas.CurrentTool = ToolType.Brush;
    //        canvas.MouseDown();
    //        canvas.MouseDown();
    //    }
    //}

    internal class BadCanvas
    {
        public ToolType CurrentTool { get; set; }

        public void MouseDown()
        {
            switch (CurrentTool)
            {
                case ToolType.Brush:
                    break;
                case ToolType.Rectangel:
                    break;
                default:
                    break;
            }

        }

        public void MouseUp()
        {
            switch (CurrentTool)
            {
                case ToolType.Brush:
                    break;
                case ToolType.Rectangel:
                    break;
                default:
                    break;
            }
        }
    }
    #endregion


}
