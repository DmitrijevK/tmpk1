using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tmpk1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vkl : ContentPage
    {
        public vkl(string image)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            LogoAnimation(image);
        }

        public async Task LogoAnimation(string image)
        {
            if (string.IsNullOrWhiteSpace(image))
            {
                imgLogo.Source = "logo.png";
            }
            else
            {
                imgLogo.Source = image;
            }

            imgLogo.Opacity = 0;
            await imgLogo.FadeTo(1, 3000);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}