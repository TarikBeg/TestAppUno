using System;
using Windows.Foundation;
using Windows.Media.Capture;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


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
        }

        public async void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var captureUI = new CameraCaptureUI();
                captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
                captureUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200);

                var photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

                if (photo == null)
                {
                    return;
                }
                else
                {
                    var source = new BitmapImage(new Uri(photo.Path));
                    image.Source = source;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
	}
}
