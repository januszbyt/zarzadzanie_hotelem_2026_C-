using Panele_Glowne;

namespace Panel_Glowny
{
    public partial class Ekran_Glowny_Pracownika : Form
    {
        public Ekran_Glowny_Pracownika()
        {
            InitializeComponent();
        }
        public Ekran_Glowny_Pracownika(string ZalogowanyUzytkownik)
        {
            InitializeComponent();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Panel_Przypisania_Goscia_DoRezerwacji gosciepracownik = new Panel_Przypisania_Goscia_DoRezerwacji();
            gosciepracownik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista_Wszystkich_Pokojow pokoje = new Lista_Wszystkich_Pokojow();
            pokoje.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Okno_Rezerwacji_Obslugiwane_Przez_Pracownika rezerwacjePracownik = new Okno_Rezerwacji_Obslugiwane_Przez_Pracownika();
            rezerwacjePracownik.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dodaj_rezerwacje dodaj_Rezerwacje = new Dodaj_rezerwacje();
            dodaj_Rezerwacje.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ekran_Logowania_Klienta wyloguj = new Ekran_Logowania_Klienta();
            wyloguj.Show();
            this.Hide();
        }


        //private void label2_Click(object sender, EventArgs e)
        //{

        //}
    }
}
