using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Command2
{
    public class Command2Client : IClient
    {
        public void Operate()
        {
            var textEditor = new TextEditor();
            textEditor.Content = "Hamid";


            var boldCommand = new BoldCommand(textEditor);
            boldCommand.Execute();

            Console.WriteLine(textEditor.Content);

            boldCommand.UnExecute();

            Console.WriteLine(textEditor.Content);

        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public interface IUndoableCommand : ICommand
    {
        void UnExecute();
    }

    public class TextEditor
    {
        public string Content { get; set; }

        public void MakeBold()
        {
            Content = $"<b>{Content}</b>";
        }
    }

    public class BoldCommand : IUndoableCommand
    {
        private readonly TextEditor textEditor;

        private string PrevContent;

        public BoldCommand(TextEditor textEditor)
        {
            this.textEditor = textEditor;
        }

        public void Execute()
        {
            PrevContent = textEditor.Content;
            textEditor.MakeBold();
        }

        public void UnExecute()
        {
            textEditor.Content = PrevContent;
        }
    }
}
