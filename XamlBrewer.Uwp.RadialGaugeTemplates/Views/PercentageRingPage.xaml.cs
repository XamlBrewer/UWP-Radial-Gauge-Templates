using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using XamlBrewer.Uwp.Controls;

namespace XamlBrewer.Uwp.RadialGaugeTemplates
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PercentageRingPage : Page
    {
        public PercentageRingPage()
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
                gauge.Style = Resources["Percentage"] as Style;
                gauge.TrailBrush = new SolidColorBrush(square.RandomColor());
                gauge.ScaleWidth = random.Next(5, 77);
                gauge.Unit = "%";

                var side = square.Side();
                gauge.Value = side * 2;
                square.Content = gauge;
            }
        }
    }
}
