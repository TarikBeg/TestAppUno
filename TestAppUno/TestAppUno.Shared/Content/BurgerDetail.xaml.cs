using TestXamarinApp.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestAppUno.Shared.Content
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BurgerDetail : Page
    {
        private BurgerDetailViewModel viewModel;

        public BurgerDetail()
        {
            InitializeComponent();

            //viewModel = new BurgerDetailViewModel(objectToPass);
            //this.DataContext = viewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            viewModel = new BurgerDetailViewModel(e.Parameter);

            this.DataContext = viewModel;

            base.OnNavigatedTo(e);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            viewModel.CartDataService.AddCartItem(viewModel.SelectedBurger, viewModel.Amount);

            Frame.Navigate(typeof(MainPage));
        }
    }
}