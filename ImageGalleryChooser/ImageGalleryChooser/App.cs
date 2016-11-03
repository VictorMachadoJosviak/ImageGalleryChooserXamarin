using ImageGalleryChooser.Common;
using ImageGalleryChooser.Views;
using Naylah.Xamarin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageGalleryChooser
{
    public class App : BootStrapper
    {
        public static App CurrentApp { get; set; }

        public App()
        {
            CurrentApp = this;
            StyleKit = new DefaultStyleKit();
            NavigationServiceFactory(new NavigationPage(new GalleryPage()));
        }
    }
}