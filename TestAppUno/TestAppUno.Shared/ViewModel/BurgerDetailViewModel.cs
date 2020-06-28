using MvvmHelpers.Commands;
using System.Windows.Input;
using TestAppUno.Contracts.ViewModels;
using TestAppUno.Model;
using TestAppUno.ViewModels.Base;

namespace TestXamarinApp.ViewModels
{
    public class BurgerDetailViewModel : ViewModelBase, IBurgerDetailViewModel
    {
        //private INavigationService _navigationService;
        //private IUserDataService _userDataService;
        private Burger _selectedBurger;
        private int _amount;
        public ICommand AddToCartCommand => new Command(OnAddToCart);

        private void OnAddToCart(object obj)
        {
            CartDataService.AddCartItem(SelectedBurger, Amount);
        }

        public ICommand ReadDescriptionCommand { get; set; }


        public int Amount
        {
            get { return _amount; }
            set { _amount = value; OnPropertyChanged("Amount"); }
        }

        public Burger SelectedBurger
        {
            get
            {
                return _selectedBurger;
            }
            set
            {
                _selectedBurger = value;
                OnPropertyChanged("SelectedBurger");
            }
        }

        public BurgerDetailViewModel(object objectToPass)
        {
            SelectedBurger = objectToPass as Burger;
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            //ReadDescriptionCommand = new Command(() =>
            //{
            //    DependencyService.Get<ITextToSpeech>().Read(SelectedBurger.ShortDescription);
            //});
        }
    }
}
