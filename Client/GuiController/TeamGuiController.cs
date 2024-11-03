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
    public class TeamGuiController
    {
        private static TeamGuiController instance;
        public static TeamGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TeamGuiController();
                }
                return instance;
            }
        }

        private TeamGuiController() { }

        private FrmMain frmMain;
        private Utakmica utakmica;
        private TeamSearch izmenaTima;
        private Team teamupdate;
        private Button updateTeam;
        private Tim updatedtim;

        public void ShowMain(FrmMain forma)
        {
            frmMain = forma;
        }

        internal void SaveTeams(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(frmMain.Domaci.Text) || frmMain.Domaci.Text.Length < 2)
            {
                MessageBox.Show("Nazivm domaceg tima mora da sadrzi minimum 3 karaktera!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(frmMain.Gost.Text) || frmMain.Gost.Text.Length < 2)
            {
                MessageBox.Show("Nazivm gostujuceg tima mora da sadrzi minimum 3 karaktera!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tim gost = new Tim()
            {
                NazivTima = frmMain.Gost.Text,
            };
            Response responseGost = Communication.Instance.SaveTeam(gost);

            Tim domacin = new Tim()
            {
                NazivTima = frmMain.Domaci.Text
            };
            Response responseDomacin = Communication.Instance.SaveTeam(domacin);
            

            if (responseDomacin.Exception == null && responseGost.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio tim!");
                MainCoordinator.Instance.ShowGameSpecsPanel(responseDomacin, responseGost);
                return;
            }
            
            if (responseDomacin.Exception != null)
            {
                MessageBox.Show("Sistem ne moze da zapamti tim! " + responseDomacin.Exception, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (responseGost.Exception != null)
            {
                MessageBox.Show("Sistem ne moze da zapamti tim!" + responseGost.Exception, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void Logout(object sender, EventArgs e)
        {
            Communication.Instance.Logout();
            Environment.Exit(0);
        }

        internal Control CreateTeamPanel(Utakmica ut)
        {
            utakmica = ut;
            izmenaTima = new TeamSearch(utakmica);
            izmenaTima.BtnDetalji.Click += getTeam;
            izmenaTima.BtnPretrazi.Click += searchTeam;
            return izmenaTima;
        }

        private void getTeam(object sender, EventArgs e)
        {
            if(izmenaTima.DgvTimovi.SelectedRows.Count > 0)
            {
                Tim tim = izmenaTima.DgvTimovi.SelectedRows[0].DataBoundItem as Tim;
                Response res = Communication.Instance.GetTeam(tim);
                
                MessageBox.Show("Sistem ne moze da ucaita tim! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (res.Exception == null)
                {
                    Tim vraceniTim = (Tim)res.Result;
                    MessageBox.Show("Sistem je uspesno ucitao tim!");
                    MainCoordinator.Instance.ShowTeamUpdatePanel(vraceniTim);
                }else
                {
                    MessageBox.Show("Sistem ne moze da ucita tim!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainCoordinator.Instance.ShowTeamPanel();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Morate da selektujete red!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void searchTeam(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(izmenaTima.TxtNazivTima.Text))
            {
                MessageBox.Show("Morate da unesete vrednost za pretragu! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tim prenos = new Tim()
            {
                NazivTima = izmenaTima.TxtNazivTima.Text,
                UtakmicaID = utakmica.UtakmicaID,
            };
            BindingList<Tim> timovi = new BindingList<Tim>((List<Tim>)Communication.Instance.GetAllTeamsByName(prenos));
           
            if (timovi == null || timovi.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da nadje timove po zadatoj vrednosti! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainCoordinator.Instance.ShowTeamPanel();
                return;
            }
            MessageBox.Show("Sistem je nasao timove po zadatoj vrednosti!");
            izmenaTima.DgvTimovi.DataSource = null;
            izmenaTima.DgvTimovi.DataSource = timovi;

            foreach (DataGridViewColumn kolona in izmenaTima.DgvTimovi.Columns)
            {
                kolona.Visible = false;
            }
            izmenaTima.DgvTimovi.Columns["TimID"].Visible = true;
            izmenaTima.DgvTimovi.Columns["NazivTima"].Visible = true;
        }

        private void updateTeamName(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teamupdate.TxtNazivTima.Text) || teamupdate.TxtNazivTima.Text.Length < 2)
            {
                MessageBox.Show("Naziv mora da sadrzi minimum 3 karaktera! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            updatedtim.NazivTima = teamupdate.TxtNazivTima.Text;
            Response res = Communication.Instance.UpdateTeam(updatedtim);
            if(res.Exception == null)
            {
                MessageBox.Show("Sistem je zapamtio tim! ");
                MainCoordinator.Instance.ShutDownFrmHelp();
                MainCoordinator.Instance.ShowTeamPanel();
                return;

            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti tim! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        internal Control ShowUpdateTeamPanel(Tim vraceniTim)
        {
            updatedtim = vraceniTim;
            teamupdate = new Team(vraceniTim);
            teamupdate.BtnSacuvajIzmene.Click += updateTeamName;
            return teamupdate;
        }
    }
}
