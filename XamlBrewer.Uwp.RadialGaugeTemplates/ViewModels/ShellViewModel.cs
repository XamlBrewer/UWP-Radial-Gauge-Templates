using Windows.UI.Xaml.Controls;
using XamlBrewer.Uwp.RadialGaugeTemplates;

namespace Mvvm
{
    class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menu
            // Symbol enumeration is here: https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.controls.symbol.aspx
            Menu.Add(new MenuItem() { Glyph = Symbol.Home, Text = "Home", NavigationDestination = typeof(MainPage) });
            Menu.Add(new MenuItem() { Glyph = Symbol.View, Text = "180°", NavigationDestination = typeof(HalfCirclePage) });
            Menu.Add(new MenuItem() { Glyph = Symbol.RepeatOne, Text = "270°", NavigationDestination = typeof(CarGaugePage) });
            Menu.Add(new MenuItem() { Glyph = Symbol.Rotate, Text = "360°", NavigationDestination = typeof(PercentageRingPage) });
        }
    }
}
