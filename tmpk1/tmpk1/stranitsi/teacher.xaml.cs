using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tmpk1.stranitsi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class teacher : TabbedPage
    {
        public teacher()
        {
            InitializeComponent();
            listik.ItemsSource = Menulist();
        }

        private List<classs> Menulist()
        {
            var uchetelja = new List<classs>();
            uchetelja.Add(new classs()
            {
                Ltext = "Natalja Antonova",
                Limage = "Antonova",
                lDetail = "Natalia.Antonova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Anna Sulipa",
                Limage = "Sulipa",
                lDetail = "Anna.Sulipa@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Liudmila Kuzichkina",
                Limage = "Kuzichkina",
                lDetail = "Liudmila.Kuzichkina@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Olga Jermolajeva",
                Limage = "Jermolajeva",
                lDetail = "Olga.Jermolajeva@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Natalia Hort",
                Limage = "Hort",
                lDetail = "Natalia.Hort@mahtra.edu.ee"
            });
            return uchetelja;
        }

        private void listik_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
        }
    }
}