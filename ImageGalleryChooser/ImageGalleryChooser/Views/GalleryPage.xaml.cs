using FFImageLoading.Forms;
using ImageGalleryChooser.Model;
using ImageGalleryChooser.ViewModel;
using Naylah.Xamarin.Controls.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ImageGalleryChooser.Views
{
    public partial class GalleryPage : ContentPage
    {
        private GalleryViewModel vm => (GalleryViewModel)BindingContext;

        public GalleryPage()
        {
            InitializeComponent();
            BindingContext = new GalleryViewModel();

            var gesture = new TapGestureRecognizer();
            gesture.SetBinding(TapGestureRecognizer.CommandProperty, Binding.Create<GalleryViewModel>(x => x.NavigateToImageDetailCommand));
            imgDetail.GestureRecognizers.Add(gesture);
        }

        private void ImageGalleryView_ItemClick(object sender, object e)
        {
            vm.PreviewImageCommand.Execute((ImageItem)e);
        }
    }
}