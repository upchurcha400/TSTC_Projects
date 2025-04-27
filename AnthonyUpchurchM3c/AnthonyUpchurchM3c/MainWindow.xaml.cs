using System.Data.SqlTypes;
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

namespace AnthonyUpchurchM3c
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

        private void btnBinary_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(tbxInput.Text);
            string binary = "";

            switch (number)
            {
                case 1:
                    binary = "0001";
                    break;
                case 2:
                    binary = "0010";
                    break;
                case 3:
                    binary = "0011";
                    break;
                case 4:
                    binary = "0100";
                    break;
                case 5:
                    binary = "0101";
                    break;
                case 6:
                    binary = "0110";
                    break;
                case 7:
                    binary = "0111";
                    break;
                case 8:
                    binary = "1000";
                    break;
                case 9:
                    binary = "1001";
                    break;
                case 10:
                    binary = "1010";
                    break;
                default:
                    binary = "Invalid";
                    break;
            }

            lblBinary.Content = binary;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbxInput.Clear();
            lblBinary.Content = "";
        }
    }
}