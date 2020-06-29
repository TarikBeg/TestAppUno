using MvvmHelpers.Commands;
using System.Windows.Input;
using TestAppUno.Contracts.ViewModels;
using TestAppUno.ViewModels.Base;
using Windows.UI.Xaml.Media;

namespace JoesBurgerStore.ViewModels
{
    public class TakePictureViewModel : ViewModelBase, ITakePictureViewModel
    {

        public ICommand TakePictureCommand { get; set; }

        private ImageSource _imageSource;

        public ImageSource ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                _imageSource = value;
                OnPropertyChanged("ImageSource");
            }
        }

        public TakePictureViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            TakePictureCommand = new Command(async () =>
            {
                var mediaFile = await CameraService.TakePicture();
            });
        }
    }
}
