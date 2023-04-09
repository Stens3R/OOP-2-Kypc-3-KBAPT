namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num_1, num_2, num_3, num_4, num_5;
        public static int NOD(int a, int b)//метод Евклида
        {
            if (a == 0) return b;
            while (b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox_num1.Text, out num_1))
            {
                MessageBox.Show("Неверно задано значение!, Введите число cнова");
            }
            if (!Int32.TryParse(textBox_num2.Text, out num_2))
            {
                MessageBox.Show("Неверно задано значение!, Введите число cнова");
            }
            textBox_NOD.Text = NOD(num_1, num_2).ToString();
        }
    }
}