using static System.Net.Mime.MediaTypeNames;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input;
        int[] nums;
        public static int NOD(int a, params int[] nums)//метод Евклида
        {
            if (a == 0) return nums[0];
            while (nums[0] != 0)
            {
                if (a > nums[0])
                {
                    a -= nums[0];
                }
                else
                {
                    nums[0] -= a;
                }
            }
            if (nums.Length <= 1)
            {
                return a;
            }
            return NOD(a, nums[1..nums.Length]);
        }

        public static int NOD(params int[] nums)
        {
            return NOD(nums[0], nums[1..nums.Length]);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            nums = new int[0];
            input = textBox_num1.Text;
            string[] splited_input = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach (string elem in splited_input)
            {
                nums = nums.Append(i).ToArray();
                if (!Int32.TryParse(elem, out nums[i]))
                    MessageBox.Show("Не все элементы возможно преобразовать в числа");
                i++;
            }

            if (splited_input.Length > 1)
                textBox_NOD.Text = NOD(nums).ToString();
        }
    }
}