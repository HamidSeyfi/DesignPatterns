namespace Command_WindowsForms
{
    public partial class Form1 : Form
    {
        private List<string> strings = new List<string>();
        int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = string.Empty;
        }

        private void AddTextBtn_Click(object sender, EventArgs e)
        {
            strings.Add(textBox1.Text);
            currentIndex++;
            label1.Text += $" {textBox1.Text} ";
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            label1.Text.Replace(strings[--currentIndex], "");

        }

        private void RedoBtn_Click(object sender, EventArgs e)
        {
            label1.Text += strings[currentIndex++];
        }
    }

    public  abstract class Command
    {
        private Command _command { get; set; }

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public abstract void Execute();


    }

    public class SetTextCommand : Command
    {
        private readonly AddTextToLable addTextToLable;

        public SetTextCommand(AddTextToLable addTextToLable)
        {
            this.addTextToLable = addTextToLable;
        }
        public override void Execute()
        {
            addTextToLable.Operate();
        }
    }

    public class AddTextToLable
    {
        public void Operate()
        {

        }
    }
}
