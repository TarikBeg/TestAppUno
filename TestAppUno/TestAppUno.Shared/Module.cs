using GalaSoft.MvvmLight.Ioc;
using JoesBurgerStore.Services;

/* Unmerged change from project 'TestAppUno.macOS'
Before:
using TestAppUno.Contracts;*/
using TestAppUno.Contracts;
using TestAppUno.Models;
using TestAppUno.Services;
using TestXamarinApp.Contracts;

namespace TestAppUno.Shared
{
    public class Module
    {
        public static void Initialize(SimpleIoc serviceProvider)
        {
            serviceProvider.Register<IBurgerDataService>(() => new BurgerDataService());
            serviceProvider.Register<IDataStore<Item>>(() => new MockDataStore());
            serviceProvider.Register<ICartDataService>(() => new CartDataService());
            serviceProvider.Register<ICameraService>(() => new CameraService());
        }
    }
}