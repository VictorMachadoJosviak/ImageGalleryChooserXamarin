using GalaSoft.MvvmLight;
using Naylah.Xamarin.Services.NavigationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryChooser.ViewModel
{
    public class AppViewModelBase : ViewModelBase, INavigable
    {
        public new INavigationService NavigationService { get { return App.CurrentApp.NavigationService; } }

        public virtual async Task OnNavigatedFromAsync()
        {
        }

        public virtual async Task OnNavigatedToAsync(object parameter, NavigationMode mode)
        {
        }

        public virtual async Task OnNavigatingToAsync(object parameter, NavigationMode mode)
        {
        }
    }
}