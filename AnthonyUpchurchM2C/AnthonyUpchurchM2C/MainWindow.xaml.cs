using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnthonyUpchurchM2C
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double number1, number2, result;
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                result = number1 + number2;
                lblResult.Content = result.ToString();
            }
            else
            {
                lblResult.Content = "Error";
            }
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            double number1, number2, result;
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                result = number1 - number2;
                lblResult.Content = result.ToString();
            }
            else
            {
                lblResult.Content = "Error";
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            double number1, number2, result;
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                result = number1 * number2;
                lblResult.Content = result.ToString();
            }
            else
            {
                lblResult.Content = "Error";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            lblResult.Content = "";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
