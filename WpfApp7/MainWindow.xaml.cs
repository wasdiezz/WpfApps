using System.Text;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click_Ravno(object sender, RoutedEventArgs e)
        {
            string res = textLabel.Text.ToString();
            if (res.Contains("%"))
            {
                string a = "";
                string b = "";
                double count = 0;

                int percentIndex = res.IndexOf("%");
                a = res.Substring(0, percentIndex);
                b = res.Substring(percentIndex + 1);

                count = double.Parse(a) / double.Parse(b) * 100;
                textLabel.Text = count.ToString() + "%";
            }
            else if (res.Contains("/0"))
            {
                MessageBox.Show("На ноль делить нельзя");
            }
            else if (!res.Contains("/0"))
            {
                string value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = value;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "9";
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "0";
        }

        private void Button_Click_ac(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
        }

        private void Button_Click_discr(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "/";
        }

        private void Button_Click_mult(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "*";
        }

        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "-";
        }

        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "+";
        }

        private void Button_Click_precent(object sender, RoutedEventArgs e)
        {
            textLabel.Text += "%";
        }
    }
}