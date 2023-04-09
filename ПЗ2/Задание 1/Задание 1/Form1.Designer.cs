namespace Задание_1
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
            textBox_num1 = new TextBox();
            textBox_num2 = new TextBox();
            textBox_NOD = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_num1
            // 
            textBox_num1.Location = new Point(62, 22);
            textBox_num1.Name = "textBox_num1";
            textBox_num1.Size = new Size(100, 23);
            textBox_num1.TabIndex = 0;
            // 
            // textBox_num2
            // 
            textBox_num2.Location = new Point(62, 51);
            textBox_num2.Name = "textBox_num2";
            textBox_num2.Size = new Size(100, 23);
            textBox_num2.TabIndex = 1;
            // 
            // textBox_NOD
            // 
            textBox_NOD.Location = new Point(62, 80);
            textBox_NOD.Name = "textBox_NOD";
            textBox_NOD.Size = new Size(100, 23);
            textBox_NOD.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(203, 51);
            button1.Name = "button1";
            button1.Size = new Size(76, 23);
            button1.TabIndex = 3;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_num2);
            groupBox1.Controls.Add(textBox_NOD);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox_num1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 114);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задание 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 83);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "НОД:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "2 число";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "1 число";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 306);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_num1;
        private TextBox textBox_num2;
        private TextBox textBox_NOD;
        private Button button1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}