using System.Collections.ObjectModel;
using System.Windows.Input;
using TestAppUno.Contracts.ViewModels;
using TestAppUno.Extensions;
using TestAppUno.Model;
using TestAppUno.ViewModels.Base;

namespace TestAppUno.ViewModels
{
    public class OrderBurgersViewModel : ViewModelBase, IOrderBurgersViewModel
    {
        public ObservableCollection<Burger> Burgers { get; set; }
        public ObservableCollection<BurgerGroup> BurgerGroups { get; set; }

        public ICommand LoadCommand { get; set; }

        public OrderBurgersViewModel()
        {

            //Burgers = burgerDataService.GetAllBurgers().ToObservableCollection();
            Burgers = this.BurgerDataService.GetAllBurgers().ToObservableCollection();
        }
    }
}
