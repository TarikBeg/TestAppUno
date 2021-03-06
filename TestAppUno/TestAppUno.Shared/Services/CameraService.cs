﻿using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using JoesBurgerStore.Contracts;
using TestXamarinApp.Contracts;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Services.Media;

namespace JoesBurgerStore.Services
{
    public class CameraService : ICameraService
    {
        /// <summary>
		/// The _scheduler.
		/// </summary>
		private readonly TaskScheduler _scheduler = TaskScheduler.FromCurrentSynchronizationContext();

        /// <summary>
        /// The picture chooser.
        /// </summary>
        private IMediaPicker _mediaPicker;

        /// <summary>
        /// The image source.
        /// </summary>
        //private ImageSource _imageSource;

        private string _status;
        public static SimpleIoc ServiceProvider { get; } = SimpleIoc.Default;

        /// <summary>
        /// Setups this instance.
        /// </summary>
        private void Setup()
        {
            if (_mediaPicker != null)
            {
                return;
            }

            try
            {
                var device = Resolver.Resolve<IDevice>();
                _mediaPicker = device.MediaPicker;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            ////RM: hack for working on windows phone? 
        }

        /// <summary>
        //kes the picture.
        /// </summary>

        // <returns>Take Picture Task.</returns>
        public async Task<MediaFile> TakePicture()
        {
            Setup();

            //_imageSource = null;

            return await _mediaPicker.TakePhotoAsync(new CameraMediaStorageOptions { DefaultCamera = CameraDevice.Front, MaxPixelDimension = 400 }).ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    _status = t.Exception.InnerException.ToString();
                }
                else if (t.IsCanceled)
                {
                    _status = "Canceled";
                }
                else
                {
                    var mediaFile = t.Result;

                    //_imageSource = ImageSource.FromStream(() => mediaFile.Source);

                    return mediaFile;
                }

                return null;
            }, _scheduler);
        }
    }
}
