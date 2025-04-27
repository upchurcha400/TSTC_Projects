using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AnthonyUpchurchM4C
{
    public partial class MainWindow : Window
    {
        private bool isRobot = false; // To toggle between Human and Robot

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Code to execute when the window loads
            MessageBox.Show("I think Ted is a Robot!");
        }
        private void ToggleView_Click(object sender, RoutedEventArgs e)
        {
            // Loop through all the children of the Canvas
            foreach (var child in MyCanvas.Children)
            {
                if (child is Shape shape && shape.Tag != null)
                {
                    string tag = shape.Tag.ToString();

                    // Toggle colors based on the state (Human or Robot)
                    if (!isRobot)
                    {
                        // Change to Robot colors
                        switch (tag)
                        {
                            case "body": shape.Fill = Brushes.DarkGray; break;
                            case "face": shape.Fill = Brushes.LightGray; break;
                            case "hair": shape.Fill = Brushes.DarkGray; break;
                            case "eye":
                                if (shape is Ellipse && shape.Width == 50)
                                    shape.Fill = Brushes.Black;
                                else if (shape is Ellipse && shape.Width == 20)
                                    shape.Fill = Brushes.Transparent;
                                else
                                    shape.Fill = Brushes.Red;
                                break;
                            case "mouth":
                                if (shape is Ellipse)
                                    shape.Fill = Brushes.Transparent;
                                else
                                    shape.Fill = Brushes.DarkRed;
                                break;
                            case "nose": shape.Fill = Brushes.Black; break;
                        }
                    }
                    else
                    {
                        // Change to Human colors
                        switch (tag)
                        {
                            case "body":
                                if (shape is Rectangle && shape.Width == 340)
                                    shape.Fill = Brushes.Blue;
                                else
                                    shape.Fill = Brushes.Yellow;
                                break;
                            case "face": shape.Fill = Brushes.PeachPuff; break;
                            case "hair": shape.Fill = Brushes.BurlyWood; break;
                            case "eye":
                                if (shape is Ellipse && shape.Width == 50)
                                    shape.Fill = Brushes.White;
                                else if (shape is Ellipse && shape.Width == 20)
                                    shape.Fill = Brushes.Black;
                                else
                                    shape.Fill = Brushes.Transparent;
                                break;
                            case "mouth":
                                if (shape is Ellipse)
                                    shape.Fill = Brushes.Black;
                                else
                                    shape.Fill = Brushes.Transparent;
                                break;
                            case "nose": shape.Fill = Brushes.LightCoral; break;
                        }
                    }
                }
            }

            // Toggle the state
            isRobot = !isRobot;

            //Add code to change the button text
            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            // Update the button text based on the current state
            if (isRobot)
            {
                ToggleButton.Content = "or, Human?";
            }
            else
            {
                ToggleButton.Content = "Is he Robot?";
            }
        }
    }
}