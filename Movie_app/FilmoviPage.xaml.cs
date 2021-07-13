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
    public partial class FilmoviPage : ContentPage
    {
        public FilmoviPage()
        {
            InitializeComponent();
        }
        private void Major_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Direktor fotografije: Mihailo Ivanjikov Scenografija: Kosta Krivokapić Muzika: Fran Lhotka Montaža: Ruža Cvingl Uloga: Carka Jovanović, Marijan Lovrić, Dragomir Felba, Joža Gregorin, Vjekoslav Afrić, Bogdan Kužet, Fran Novaković, Vaso Kosić    Sinopsis: Pored leša nepoznatog čovjeka, za kojeg četnici pretpostavljaju da je legendarni major Bauk, Baukova majka se sjeća njegovog djetinjstva provedenog u napornom radu, štrajkovima i sukobima s policijom. Sjeća se okupacije 1941. godine, prve Baukove pobjede nad njemačkim okupatorima i prvog sukoba s četničkim izdajicama, koji svim silama pokušavaju uništiti majora Bauka i partizane. Gledajući izgorjeli leš, Baukova majka steže srce i ne priznaje da je to njen sin. Četnici ipak likuju, vjerujući da je Bauk mrtav, ali kada partizani ponovo polaze u napad pod Baukovim imenom, legenda o besmrtnom Bauku stvara kod njih paniku, koju ni specijalni izaslanik Draže Mihajlovića ne može da spriječi. Dok traju unutarnja obračunavanja među četnicima, proleteri oslobađaju selo i narod. U znak zahvalnosti, formira se novi odred koji nosi ime legendarnog narodnog heroja – majora Bauka.", "OK");
        }

        private void TudaZemlja_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Direktor fotografije: Ivan Marinček Scenografija: Džemo Ćesović Muzika: Bojan Adamič Montaža: Ruža Cvingl Uloga: Milorad Margetić, Ilija Džuvalekovski, Rade Marković, Stane Potokar, Tamara Miletić, Marija Crnobori, Milutin Jasnić, Tomo Kuruzović, Mihajlo Bata Paskaljević    Sinopsis: Nakon kapitulacije Italije jedna manja grupa talijanskih vojnika, bježeći iz Sandžaka, prelazi Drinu i ulazi u bosanske šume.Nošeni željom da se domognu svoje kuće, lutaju opustošenim krajevima i doživljavaju istinu o ratu koja im je do tada bila nepoznata.U jednoj kući nalaze Simku, ratnu udovicu s dvoje male djece.Jurini, liječnik, zadobiva njeno povjerenje i liječi kod nje skrivenu partizanku Miru, koja je upravo od njih pobjegla i pri bježanju ranjena.Franceschi, najokorjeliji od njih, otkriva partizanku i pokušava je ubiti, ali ga u tome sprečava Marko, koji je u međuvremenu zavolio Miru. U sukobu ubija Marka, ali i on pada u ruke svojih drugova koji su revoltirani Franceschinim krvološtvom. Nakon toga, najbolji među njima nalaze snage da pomognu tom tuđem narodu u borbi za slobodu, dok drugi nastavljaju putem zločina.", "OK");
        }

        private void Solaja_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Direktor fotografije: Eduard Bogdanić Scenografija: Vlado Branković Muzika: Krešimir Baranović Montaža: Milanka Nanović Uloga: Milivoje Živanović, Rade Marković, Renata Ulmanski, Janez Vrhovec, Pavle Vuisić, Olivera Marković    Sinopsis: Okolina Mrkonjić - Grada 1941.godine.Spontanim otporom protiv ustaškog terora rukovodi Simela Šolaja, čovjek buntovne prirode i izuzetne snage.U istoj okolini bori se i partizanski odred pod Prolinom komandom.Pod dramatičnim okolnostima dolazi do zbližavanja njihovih odreda i do zajedničkog oslobađanja Mrkonjić - Grada.Četnička komanda, kojoj ne ide u prilog ovo jačanje naprednih snaga, organizira potajno ubojstvo Prole i jednog skojevca – muslimana, okrivljujući za to Šolaju. Duboko uvrijeđen i ogorčen, Šolaja napušta odred i vraća se kući, a njegov odred preživljava tešku krizu.Uvidjevši da njegovo mirovanje koristi samo neprijatelju, Šolaja se odluči vratiti partizanima, ali ga četnici iznenade i zarobe. Iskoristivši pogodan trenutak, Šolaja bježi i vraća se partizanima, s kojima priprema oslobađanje Kupresa. Međutim, u odlučnom času izostaje pomoć koju su četnici obećali i Šolaja herojski gine na ulicama grada kome je donio slobodu.", "OK");
        }

        private void Pod_Sumnjom_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Direktor fotografije: Hrvoje Sarić Scenografija: Džemo Ćesović, Strahinja Petrović Kostimografija: Jagoda Bujić - Bonetti Muzika: Silvio Bombardelli Montaža: Blaženka Jenčik Uloga: Tamara Miletić Marković, Milorad Margetić, Mirko Vojković, Božo Jajčanin, Josip Zappalorto, Marija Aljinović Autor priče: Grga Gamulin    Sinopsis: Ljeto 1943. godine u jednom zarobljeničkom logoru u južnoj Italiji. Četvorica partizana bježe iz logora, ali samo jedan, Andre Narančić, stigne živ na rodni otok. Međutim, njegova porodica je u dobrim odnosima s italijanskim okupatorima: njegov rođak je comissario civile, a sestra Marija je zaljubljena u italijanskog kapetana. Ne znajući za njegovo bjekstvo, oni su isposlovali od talijanskih vlasti da ga puste na slobodu. Kompromitiran kod partizana, Andre proživljava sudbonosne časove pod sumnjom da je kriv za smrt svojih drugova koji su s njim krenuli u bjekstvo. Prilikom pokušaja da uspostavi direktan dodir s partizanima dospijeva u partizanski zatvor. Odatle bježi uz pomoć učiteljice Veronike, svoje djevojke. Od svog rođaka commissaria uspijeva saznati plan likvidacije partizanskog odreda i otkriva pravog izdajicu. U posljednjem času sprečava tragediju i dokazuje svoju nevinost.", "OK");
        }
        private void Klisura_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Direktor fotografije: Aleksandar Sekulović Scenografija: Dragoljub Lazarević Muzika: Bojan Adamič Montaža: Ruža Cvingl Uloga: Ilija Džuvalekovski, Rolf Wanka, Katarina Nayberg, Marianne Schonauer Producent: Dana Nikiforović, Ernst Roberts     Sinopsis: Mišel i njegova suradnica Elen borave u gorštačkom kraju. Mišel pokazuje znakove teškog oboljenja. Kada ga Elen jednog dana ne nađe u šatoru, zabrine se. Međutim, njega je onesviještenog našao Ramadan i sklonio ga u svoju kuću, gdje ga njeguje njegova žena Ajka. Između Mišela i Ajke razvija se opasna igra, koju zapaze i Ramadan i Elen. Mrki, u sebe povučeni gorštak, koga je počela razdirati sumnja, traži nepobitan dokaz koji bi mu dao pravo da ih oboje ubije. Mišel osjeća da Ramadan sluti nešto i obuzima ga sve veći strah. Jednog dana obojica padaju sa skele na kojoj su radili. Dok obojica vise nad vodopadom držeći se za gredu koja svaki čas može prsnuti, Ajka trči obalom sa konopcem u ruci u nedoumici koga spasiti. Mišel je, u smrtnoj panici, preklinje da mu baci konopac, jer će je inače Ramadan ubiti. U tom času, Ajka odlučno baca konopac Ramadanu.", "OK");
        }
        private void Hanka_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "Direktor fotografije: Milenko Mišo Stojanović Scenografija: Dragoljub Lazarević Kostimografija: Dragoljub Lazarević Muzika: Ilija Marinković Montaža: Slavko Vorkapić Uloga: Vera Gregović, Jovan Milićević, Mira Stupica, Mišo Mrvaljević, Vaso Kosić, Dejan Dubajić Autor priče: Isak Samokovlija    Sinopsis: Romkinja Hanka zaljubljena je u ponosnog i ambicioznog Roma Sejdu, koji u planini izrađuje drveni ugalj.Međutim, bogati seoski starješina, ceribaša Ahmed, želi da se Hanka uda za njegovog sina Mušana.Kad to Hanka odbije, ceribaša organizira otmicu, ali Sejdo uspije da je spasi i uskoro se vjenčaju.Da se osveti Sejdi, ceribaša podmiti šumara koji zabrani Sejdi rad u planini.Ogorčen, Sejdo zapali ceribašinu kovačnicu, zbog čega dospije u zatvor.Po izlasku iz zatvora ne može se nigdje zaposliti.Bogata i pohotna Hankina rođaka Ajkuna prima ga na svoje imanje i, otkrivši njegove slabosti, lako ga privoli da postane njen ljubavnik.Kad ga uskoro zamijeni drugim ljubavnikom, Sejdo se odluči vratiti Hanki.Povrijeđena u svojoj čistoj ljubavi, Hanka mu se sveti na neobičan način: izjavi mu da je bila Mušanova ljubavnica i da nosi Mušanovo dijete.U ljubomori, Sejdo ubija Hanku i tek tada saznaje da je bila nevina i da je do posljednjeg časa voljela samo njega.", "OK");
        }
    }
}