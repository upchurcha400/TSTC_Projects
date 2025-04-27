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

namespace WpfModule4Lecture
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // in each for each loop we will check the child items in canvas to see if they match the tag
            foreach(var x in MyCanvas.Children.OfType<Rectangle>())
            {
                //search for rectangles in loop
                if((string)x.Tag == "clover")
                {
                    //check clover tag then do the to all rect with this tag
                    x.Stroke = Brushes.Yellow;
                    x.StrokeThickness = 4;

                }
                if ((string)x.Tag == "moon")
                {
                    //check clover tag then do the to all rect with this tag
                    x.Stroke = Brushes.Orange;
                    x.StrokeThickness = 4;

                }
                if ((string)x.Tag == "heart")
                {
                    //check clover tag then do the to all rect with this tag
                    x.Stroke = Brushes.White;
                    x.StrokeThickness = 4;

                }
            }
                }
    }
}
