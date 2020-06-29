using System;
using Windows.Foundation;
using Windows.Media.Capture;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using JoesBurgerStore.ViewModels;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestAppUno.Shared.Content
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TakePicture : Page
    {
        public TakePicture()
        {
            this.InitializeComponent();

            this.DataContext = new TakePictureViewModel();
        }
    }
}
