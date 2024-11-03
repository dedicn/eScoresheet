using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client.GuiController
{
    public class GameGuiController
    {
        private static GameGuiController instance;
        public static GameGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameGuiController();
                }
                return instance;
            }
        }

        private GameGuiController() { }

        private GameSpecs utakmica;
        AllGamesPanel games;
        GameUpdate gameUpdate;
        Utakmica utak;

        Utakmica vracena;

        private Tim domaci;
        private Tim gosti;

        internal Control CreateGameSpecsControl(Tim responseDomacin, Tim responseGost)
        {
            domaci = responseDomacin;
            gosti = responseGost;
            utakmica = new GameSpecs(responseDomacin.NazivTima, responseGost.NazivTima);
            utakmica.BtnSacuvajUtakmicu.Click += SaveGame;
            return utakmica;
        }

        private void SaveGame(object sender, EventArgs e)
        {
            if (!isValidInptu())
            {
                return;
            }

            Utakmica ut = new Utakmica()
            {
                UtakmicaID = int.Parse(utakmica.TxtSifraUtakmice.Text),
                VremePocetka = DateTime.ParseExact(utakmica.TxtVreme.Text, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                Mesto = utakmica.TxtMesto.Text,
                Tip = (TipUtakmice)utakmica.Cmbkategorija.SelectedItem,
                Domacin = domaci,
                Gost = gosti,
            };
            Response response = Communication.Instance.SaveGame(ut);
            
            if (response.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio utakmicu!");
                MainCoordinator.Instance.showHostMemberPanel(ut);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool isValidInptu()
        {
            if(string.IsNullOrEmpty(utakmica.TxtSifraUtakmice.Text) || !int.TryParse(utakmica.TxtSifraUtakmice.Text, out int sifra) || utakmica.TxtSifraUtakmice.Text.Length < 3)
            {
                MessageBox.Show("Sifra utakmice mora da bude broj sa minimum 4 cifre!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(utakmica.TxtMesto.Text) || utakmica.TxtMesto.Text.Length < 2)
            {
                MessageBox.Show("Mesto utakmice mora da ima minimum 3 karaktera!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(string.IsNullOrEmpty(utakmica.TxtVreme.Text) || !DateTime.TryParseExact(utakmica.TxtVreme.Text, "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate) || parsedDate < DateTime.Now || parsedDate.Date != DateTime.Today)
            {
                MessageBox.Show("Datum mora da bude u formatu yyyy-MM-dd HH:mm!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(utakmica.Cmbkategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Morate da izaberete kategoriju!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        internal Control ShowGameChangePanel(Utakmica utakmica)
        {
            utak = utakmica;
            games = new AllGamesPanel(utakmica);
            games.BtnDetalji.Click += getGames;
            games.BtnPretrazi.Click += searchGame;
            return games;
        }

        private void searchGame(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(games.TxtSifra.Text) || !int.TryParse(games.TxtSifra.Text, out int sifra))
            {
                MessageBox.Show("Morate da unesete numericku vrednost za pretragu! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Utakmica prenos = new Utakmica()
            {
                UtakmicaID = sifra,
            };
            BindingList<Utakmica> timovi = new BindingList<Utakmica>((List<Utakmica>)Communication.Instance.GetAllGamesByPass(prenos));

            if (timovi == null || timovi.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da nadje utakmice po zadatoj vrednosti! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainCoordinator.Instance.ShowGamepanel();
                return;
            }
            MessageBox.Show("Sistem je nasao utakmicu po zadatoj vrednosti!");
            games.DgvUtakmice.DataSource = null;
            games.DgvUtakmice.DataSource = timovi;

            foreach (DataGridViewColumn kolona in games.DgvUtakmice.Columns)
            {
                kolona.Visible = false;
            }
            games.DgvUtakmice.Columns["UtakmicaID"].Visible = true;
            games.DgvUtakmice.Columns["VremePocetka"].Visible = true;
            games.DgvUtakmice.Columns["Mesto"].Visible = true;
        }

        private void getGames(object sender, EventArgs e)
        {
            if (games.DgvUtakmice.SelectedRows.Count > 0)
            {
                Utakmica tim = games.DgvUtakmice.SelectedRows[0].DataBoundItem as Utakmica;
                Response res = Communication.Instance.GetGame(tim);
                
                if (res.Exception == null)
                {
                    Utakmica vraceniTim = (Utakmica)res.Result;
                    MessageBox.Show("Sistem je uspesno ucitao utakmicu");
                    MainCoordinator.Instance.ShowGameUpdatePanel(vraceniTim);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da ucita utakmicu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainCoordinator.Instance.ShowGamepanel();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Morate da selektujete red!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainCoordinator.Instance.ShowGamepanel();
                return;
            }
        }



        internal Control ShowGameSpecUpdatePanel(Utakmica vraceniTim)
        {
            vracena = vraceniTim;
            gameUpdate = new GameUpdate(vracena);
            gameUpdate.BtnIzmeniUtakmicu.Click += updateGame;
            return gameUpdate;
        }

        private void updateGame(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gameUpdate.TxtMesto.Text) || gameUpdate.TxtMesto.Text.Length < 2)
            {
                MessageBox.Show("Mesto mora da sadrzi minimum 3 karaktera! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(gameUpdate.TxtVreme.Text) || !DateTime.TryParseExact(gameUpdate.TxtVreme.Text, "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate) || parsedDate < DateTime.Now || parsedDate.Date != DateTime.Today)
            {
                MessageBox.Show("Vreme mora da bude u formatu yyyy-MM-dd HH:mm! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gameUpdate.Cmbkategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Morate da izaberete kategoriju!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            vracena.Mesto = gameUpdate.TxtMesto.Text;
            vracena.VremePocetka = (DateTime)DateTime.ParseExact(gameUpdate.TxtVreme.Text, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            vracena.Tip.TipID = gameUpdate.Cmbkategorija.SelectedIndex;

            Response res = Communication.Instance.UpdateGame(vracena);
            if (res.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio utakmicu!");
                MainCoordinator.Instance.ShutDownFrmHelp();
                MainCoordinator.Instance.ShowGamepanel();
                return;
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainCoordinator.Instance.ShowGamepanel();
                return;
            }
        }
    }
}
