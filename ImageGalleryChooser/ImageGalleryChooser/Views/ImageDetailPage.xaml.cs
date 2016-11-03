using ImageGalleryChooser.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ImageGalleryChooser.Views
{
    public partial class ImageDetailPage : ContentPage
    {
        public ImageDetailPage()
        {
            InitializeComponent();
            BindingContext = new ImageDetailViewModel();
        }
    }
}