using Naylah.Xamarin.Controls.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageGalleryChooser.Common
{
    public class DefaultStyleKit : StyleKit
    {
        public DefaultStyleKit()
        {
            PrimaryColor = Color.FromHex("#0F0F43");
            PrimaryDarkColor = Color.FromHex("#181829");
            PrimaryLightColor = Color.FromHex("#E1BEE7");
            SecondaryColor = Color.FromHex("#9C27B0");
            SecondaryDarkColor = Color.FromHex("#7B1FA2");
            AccentColor = Color.FromHex("#ff0074");
            PrimaryTextColor = Color.FromHex("#212121");
            SecondaryTextColor = Color.FromHex("#ffffff");
            DividerColor = Color.FromHex("#B6B6B6");
            WindowColor = PrimaryDarkColor;
        }
    }
}