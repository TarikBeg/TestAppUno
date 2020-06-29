using GalaSoft.MvvmLight.Ioc;
using JoesBurgerStore.Services;
using JoesBurgerStore.ViewModels;
using TestAppUno.Contracts;
using TestAppUno.Contracts.ViewModels;
using TestAppUno.Models;
using TestAppUno.Services;
using TestXamarinApp.Contracts;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Services;

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


            var container = new SimpleContainer();
            container.Register<IDisplay>(t => t.Resolve<IDevice>().Display);
            container.Register<INetwork>(t => t.Resolve<IDevice>().Network);

            Resolver.SetResolver(container.GetResolver());
        }
    }
}