using ImageGalleryChooser.Model;
using Naylah.Xamarin.Services.NavigationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryChooser.ViewModel
{
    public class ImageDetailViewModel : AppViewModelBase
    {
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode)
        {
            await LoadData((ImageItem)parameter);
        }

        public override async Task OnNavigatingToAsync(object parameter, NavigationMode mode)
        {
            ResetProps();
        }

        private void ResetProps()
        {
            SelectedImage = null;
        }

        private async Task LoadData(ImageItem param)
        {
            SelectedImage = param;
        }

        private ImageItem _SelectedImage;

        public ImageItem SelectedImage
        {
            get { return _SelectedImage; }
            set { Set(ref _SelectedImage, value); }
        }
    }
}