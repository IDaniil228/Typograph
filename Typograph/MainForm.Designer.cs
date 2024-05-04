namespace Typograph
{
    partial class MainForm
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
            Input = new RichTextBox();
            Output = new RichTextBox();
            Btn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Input
            // 
            Input.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Input.Location = new Point(0, 58);
            Input.Name = "Input";
            Input.Size = new Size(335, 390);
            Input.TabIndex = 0;
            Input.Text = "";
            // 
            // Output
            // 
            Output.Location = new Point(470, 58);
            Output.Name = "Output";
            Output.Size = new Size(330, 390);
            Output.TabIndex = 1;
            Output.Text = "";
            // 
            // Btn
            // 
            Btn.FlatStyle = FlatStyle.Flat;
            Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Btn.Location = new Point(341, 189);
            Btn.Name = "Btn";
            Btn.Size = new Size(123, 71);
            Btn.TabIndex = 2;
            Btn.Text = "Обработать текст";
            Btn.UseVisualStyleBackColor = true;
            Btn.Click += Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(129, 35);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Ввод";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(615, 35);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Вывод";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn);
            Controls.Add(Output);
            Controls.Add(Input);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Input;
        private RichTextBox Output;
        private Button Btn;
        private Label label1;
        private Label label2;
    }
}
