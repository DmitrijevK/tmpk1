using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tmpk1.stranitsi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class school : TabbedPage
    {
        public school()
        {
            InitializeComponent();
        }

        private async void svjaz_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://ru.stackoverflow.com"));
        }
    }
}