using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HairAndNailData.Model;
using HairAndNailData;

namespace HairAndNail
{
    public partial class Pomoc : Form
    {
        public Pomoc()
        {
            InitializeComponent();
            string zadnjeOtvorenaForma = Application.OpenForms[Application.OpenForms.Count - 1].Text;
            label1.ForeColor = Color.Red;

            if (zadnjeOtvorenaForma=="UpravljanjeUlogama")
            {
                lblTekst.Text = "Nesto";
            }
            if (zadnjeOtvorenaForma == "EvidencijaZaposlenika")
            {
                lblTekst.Text = "-Na ovoj formi vidimo popis svih smjena. \r\n \r\n-Kako bi dodali smjenu, kliknemo na gumb za dodavanje smjenu, te se otvara nova forma. Isto vrijedi za azuriranje. Za brisanje \r\n\r\nsmjene samo oznacimo smjenu koju zelimo obrisati. \r\n\r\n -Kako bi dodali zaposlenika u smjenu, odaberemo zaposlenika iz padajućeg izbornika i smjenu iz popisa smjena\r\n\r\n i kliknemo na gumb Dodaj zaposlenika u smjenu. \r\n\r\n -Kako bi azurirali smjenu zaposleniku, odaberemo postojecu smjenu za tog zaposlenika i \r\n\r\n odaberemo smjenu koju zelimo iz popisa svih smjena i kliknemo na gumb Azuriraj zaposlenikovu smjenu. \r\n\r\n- Za brisanje zaposlenika iz smjene, samo odaberemo tu zaposlenikovu smjenu iz popisa i kliknemo na Obrisi zaposlenika iz smjene. \r\n\r\n -Znak x u gornjem desnom kutu je za izlaz.";
            }
            if (zadnjeOtvorenaForma == "DodajPopust")
            {
                lblTekst.Text = "-Potrebno je popuniti sve podatke u formi. \r\n \r\n-Paziti kod odabira datum da je datum kraja veći od datuma početka\r\n \r\n-Kada se podaci popune, popust će biti dodan/ažuriran.\r\n\r\n-Znak x u gornjem desnom kutu je za izlaz iz funkcionalnosti.";
            }
            if (zadnjeOtvorenaForma == "DodajSmjenu")
            {
                lblTekst.Text = "-Potrebno je popuniti sve podatke u formi. \r\n \r\n-Paziti kod odabira vremena da je vrijeme kraja manje od vremena početka\r\n \r\n-Kada se podaci popune, smjena će biti dodana/ažurirana.\r\n\r\n-Znak x u gornjem desnom kutu je za izlaz iz funkcionalnosti.";
            }
            if (zadnjeOtvorenaForma == "DodajZaposlenika")
            {
                lblTekst.Text = "-Potrebno je popuniti sve podatke u formi. \r\n \r\n-Paziti da se ispune svi podaci i da se podaci ispune točno\r\n \r\n-Kada se podaci popune, zaposlenik će biti dodan/ažuriran.\r\n\r\n-Znak x u gornjem desnom kutu je za izlaz iz funkcionalnosti."; 
            }
            if (zadnjeOtvorenaForma == "PregledPopusta")
            {
                lblTekst.Text = "-Na ovoj formi vidimo prikaz trenutnih popusta\r\n \r\n-Najbitniji je kod računa koji se koristi prilikom korištenja usluge.\r\n\r\n-Znak x u gornjem desnom kutu je za izlaz iz funkcionalnosti.";
            }
            if (zadnjeOtvorenaForma == "PrivremenaForma")
            {
                lblTekst.Text = "-Na formi vidimo sve moguće funkcionalnosti.\r\n\r\n-Odabirom pojedinih funkcionalnosti otvara se forma za tu funkcionalnost.\r\n\r\n-Znak x u gornjem desnom kutu je za izlaz.";
            }
            if (zadnjeOtvorenaForma == "PrivremeniLogin")
            {
                lblTekst.Text = "-Privremeni login za aplikaciju.Potrebno je odabrati korisnika";
            }
            if (zadnjeOtvorenaForma == "UpravljanjePopustima")
            {
                lblTekst.Text = "-Na formi vidimo prikaz svih popusta.\r\n\r\n-Odabirom na dodaj popust, otvara se forma na kojoj se dodaje novi popust.\r\n\r\n-Odabirom ažuriraj popust otvara se forma na kojoj se ažurira popust odabran u prikazu svih popusta.\r\n\r\n-Odabirom obriši popust briše se popust odabran u prikazu svih popusta.\r\n\r\n-Znak x u gornjem desnom kutu je za izlaz iz funkcionalnosti.";
            }
            if (zadnjeOtvorenaForma == "UpravljanjeUlogama")
            {
                lblTekst.Text = "-Na formi vidimo prikaz svih tipova korisnika u pregledu.\r\n\r\n-Odabirom gumba dodaj tip, dodaje se novi tip korisnika s podacima iz tekstualnih okvira 'Naziv uloge' i 'Opis uloge'.\r\n\r\n Potrebno je popuniti oba podatka.\r\n\r\n-Odabirom gumba ažuriraj tipa korisnika ažurira se tip korisnika s podacima iz tekstualnih okvira 'Naziv uloge' i 'Opis uloge'.\r\n\r\n " +
                                "Potrebno je popuniti oba podatka.\r\n\r\n-Odabirom obriši tip korisnika briše se tip korisnika odabran u prikazu svih tipova korisnika.\r\n\r\n-Odabirom gumba dodaj ulogu tipu dodaje se tip korisnika selektiran u prikazu ulozi selektiranoj u ulogama\r\n\r\n-Odabirom gumba obrisi ulogu tipu briše se tip korisnika selektiran u prikazu ulozi selektiranoj u ulogama\r\n\r\n-Znak x u gornjem desnom kutu je za izlaz iz funkcionalnosti.";
            }
            if (zadnjeOtvorenaForma == "UpravljanjeZaposlenicima")
            {
                lblTekst.Text = "-Na formi vidimo prikaz svih zaposlenika.\r\n\r\n-Odabirom na dodaj zaposlenika, otvara se forma na kojoj se dodaje novi zaposlenik.\r\n\r\n-Odabirom ažuriraj zaposlenika otvara se forma na kojoj se ažurira zaposlenika odabran u prikazu svih zaposlenika.\r\n\r\n-Odabirom obriši popust briše se zaposlenik odabran u prikazu svih zaposlenika.\r\n\r\n-Znak x u gornjem desnom kutu je za izlaz iz funkcionalnosti.";
            }
            if (zadnjeOtvorenaForma == "MjesecnaIzvjesca")
            {
                lblTekst.Text = "-Forma prikazuje mjesećna izvješća po odabranom datumu. \r\n\r\n Kako bi prikazali izvješće, odaberemo datum od kad i do kad želimo da se prikaže izvješće i kliknemo na gumb Prikazi Izvješće";
            }
        }

        private void Pomoc_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }
    }
}
