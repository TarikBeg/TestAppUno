using GalaSoft.MvvmLight.Ioc;
using TestAppUno.Contracts;
using TestAppUno.Models;
using TestAppUno.Services;

namespace TestAppUno.Shared
{
    public class Module
    {
        public static void Initialize(SimpleIoc serviceProvider)
        {
            serviceProvider.Register<IBurgerDataService>(() => new BurgerDataService());
            serviceProvider.Register<IDataStore<Item>>(() => new MockDataStore());
            serviceProvider.Register<ICartDataService>(() => new CartDataService());
        }
    }
}