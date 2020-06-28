using System;
using TestAppUno.ViewModels;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestAppUno.Shared.Content
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderBurger : Page
    {
        public OrderBurger()
        {
            this.InitializeComponent();

            DataContext = new OrderBurgersViewModel();
        }

        public void Button_Click(object sender, EventArgs e)
        {
            var c = listView.DataContext;
        }

        private void ListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
            Frame.Navigate(typeof(BurgerDetail), listView.SelectedItem);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
