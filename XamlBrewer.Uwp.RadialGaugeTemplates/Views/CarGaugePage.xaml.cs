using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using XamlBrewer.Uwp.Controls;

namespace XamlBrewer.Uwp.RadialGaugeTemplates
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CarGaugePage : Page
    {
        public CarGaugePage()
        {
            this.InitializeComponent();
            this.Loaded += Page_Loaded;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            foreach (var square in SquareOfSquares.Squares)
            {
                var gauge = new RadialGauge() { Height = square.ActualHeight, Width = square.ActualWidth };
                gauge.Style = Resources["Audi"] as Style;
                gauge.TrailBrush = new SolidColorBrush(square.RandomColor());

                if (random.Next(10) < 5)
                {
                    gauge.TickBrush = new SolidColorBrush(square.RandomColor());
                }
                else
                {
                    gauge.TickBrush = new SolidColorBrush(Colors.Transparent);
                }

                if (random.Next(10) < 5)
                {
                    gauge.ScaleTickBrush = App.Current.Resources["PageBackgroundBrush"] as SolidColorBrush;
                }
                else
                {
                    gauge.ScaleTickBrush = new SolidColorBrush(Colors.Transparent);
                }

                gauge.NeedleWidth = random.Next(8);
                gauge.TickWidth = gauge.NeedleWidth;

                gauge.ValueBrush = gauge.TrailBrush;
                gauge.Maximum = 50;
                gauge.TickSpacing = 5;
                gauge.ScaleWidth = random.Next(5, 77);
                gauge.Unit = "Things";
                var side = square.Side();
                gauge.Value = side;
                square.Content = gauge;
            }
        }
    }
}
