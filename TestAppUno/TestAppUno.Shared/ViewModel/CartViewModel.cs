using JoesBurgerStore.Contracts.ViewModels;
using System.Collections.ObjectModel;
using TestAppUno.Extensions;
using TestAppUno.Model;
using TestAppUno.ViewModels.Base;

namespace TestAppUno.ViewModels
{
    public class CartViewModel : ViewModelBase, ICartViewModel
    {
        public ObservableCollection<CartItem> CartItems { get; set; }

        public CartViewModel()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            CartItems = CartDataService.GetCart().CartItems.ToObservableCollection();
        }
    }
}