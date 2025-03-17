using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Behavioral.Command.Command3.UndoCommand;

namespace DesignPatterns.Behavioral.Command.Command3
{
    public class Command3Client : IClient
    {
        public void Operate()
        {
            var textEditor = new TextEditor();
            textEditor.Content = "Hamid";

            var history = new History();

            var boldCommand = new BoldCommand(textEditor, history);
            boldCommand.Execute();

            Console.WriteLine(textEditor.Content);

            boldCommand.Execute();
            Console.WriteLine(textEditor.Content);
            boldCommand.Execute();
            Console.WriteLine(textEditor.Content);

            var undoBoldCommand = new UndoCommand(history);
            undoBoldCommand.Execute();

            //boldCommand.UnExecute();

            Console.WriteLine(textEditor.Content);

            undoBoldCommand.Execute();

            //boldCommand.UnExecute();

            Console.WriteLine(textEditor.Content);

            undoBoldCommand.Execute();

            //boldCommand.UnExecute();

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
        private readonly History history;


        private string PrevContent;

        public BoldCommand(TextEditor textEditor, History history)
        {
            this.textEditor = textEditor;
            this.history = history;
        }

        public void Execute()
        {
            PrevContent = textEditor.Content;
            textEditor.MakeBold();
            history.Push(this);
        }

        public void UnExecute()
        {
            textEditor.Content = PrevContent;
        }
    }

    public class UndoCommand : ICommand
    {
        private readonly History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }
        public void Execute()
        {
            history.Pop().UnExecute();
        }


    }

    public class History
    {
        public Stack<IUndoableCommand> Commands { get; set; } = new();

        public void Push(IUndoableCommand command)
        {
            Commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return Commands.Pop();
        }

    }
}