using GalaSoft.MvvmLight.Command;
using ImageGalleryChooser.Model;
using ImageGalleryChooser.Views;
using Naylah.Xamarin.Controls.Choosers;
using Naylah.Xamarin.Services.NavigationService;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryChooser.ViewModel
{
    public class GalleryViewModel : AppViewModelBase
    {
        public override async Task OnNavigatedFromAsync()
        {
            await LoadData(SelectedImage);
        }

        public GalleryViewModel()
        {
            LoadData(SelectedImage);
        }

        private async Task LoadData(ImageItem param)
        {
            try
            {
                Images = new ObservableCollection<ImageItem>();

                var aux = new ObservableCollection<ImageItem>();

                if (param != null)
                    aux.Add(param);

                aux.Add(new ImageItem { Image = "http://www.sitedeimagens.com/imagens/imagens-lindas-imagens-lindas-natureza-facebook-3.jpg" });
                aux.Add(new ImageItem { Image = "https://cdn.mensagenscomamor.com/resize/400x225/content/images/int/frases_sobre_natureza.jpg" });
                aux.Add(new ImageItem { Image = "http://img.elo7.com.br/product/main/5489C0/painel-natureza.jpg" });
                aux.Add(new ImageItem { Image = "http://blog.usenatureza.com/wp-content/uploads/2015/10/flores-montanhas-beleza-natureza.jpeg" });

                // create auxiliary list for the itemsource Xamarin recognize the binding is a bug Xamarin
                Images = aux;

                if (Images.FirstOrDefault() != null)
                {
                    SelectedImage = Images.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public RelayCommand ChooseImageCommand => new RelayCommand(async () => await ChooseImage());

        private async Task ChooseImage()
        {
            try
            {
                var imgChooser =

             ImageChooser.CreateImageChooser(
                 new ImageChooser.ImageChooserOptions()
                 {
                     Title = "Image Chooser",
                     ActualImageUri = null,
                     SelectionButtonText = "Select",
                     SizeRequested = new global::Xamarin.Forms.Size(1366, 768),
                     DoneSelectionAction = SelectImage,
                 });

                await NavigationService.NavigateAsync(
                    imgChooser, null, true);
            }
            catch (Exception ex)
            {
            }
        }

        private async Task SelectImage(IFile arg)
        {
            try
            {
                SelectedImage = new ImageItem { Image = arg.Path };

                await NavigationService.GoBack();
            }
            catch (Exception ex)
            {
            }
        }

        public RelayCommand<ImageItem> PreviewImageCommand => new RelayCommand<ImageItem>(async (v) => await PreviewImage(v));

        private async Task PreviewImage(ImageItem image)
        {
            try
            {
                if (image == null) { return; }
                SelectedImage = image;
            }
            catch (Exception e)
            {
            }
        }

        public RelayCommand NavigateToImageDetailCommand => new RelayCommand(() =>
        {
            NavigationService.NavigateAsync(new ImageDetailPage(), SelectedImage, true);
        });

        private ObservableCollection<ImageItem> _images;

        public ObservableCollection<ImageItem> Images
        {
            get { return _images; }
            set { Set(ref _images, value); }
        }

        private ImageItem _selectedImage;

        public ImageItem SelectedImage
        {
            get { return _selectedImage; }
            set { Set(ref _selectedImage, value); }
        }
    }
}