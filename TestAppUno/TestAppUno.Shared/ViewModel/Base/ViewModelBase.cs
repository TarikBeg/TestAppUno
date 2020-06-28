using GalaSoft.MvvmLight.Ioc;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TestAppUno.Contracts;
using TestAppUno.Models;
using TestAppUno.Services;

namespace TestAppUno.ViewModels.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public static SimpleIoc ServiceProvider { get; } = SimpleIoc.Default;

        private bool _isBusy;
        public IDataStore<Item> DataStore => ServiceProvider.GetInstance<IDataStore<Item>>();
        public IBurgerDataService BurgerDataService => ServiceProvider.GetInstance<IBurgerDataService>();
        public ICartDataService CartDataService => ServiceProvider.GetInstance<ICartDataService>();

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        [Anntotations.NotifyPropertyChangedInvocatorAttribute]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual Task InitializeAsync(object data)
        {
            return Task.FromResult(false);
        }
    }
}