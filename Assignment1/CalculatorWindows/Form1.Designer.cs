namespace CalculatorWindows
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
            InputLabel1 = new Label();
            OpSelectorLabel = new Label();
            InputLabel2 = new Label();
            ResultLabel = new Label();
            InputBox1 = new TextBox();
            InputBox2 = new TextBox();
            ResultShowLabel = new Label();
            OpBox = new ComboBox();
            CalButton = new Button();
            SuspendLayout();
            // 
            // InputLabel1
            // 
            InputLabel1.AutoSize = true;
            InputLabel1.Location = new Point(96, 51);
            InputLabel1.Name = "InputLabel1";
            InputLabel1.Size = new Size(107, 31);
            InputLabel1.TabIndex = 0;
            InputLabel1.Text = "数字1： ";
            // 
            // OpSelectorLabel
            // 
            OpSelectorLabel.AutoSize = true;
            OpSelectorLabel.Location = new Point(96, 202);
            OpSelectorLabel.Name = "OpSelectorLabel";
            OpSelectorLabel.Size = new Size(134, 31);
            OpSelectorLabel.TabIndex = 0;
            OpSelectorLabel.Text = "运算符选择";
            // 
            // InputLabel2
            // 
            InputLabel2.AutoSize = true;
            InputLabel2.Location = new Point(96, 129);
            InputLabel2.Name = "InputLabel2";
            InputLabel2.Size = new Size(100, 31);
            InputLabel2.TabIndex = 0;
            InputLabel2.Text = "数字2：";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(96, 276);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 31);
            ResultLabel.TabIndex = 0;
            // 
            // InputBox1
            // 
            InputBox1.Location = new Point(284, 51);
            InputBox1.Name = "InputBox1";
            InputBox1.Size = new Size(200, 38);
            InputBox1.TabIndex = 1;
            // 
            // InputBox2
            // 
            InputBox2.Location = new Point(284, 129);
            InputBox2.Name = "InputBox2";
            InputBox2.Size = new Size(200, 38);
            InputBox2.TabIndex = 1;
            // 
            // ResultShowLabel
            // 
            ResultShowLabel.AutoSize = true;
            ResultShowLabel.Location = new Point(284, 296);
            ResultShowLabel.Name = "ResultShowLabel";
            ResultShowLabel.Size = new Size(0, 31);
            ResultShowLabel.TabIndex = 2;
            // 
            // OpBox
            // 
            OpBox.FormattingEnabled = true;
            OpBox.Location = new Point(284, 202);
            OpBox.Name = "OpBox";
            OpBox.Size = new Size(242, 39);
            OpBox.TabIndex = 3;
            // 
            // CalButton
            // 
            CalButton.Location = new Point(95, 288);
            CalButton.Name = "CalButton";
            CalButton.Size = new Size(150, 46);
            CalButton.TabIndex = 4;
            CalButton.Text = "计算";
            CalButton.UseVisualStyleBackColor = true;
            CalButton.Click += CalButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalButton);
            Controls.Add(OpBox);
            Controls.Add(ResultShowLabel);
            Controls.Add(InputBox2);
            Controls.Add(InputBox1);
            Controls.Add(InputLabel2);
            Controls.Add(ResultLabel);
            Controls.Add(OpSelectorLabel);
            Controls.Add(InputLabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InputLabel1;
        private Label OpSelectorLabel;
        private Label InputLabel2;
        private Label ResultLabel;
        private TextBox InputBox1;
        private TextBox InputBox2;
        private Label ResultShowLabel;
        private ComboBox OpBox;
        private Button CalButton;
    }
}
