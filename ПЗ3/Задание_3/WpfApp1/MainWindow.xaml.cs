using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int var1, var2;

        private void multiply_button_Click(object sender, RoutedEventArgs e)
        {
            if (!(Int32.TryParse(mult_1.Text, out var1) && Int32.TryParse(mult_2.Text, out var2)))
            {
                MessageBox.Show("Введите правильное число");
                var1 = 0;
                var2 = 0;
            }

            checked//что-бы вызвать исключение, которое скрывается по умолчанию
            {
                try
                {
                    int mult_result = var1 * var2;//умножение чтобы достичь переполнения
                    result.Content = mult_result;//выведение результата
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message);//вывод сообщения об ошибке
                }
            }
        }
    }
}
