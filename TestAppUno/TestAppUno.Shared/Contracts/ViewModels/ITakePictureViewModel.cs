using System.ComponentModel;
using Windows.UI.Xaml.Media;

namespace TestAppUno.Contracts.ViewModels
{
    public interface ITakePictureViewModel : INotifyPropertyChanged
    {
        ImageSource ImageSource { get; set; }
    }
}