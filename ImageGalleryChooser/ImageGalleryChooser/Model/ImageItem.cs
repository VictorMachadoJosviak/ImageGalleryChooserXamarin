using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryChooser.Model
{
    public class ImageItem : ObservableObject
    {
        public string Image { get; set; }
    }
}