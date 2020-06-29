using TestAppUno.Shared.Content;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestAppUno
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OrderBurger));
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CartPage));
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ShowMapPage));
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TakePicture));
        }
        
        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CalculatorPage));
        }
    }
}