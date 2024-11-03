using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    internal class MembersGuiController
    {
        private static MembersGuiController instance;
        public static MembersGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MembersGuiController();
                }
                return instance;
            }
        }

        private MembersGuiController() { }

        AllMembers sviIgraci;
        UpdateMember izmeniIgraca;

        Utakmica utakmica;

        Members unosIgraca;

        internal Control CreateMembersPanel(Utakmica ut)
        {
            utakmica = ut;
            unosIgraca = new Members(utakmica);
            unosIgraca.BtnSacuvajIgraca.Click += SavePlayer;
            unosIgraca.BtnKraj.Click+= EndInsert;
            return unosIgraca;
        }

        private void EndInsert(object sender, EventArgs e)
        {
            List<Igrac> igraci = (List<Igrac>)Communication.Instance.GetPlayersForTeam(utakmica);

            List<Igrac> domaciIgraci = igraci.Where(igrac => igrac.Tim.TimID == utakmica.Domacin.TimID).ToList();
            List<Igrac> gostujuciIgraci = igraci.Where(igrac => igrac.Tim.TimID == utakmica.Gost.TimID).ToList();


            if (domaciIgraci.Count < 2 || gostujuciIgraci.Count < 2)
            {
                MessageBox.Show("Timovi moraju da sadrze minimum 2 igraca!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unosIgraca.TxtBrojDresa.Text = "";
                unosIgraca.TxtImePrezime.Text = "";
                unosIgraca.TxtSifraIgraca.Text = "";
                unosIgraca.CmbTimovi.SelectedIndex = -1;
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Uspesno ste zavrsili unos. Da li zelite da izmenite unete podatke", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DialogResult.Yes == res)
                {
                    MainCoordinator.Instance.ShowFrmChange();
                }
                else
                {
                    MainCoordinator.Instance.StartGame();
                }
            }
        }

        private void SavePlayer(object sender, EventArgs e)
        {
            // TODO: Treba validacija za igraca 
            Igrac igrac = new Igrac()
            {
                IgracID = int.Parse(unosIgraca.TxtSifraIgraca.Text),
                ImePrezime = unosIgraca.TxtImePrezime.Text,
                BrojDresa = unosIgraca.TxtBrojDresa.Text,
                Tim = (Tim)unosIgraca.CmbTimovi.SelectedItem,
            };

            
            Response response = Communication.Instance.SavePlayer(igrac);
            if (response.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio igraca!");
                unosIgraca.TxtBrojDresa.Text = "";
                unosIgraca.TxtImePrezime.Text = "";
                unosIgraca.TxtSifraIgraca.Text = "";
                unosIgraca.CmbTimovi.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unosIgraca.TxtBrojDresa.Text = "";
                unosIgraca.TxtImePrezime.Text = "";
                unosIgraca.TxtSifraIgraca.Text = "";
                unosIgraca.CmbTimovi.SelectedIndex = -1;
            }
        }

        internal Control ShowMembersPanel(Utakmica ut)
        {
            utakmica = ut;
            sviIgraci = new AllMembers(utakmica);
            sviIgraci.BtnDetalji.Click += getPlayer;
            sviIgraci.BtnPretrazi.Click += searchPlayer;
            return sviIgraci;
        }

        private void searchPlayer(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sviIgraci.TxtImePrezime.Text))
            {
                MessageBox.Show("Morate da unesete vrednost za pretragu! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainCoordinator.Instance.ShowPlayersPanel();
                return;
            }

            Igrac prenos = new Igrac()
            {
                ImePrezime = sviIgraci.TxtImePrezime.Text,
                UtakmicaID = utakmica.UtakmicaID,
            };
            BindingList<Igrac> timovi = new BindingList<Igrac>((List<Igrac>)Communication.Instance.GetAllPlayersByName(prenos));

            if (timovi == null || timovi.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainCoordinator.Instance.ShowPlayersPanel();
                return;
            }
            MessageBox.Show("Sistem je nasao igrace po zadatoj vrednosti!");
            sviIgraci.DgvSviIgraqci.DataSource = null;
            sviIgraci.DgvSviIgraqci.DataSource = timovi;

            foreach (DataGridViewColumn kolona in sviIgraci.DgvSviIgraqci.Columns)
            {
                kolona.Visible = false;
            }
            sviIgraci.DgvSviIgraqci.Columns["IgracID"].Visible = true;
            sviIgraci.DgvSviIgraqci.Columns["ImePrezime"].Visible = true;
            sviIgraci.DgvSviIgraqci.Columns["BrojDresa"].Visible = true;
        }

        private void getPlayer(object sender, EventArgs e)
        {
            if (sviIgraci.DgvSviIgraqci.SelectedRows.Count > 0)
            {
                Igrac tim = sviIgraci.DgvSviIgraqci.SelectedRows[0].DataBoundItem as Igrac;
                Response res = Communication.Instance.GetPlayer(tim);
                
                if (res.Exception == null)
                {
                    Igrac vraceniTim = (Igrac)res.Result;
                    MessageBox.Show("Sistem je uspesno ucito igraca!");
                    MainCoordinator.Instance.ShowMemberUpdatePanel(vraceniTim);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da ucita igraca!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainCoordinator.Instance.ShowPlayersPanel();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Morate da selektujete red!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainCoordinator.Instance.ShowPlayersPanel();
                return;
            }
        }
        Igrac zaUpdate;
        internal Control ShoUpdateMemberpanel(Igrac vraceniTim)
        {
            zaUpdate = vraceniTim;
            izmeniIgraca = new UpdateMember(zaUpdate, utakmica);
            izmeniIgraca.BtnIzmeniIgraca.Click += updatePlayer;
            return izmeniIgraca;
        }

        private void updatePlayer(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(izmeniIgraca.TxtImePrezime.Text) || izmeniIgraca.TxtImePrezime.Text.Length < 2)
            {
                MessageBox.Show("Ime i prezime mora da sadrzi minimum 3 karaktera! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(string.IsNullOrEmpty(izmeniIgraca.TxtBrojDresa.Text) || izmeniIgraca.TxtBrojDresa.Text.Length > 3 || !int.TryParse(izmeniIgraca.TxtBrojDresa.Text, out var brojDresa))
            {
                MessageBox.Show("Broj dresa moze da sadrzi najvise 3 cifre! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            zaUpdate.ImePrezime = izmeniIgraca.TxtImePrezime.Text;
            zaUpdate.BrojDresa = izmeniIgraca.TxtBrojDresa.Text;
            zaUpdate.Tim = izmeniIgraca.CmbTimovi.SelectedItem as Tim;

            
            Response res = Communication.Instance.UpdatePlayer(zaUpdate);
            if (res.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio igraca! ");
                MainCoordinator.Instance.ShutDownFrmHelp();
                MainCoordinator.Instance.ShowPlayersPanel();
                return;
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainCoordinator.Instance.ShutDownFrmHelp();
                MainCoordinator.Instance.ShowPlayersPanel();
                return;
            }
        }
    }
}
