using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AUpchurchW4
{
    public partial class MainWindow : Window
    {
        private bool isDay = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // This method is intentionally left empty since no setup logic is specified for loading.
        }

        private void btnDayNight_Click(object sender, RoutedEventArgs e)
        {
            isDay = !isDay;
            btnDayNight.Content = isDay ? "Switch to Night" : "Switch to Day";

            this.Background = isDay ? Brushes.DeepSkyBlue : Brushes.DarkBlue;

            foreach (var x in MyCanvas.Children.OfType<Shape>())
            {
                switch ((string)x.Tag)
                {
                    case "sun":
                        x.Fill = isDay ? Brushes.Yellow : Brushes.White;
                        break;

                    case "tree":
                        if (isDay)
                        {
                            if (x.Fill.Equals(Brushes.DarkOliveGreen)) x.Fill = Brushes.ForestGreen;
                            if (x.Fill.Equals(Brushes.DarkGreen)) x.Fill = Brushes.Green;
                            if (x.Fill.Equals(Brushes.OliveDrab)) x.Fill = Brushes.GreenYellow;
                            if (x.Fill.Equals(Brushes.DarkRed)) x.Fill = Brushes.SaddleBrown;
                            
                        }
                        else
                        {
                            if (x.Fill.Equals(Brushes.ForestGreen)) x.Fill = Brushes.DarkOliveGreen;
                            if (x.Fill.Equals(Brushes.Green)) x.Fill = Brushes.DarkGreen;
                            if (x.Fill.Equals(Brushes.GreenYellow)) x.Fill = Brushes.OliveDrab;
                            if (x.Fill.Equals(Brushes.SaddleBrown)) x.Fill = Brushes.DarkRed;
                            
                        }
                        break;

                    case "grass":
                        x.Fill = isDay ? Brushes.Green : Brushes.DarkOliveGreen;
                        break;

                    case "house":
                        x.Fill = isDay ? Brushes.BurlyWood : Brushes.DarkRed;
                        break;

                    case "door":
                        x.Fill = isDay ? Brushes.DarkRed : Brushes.Black;
                        break;

                    case "window":
                        x.Fill = isDay ? Brushes.LightBlue : Brushes.LightGoldenrodYellow;
                        break;

                    case "light":
                        if (isDay)
                        {
                            if (x.Fill == Brushes.Black) x.Fill = Brushes.SaddleBrown;
                            if (x.Fill == Brushes.White) x.Fill = Brushes.LightGray;
                            if (x.Fill == Brushes.Yellow) x.Fill = Brushes.Transparent;
                        }
                        else
                        {
                            if (x.Fill == Brushes.SaddleBrown) x.Fill = Brushes.Black;
                            if (x.Fill == Brushes.LightGray) x.Fill = Brushes.White;
                            if (x.Fill == Brushes.Transparent) x.Fill = Brushes.Yellow;
                        }
                        break;

                    case "cloud":
                        x.Fill = isDay ? Brushes.White : Brushes.Gray;
                        break;
                }
            }
        }
    }
}