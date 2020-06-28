using System.ComponentModel;
using TestAppUno.Model;

namespace TestAppUno.Contracts.ViewModels
{
    public interface IBurgerDetailViewModel : INotifyPropertyChanged
    {
        Burger SelectedBurger { get; set; }
    }
}