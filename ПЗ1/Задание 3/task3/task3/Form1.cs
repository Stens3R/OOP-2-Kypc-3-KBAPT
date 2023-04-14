using System.Text;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int input, sys;
        private void button_convert_Click(object sender, EventArgs e)
        {
            labelOutput.Text = $"� {sys} ������� ����������\n{convert(input, sys)}";
        }
        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxInput.Text, out input) || input < 0)
            {
                if (textBoxInput.Text == String.Empty)
                {
                    input = 0;
                    textBoxInput.Text = "0";
                    return;
                }
                MessageBox.Show("������� ������ ��������!, ������� ����� c����");
                textBoxInput.Select();
                return;
            }
        }

        private void textBoxSys_Leave(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxSys.Text, out sys) || sys < 2)
            {
                if (textBoxSys.Text == String.Empty)
                {
                    sys = 2;
                    textBoxSys.Text = "2";
                    return;
                }
                MessageBox.Show("������� ������ ��������!, ������� ����� c����");
                textBoxSys.Select();
                return;
            }

        }

        static string convert(int inp, int sys)
        {
            StringBuilder str = new();
            int temp;
            do
            {
                temp = inp % sys;
                str.Insert(0, (Alph)temp);
                inp /= sys;
            } while (inp > 0);
            try { return str.ToString(); }
            catch { MessageBox.Show("������ � ������ Convert, str ������ null"); return "error"; }
        }

        enum Alph
        {
            A = 10,
            B,
            C,
            D,
            E,
            F
        }
    }
}