using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movie_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            var images = new List<string>
            {
                "https://upload.wikimedia.org/wikipedia/sh/8/84/%D0%89%D0%B5%D1%82%D0%BE_%D1%83_%D0%B7%D0%BB%D0%B0%D1%82%D0%BD%D0%BE%D1%98_%D0%B4%D0%BE%D0%BB%D0%B8%D0%BD%D0%B8.jpg","https://upload.wikimedia.org/wikipedia/bs/5/56/Grbavica_poster.jpg?fbclid=IwAR2GaZj_9wst6QraJ8TJGNm9hRx1Ga-on9gMERQEWm9egIG-GqUDCZ8vhnk","https://upload.wikimedia.org/wikipedia/bs/2/2a/On_the_Path.jpg?fbclid=IwAR2wIFxL8DQEv_8StpxMr6vluPKRkJmAqirGuoqFQgHFDfGaoAqQJZOz2Yk"
            };
            MainCarouselView.ItemsSource = images;
            Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() =>
            {
                MainCarouselView.Position = (MainCarouselView.Position + 1) % images.Count;
                return true;
            }));
        }

        private void aida_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "S velikom žalošću obaviještavamo članove i kolege da nas je jučer napustila naša članica Aida Čaušević. Aida Čaušević je rođena u Sarajevu 1968. Od 1989. godine radila je u JS BiH - FTV. Kao sekretarica režije počela je raditi 1992. godine, a na filmu radila je od 2000. godine. Neki od filmova na kojima je radila su JA SAM IZ KRAJINE, ZEMLJE KESTENA(2013), BODY COMPLETE(2012), SEVDAH ZA KARIMA(2010), JASMINA(2010), NAFAKA(2006), RAM ZA SLIKU MOJE DOMOVINE(2005), PRVA PLATA(2005), PRVO SMRTNO ISKUSTVO(2001), TUNEL(2000), itd. Udruženje filmskih radnika izražava saučešće porodici i kolegama naše članice Aide Čaušević.","OK");
        }

        private void ada_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Film Ade Hasanovića LET THERE BE COLOUR nagrađen je nagradom “Reflexions in the dark” na Lovers Film Festivalu u Torinu, najstarijem LGBTQI+ festivalu u Evropi i jedan od najbitnjih LGBT festivala u svijetu. Ova nagrada je posvećena režiserima LGTBQI + filmova koji rade ili su radili u zemljama s visokim rizikom diskriminacije.Nagradu je ustanovilo Ministarstva vanjsikh posvlova u Italiji, a ovo je prva godina da se nagrada dodjeljuje režiserima koji se bave LGBTQI + tematikom u državama u kojima se gej osobe suočavaju s diskriminacijom. Podsjećamo da je film LET THERE BE COLOUR premijerno prikazan na prošlogodišnjem Sarajevo Film Festivalu. Više informacija možete pronaći ovdje. ","OK");
        }

        private void anja_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "I dok novi izazov uzima zalet, pobjednica iz prethodnog kruga, Anja Kraljević, već uživa u osvojenoj nagradi. U nastavku, kako naša tradicija i nalaže, Anju možete upoznati kroz njeno iskustvo u izazovu i doživljaju filma uopšte. Anja Kraljević iz Mostara, mlada je bh.glumica i lice koje ćemo sa sigurnošću sve više gledati, kako u pozorišnim daskama tako i na kino platnima.O svojim počecima u struci kratko govori: Diplomirala sam 2020.godine na Akademiji scenskih umjetnosti u Sarajevu, na odsjeku gluma, u klasi profesora Ermina Brave.Nedavno sam imala premijeru u HNK Mostar i u Kamernom teatru 55 u Sarajevu. A kako mladu glumicu, ali i pobjednicu u filmskom izazovu, ne pitati o ljubavi prema sedmoj umjetnosti... Ljubav prema filmu seže od mog djetinjstva.Sjećam se nekadašnje videoteke ispod svoje zgrade u Mostaru, u koju sam ulazila svaki dan po neki film.Moj otac je ljubitelj filmskih klasika.I dan danas često zajedno gledamo filmove koje smo pogledali bar 10 puta.Obožavam kina.A dolaskom u Sarajevo, zaljubila sam se u Sarajevo Film Festival koji je postao omiljeni događaj godine. Za nešto bolje upoznavanje sa evropskom kinematografijom zahvalna je studiju u Sarajevu... Evropska kinematografija je jako širok pojam, ali sam vrlo zahvalna na studiju koji sam prošla, jer sam kroz njega uspjela bolje upoznati i približiti se evropskoj kinematografiji.Prošli smo kroz historiju filma i zahvaljujući odličnim profesorima fokusirali se i na mnoge zanimljive pravce van mainstreama. Pitali smo Anju i koje filmove je gledala tokom izazova, te za nezaobilaznu preporuku nekih od njih, a evo šta nam je rekla: Budući da je ovo prvi put da učestvujem u izazovu fokusirala sam se na pravila igre i trudila se da dobijem što je više moguće bonus bodova.Tako da se na mojoj listi našlo i nekoliko odličnih bh.filmova koje sam ranije gledala, ali preporučila bih svaki.Kako prolazi vrijeme, mi se mijenjamo i te iste filmove gledamo sasvim novim očima.I ja sam uživala u svakom kao da ga gledam prvi put. Anja se na EFC, kako kaže prijavila spontano.U razgovoru sa prijateljicama o samom izazovu i filmovima, proizašla je i njena odluka da okuša svoju sreću. Ona je svoju sretnu kartu iskoristila na najbolji način, a vas pozivamo da uplovite u posljednji dio trilogije ovog ciklusa takmičenja, družite se sa nama i evropskim filmskim junacima od 10.juna do 10.augusta, te osvojite vrijedne nagrade. Čekamo vas!","OK");
        }
    }
}