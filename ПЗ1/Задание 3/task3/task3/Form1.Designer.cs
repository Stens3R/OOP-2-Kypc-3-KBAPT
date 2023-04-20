namespace task3
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
            textBoxInput = new TextBox();
            button_convert = new Button();
            labelOutput = new Label();
            groupBox1 = new GroupBox();
            textBoxSys = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 26);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(109, 23);
            textBoxInput.TabIndex = 0;
            textBoxInput.Leave += textBoxInput_Leave;
            // 
            // button_convert
            // 
            button_convert.Location = new Point(127, 3);
            button_convert.Name = "button_convert";
            button_convert.Size = new Size(109, 24);
            button_convert.TabIndex = 1;
            button_convert.Text = "Конвертировать ";
            button_convert.UseVisualStyleBackColor = true;
            button_convert.Click += button_convert_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelOutput.Location = new Point(6, 10);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 25);
            labelOutput.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(labelOutput);
            groupBox1.Location = new Point(12, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 113);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // textBoxSys
            // 
            textBoxSys.Location = new Point(242, 26);
            textBoxSys.Name = "textBoxSys";
            textBoxSys.Size = new Size(112, 23);
            textBoxSys.TabIndex = 4;
            textBoxSys.Leave += textBoxSys_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 7);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 6;
            label2.Text = "Система исчисления";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 180);
            Controls.Add(label2);
            Controls.Add(textBoxSys);
            Controls.Add(label1);
            Controls.Add(button_convert);
            Controls.Add(textBoxInput);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button button_convert;
        private Label labelOutput;
        private GroupBox groupBox1;
        private TextBox textBoxSys;
        private Label label1;
        private Label label2;
    }
}