namespace Command_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            AddTextBtn = new Button();
            UndoBtn = new Button();
            RedoBtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // AddTextBtn
            // 
            AddTextBtn.Location = new Point(127, 6);
            AddTextBtn.Name = "AddTextBtn";
            AddTextBtn.Size = new Size(75, 23);
            AddTextBtn.TabIndex = 2;
            AddTextBtn.Text = "AddText";
            AddTextBtn.UseVisualStyleBackColor = true;
            AddTextBtn.Click += AddTextBtn_Click;
            // 
            // UndoBtn
            // 
            UndoBtn.Location = new Point(12, 73);
            UndoBtn.Name = "UndoBtn";
            UndoBtn.Size = new Size(75, 23);
            UndoBtn.TabIndex = 3;
            UndoBtn.Text = "Undo";
            UndoBtn.UseVisualStyleBackColor = true;
            UndoBtn.Click += UndoBtn_Click;
            // 
            // RedoBtn
            // 
            RedoBtn.Location = new Point(105, 73);
            RedoBtn.Name = "RedoBtn";
            RedoBtn.Size = new Size(75, 23);
            RedoBtn.TabIndex = 4;
            RedoBtn.Text = "Redo";
            RedoBtn.UseVisualStyleBackColor = true;
            RedoBtn.Click += RedoBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RedoBtn);
            Controls.Add(UndoBtn);
            Controls.Add(AddTextBtn);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button AddTextBtn;
        private Button UndoBtn;
        private Button RedoBtn;
    }
}
