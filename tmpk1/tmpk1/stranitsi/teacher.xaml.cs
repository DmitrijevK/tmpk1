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
                Ltext = "Natalja Salmus ",
                Limage = "Eesti keel, Karjaariopetus",
                lDetail = "Natalja.Salmus@mahtra.edu.ee"
            });

            uchetelja.Add(new classs()
            {
                Ltext = "Svetlana Todorovskaja",
                Limage = "Eesti keel",
                lDetail = "Svetlana.Todorovskaja@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Rita Rumm",
                Limage = "Eesti keel",
                lDetail = "Rita.Rumm@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Aleksandra Jakovtsenko",
                Limage = "Eesti keel, Vene keel",
                lDetail = "Aleksandra.Jakovtsenko@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Nastasia Klimenko",
                Limage = "Eesti keel, Klassiopetaja",
                lDetail = "Nastasia.Klimenko@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Julia Morozova",
                Limage = "Eesti keel",
                lDetail = "Julia.Morozova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Marina Virolainen",
                Limage = "Eesti keel",
                lDetail = "Marina.Virolainen@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Julia Lentsman",
                Limage = "Eesti keel, Klassiopetaja",
                lDetail = "Julia.Lentsman@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Elina Kartsev",
                Limage = "Inglise keel",
                lDetail = "Elina.Kartsev@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Ljudmila Mazurkevits",
                Limage = "Inglise keel",
                lDetail = "Ljudmila.Mazurkevits@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Inessa Agamirova",
                Limage = "Inglise keel",
                lDetail = "Inessa.Agamirova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Maria Seleznjova",
                Limage = "Vene keel",
                lDetail = "Maria.Seleznjova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Ludmilla Krjukova",
                Limage = "Vene keel",
                lDetail = "Ludmilla.Krjukova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Natalia Fedotova",
                Limage = "Математика",
                lDetail = "Natalia.Fedotova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Margarita Maksimova",
                Limage = "Математика",
                lDetail = "Margarita.Maksimova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Svetlana Stupina",
                Limage = "Keemia, Loodusopetus",
                lDetail = "Svetlana.Stupina@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Natalja Antonova",
                Limage = "Keemia, Loodusopetus",
                lDetail = "Natalia.Antonova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Anna Sulipa",
                Limage = "Bioloogia, Geograafia",
                lDetail = "Anna.Sulipa@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Liudmila Kuzichkina",
                Limage = "История, Uhiskonnaopetus, Vene keel",
                lDetail = "Liudmila.Kuzichkina@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Olga Jermolajeva",
                Limage = "История, Klassiopetaja",
                lDetail = "Olga.Jermolajeva@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Natalia Hort",
                Limage = "История, Klassiopetaja",
                lDetail = "Natalia.Hort@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Ljudmila Verzbitskaja",
                Limage = "Muusika",
                lDetail = "Ljudmila.Verzbitskaja@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Inna Ermel",
                Limage = "Muusika",
                lDetail = "Inna.Ermel@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Piret Peil",
                Limage = "Kunst",
                lDetail = "Piret.Peil@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Svetlana Tsabijeva",
                Limage = "Käsitoo ja kudundus",
                lDetail = "Svetlana.Tsabijeva@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Nikolai Andriankov",
                Limage = "Tehnoloogia",
                lDetail = "Nikolai.Andriankov@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Ljubov Kozorkova",
                Limage = "Kehaline kasvatus",
                lDetail = "Ljubov.Kozorkova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Margarita Muursepp",
                Limage = "Kehaline kasvatus",
                lDetail = "Margarita.Muursepp@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Jevgenia Mostovaja",
                Limage = "Algkool, Klassiopetaja",
                lDetail = "Evgenia.Mostovaja@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Anna Nasretdinova",
                Limage = "Algkool, Klassiopetaja",
                lDetail = "Anna.Nesretdinova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Tatjana Savitskaja",
                Limage = "Algkool, Klassiopetaja",
                lDetail = "Tatjana.Savitskaja@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Irina Ivaskevits",
                Limage = "Fuusika, Loodusopetus",
                lDetail = "Irina.Ivaskevits@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Lada Kudrjašova",
                Limage = "Algkool, Klassiopetaja",
                lDetail = "Lada.Kudrjasova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Svetlana Borovikova",
                Limage = "Algkool, Klassiopetaja",
                lDetail = "Lada.Kudrjasova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Juta Tsurilina",
                Limage = "Algkool, Klassiopetaja",
                lDetail = "Juta.Tsurilina@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Julia Lapsina",
                Limage = "Математика",
                lDetail = "Juulia.Lapsina@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Galina Saburova",
                Limage = "Vene keel",
                lDetail = "Galina.Saburova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Natalja Semenkova",
                Limage = "Eesti keel",
                lDetail = "Natalia.Semenkova@mahtra.edu.ee"
            });
            uchetelja.Add(new classs()
            {
                Ltext = "Jelena Demjantsuk",
                Limage = "Eesti keel, IT-juht",
                lDetail = "infojuht@mahtra.edu.ee"
            });

            return uchetelja;
        }



        public void OnMore(object sender, EventArgs e)
        {
            
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }
        private void listik_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
        }
    }
}