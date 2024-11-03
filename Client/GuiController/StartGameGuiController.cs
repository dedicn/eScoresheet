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
    internal class StartGameGuiController
    {
        private static StartGameGuiController instance;
        public static StartGameGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StartGameGuiController();
                }
                return instance;
            }
        }

        private StartGameGuiController() { }

        FrmGame igra;
        FrmHelp forma;

        AddPoints dodajPoen;
        AddFaulPanel dodajFaul;
        ChangePoints izbrisiPoene;
        Cetvrtina sledecaCet;
        Win pobednik;
        DeleteFaul izbrisiFaul;

        RezultatCetvrtine pocetna;
        Utakmica utakmica;

        BindingList<PrikazIgracgreske> prikazDomaci = new BindingList<PrikazIgracgreske>();
        BindingList<PrikazIgracgreske> prikazGosti = new BindingList<PrikazIgracgreske>();
        int domaciPoeni = 0;
        int gostiPoeni = 0;
        int brojGResDom = 0;
        int brojGresGos = 0;
        int brojTajDomaci = 0;
        int brojTajmGosti = 0;
        int brojcet = 1;

        private void refreshForm()
        {
            igra.LblCetvrina.Text = brojcet + "";
            igra.LblDomaciLicne.Text = brojGResDom + "";
            igra.LblDomaciTajmBroj.Text = brojTajDomaci + "";
            igra.LblDomPoeni.Text = domaciPoeni + "";

            igra.LblGostiLicne.Text = brojGresGos + "";
            igra.LblGostiTajmBroj.Text = brojTajmGosti + "";
            igra.LblGostiPoeni.Text = gostiPoeni +"";
        }

        internal void ShowGame(FrmGame frmGame, Utakmica utakmica)
        {
            igra = frmGame;
            this.utakmica = utakmica;/*
            pocetna = new RezultatCetvrtine();
            pocetna.Utakmica = utakmica;
            utakmica.cetvrtine.Add(pocetna);*/
            this.utakmica.cetvrtine = new List<RezultatCetvrtine>();
            this.utakmica.igraci = new List<RezultatIgraca>();
            List<Igrac> igraci = (List<Igrac>)Communication.Instance.GetPlayersForTeam(utakmica);

            igra.LblDomacin.Text = utakmica.Domacin.NazivTima;
            igra.LblGost.Text = utakmica.Gost.NazivTima;

            List<Igrac> domaciIgraci = igraci.Where(igrac => igrac.Tim.TimID == utakmica.Domacin.TimID).ToList();

            List<PrikazIgracgreske> pomocna = new List<PrikazIgracgreske>();
            foreach(Igrac ig in domaciIgraci)
            {
                PrikazIgracgreske n = new PrikazIgracgreske()
                {
                    BrojDresa = ig.BrojDresa,
                    Igrac = ig.ImePrezime,
                    brojFaulova = 0
                };
                pomocna.Add(n);
            }
            prikazDomaci = new BindingList<PrikazIgracgreske>(pomocna);

            List<Igrac> gostujuciIgraci = igraci.Where(igrac => igrac.Tim.TimID == utakmica.Gost.TimID).ToList();

            pomocna = new List<PrikazIgracgreske>();
            foreach (Igrac ig in gostujuciIgraci)
            {
                PrikazIgracgreske n = new PrikazIgracgreske()
                {
                    BrojDresa = ig.BrojDresa,
                    Igrac = ig.ImePrezime,
                    brojFaulova = 0
                };
                pomocna.Add(n);
            }
            prikazGosti = new BindingList<PrikazIgracgreske>(pomocna);

            igra.DgvDomaci.DataSource = prikazDomaci;
            igra.DgvGosti.DataSource = prikazGosti;
        }

        internal void ChangeScore(object sender, EventArgs e)
        {
            forma = new FrmHelp();
            izbrisiPoene = new ChangePoints(utakmica);
            izbrisiPoene.BtnJedan.Click += (s,a) => deletePoint(1);
            izbrisiPoene.BtnDva.Click += (s,a) => deletePoint(2);
            izbrisiPoene.BtnTri.Click += (s,a) => deletePoint(3);
            forma.ChangePanel(izbrisiPoene);
            forma.ShowDialog();
        }

        private void deletePoint(int v)
        {
            if (izbrisiPoene.CmbTim.SelectedIndex == -1)
            {
                MessageBox.Show("Morate da odaberete opciju", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tim tim = izbrisiPoene.CmbTim.SelectedItem as Tim;

            if (izbrisiPoene.DgvPoeni.SelectedRows.Count != 1)
            {
                MessageBox.Show("Mozete da selektujete samo jednu vrednost", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PrikazRezultatIgraca re = izbrisiPoene.DgvPoeni.SelectedRows[0].DataBoundItem as PrikazRezultatIgraca;
            RezultatIgraca rez = new RezultatIgraca()
            {
                Igrac = new Igrac() { IgracID = re.IgracID },
                Utakmica = utakmica
            };
            Response res = Communication.Instance.createScore(rez);

            rez = (RezultatIgraca)res.Result;

            if (res.Exception != null) { MessageBox.Show("Sistem  nije uspesno ucitao rezultat!", "Gresla", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            MessageBox.Show("Sistem je uspesno ucitao rezultat!");

            if(rez.BrojPoena - v < 0)
            {
                MessageBox.Show("Ne mozete da smanjite ispod 0!!", "Gresla", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            Igrac i = new Igrac()
            {
                IgracID = rez.Igrac.IgracID
            };
            Response iz = Communication.Instance.GetPlayer(i);
            Igrac ig = (Igrac)iz.Result;

            int dom = domaciPoeni;
            int gos = gostiPoeni;
            if (utakmica.Domacin.NazivTima.Equals(tim.NazivTima))
            {
                dom -= v;
            }
            else
            {
                gos -= v;
            }
            DialogResult r = MessageBox.Show($"Da li sigurno zelite da smanjite rezultat na {dom} : {gos}?\nIgrac: {ig.BrojDresa}","Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {

                rez.BrojPoena -= v;
                Response pok = Communication.Instance.DeleteScore(rez);

                if (pok.Exception == null)
                {
                    if (utakmica.Domacin.NazivTima.Equals(ig.Tim.NazivTima))
                    {
                        domaciPoeni -= v;
                    }
                    else
                    {
                        gostiPoeni -= v;
                    }
                    MessageBox.Show("Sistem je uspesno izmenio rezultat!");
                }
                else
                {
                    MessageBox.Show("Sistem nije uspesno izmenio rezultat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            refreshForm();
            forma.Dispose();
        }

        

        internal void AddFaul(object sender, EventArgs e)
        {
            forma = new FrmHelp();
            dodajFaul = new AddFaulPanel(utakmica);
            dodajFaul.BtnUnesiFaul.Click += insertFaul;
            forma.ChangePanel(dodajFaul);
            forma.ShowDialog();
        }

        private void insertFaul(object sender, EventArgs e)
        {
            if(dodajFaul.CmbTim.SelectedIndex < 0 || dodajFaul.CmbIgraqci.SelectedIndex <0)
            {
                MessageBox.Show("Morate da odaberete opciju", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Tim tim = dodajFaul.CmbTim.SelectedItem as Tim;
            Igrac ig = dodajFaul.CmbIgraqci.SelectedItem as Igrac;

            if (!tim.NazivTima.Equals(ig.Tim.NazivTima))
            {
                MessageBox.Show("Igrac mora da bude iz istog tima", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tim.NazivTima.Equals(utakmica.Domacin.NazivTima))
            {
                Igrac odabrani = dodajFaul.CmbIgraqci.SelectedItem as Igrac;

                RezultatIgraca pom = new RezultatIgraca()
                {
                    Utakmica = utakmica,
                    Igrac = odabrani
                };
                Response res = Communication.Instance.createScore(pom);


                if (res.Exception != null) { MessageBox.Show("Sistem nije uspesno kreirao rezultat!", "Gresla", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                MessageBox.Show("Sistem je uspesno kreirao rezultat!");

                if(res.Result != null )
                {
                    pom = (RezultatIgraca)res.Result;
                }

                if(pom.BrojLicnihGresaka == 5) { MessageBox.Show("Igrac ima 5 faulova!!", "Gresla", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }


                pom.BrojLicnihGresaka++;

                int index = utakmica.igraci.FindIndex(re => re.Igrac.IgracID == pom.Igrac.IgracID);
                if (index != -1)
                {
                    utakmica.igraci[index] = pom;
                }
                else
                {
                    utakmica.igraci.Add(pom);
                }
                /*
                if(utakmica.igraci.Contains(pom))
                {
                    int indeks = utakmica.igraci.IndexOf(pom);
                    utakmica.igraci[indeks] = pom;
                }else
                {
                    utakmica.igraci.Add(pom);
                }*/

                //Response r = Communication.Instance.AddRezultatIgraca(pom);

                if (!utakmica.igraci.Contains(pom)) { MessageBox.Show("Sistem nije uspesno zabelezio rezultat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                MessageBox.Show("Sistem je uspesno zabelezio rezultat");

                brojGResDom++;
                foreach(PrikazIgracgreske pri in prikazDomaci)
                {
                    if(pri.BrojDresa.Equals(odabrani.BrojDresa) && pri.Igrac.Equals(odabrani.ImePrezime))
                    {
                        pri.brojFaulova++;
                        break;
                    }
                }
                
                igra.DgvDomaci.DataSource = null;
                igra.DgvDomaci.DataSource = prikazDomaci;
                
            }
            else
            {
                Igrac odabrani = dodajFaul.CmbIgraqci.SelectedItem as Igrac;

                RezultatIgraca pom = new RezultatIgraca()
                {
                    Utakmica = utakmica,
                    Igrac = odabrani
                };
                Response res = Communication.Instance.createScore(pom);


                if (res.Exception != null) { MessageBox.Show("Sistem  nije uspesno kreirao rezultat!", "Gresla", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                MessageBox.Show("Sistem je uspesno kreirao rezultat!");

                if (res.Result != null)
                {
                    pom = (RezultatIgraca)res.Result;
                }

                if (pom.BrojLicnihGresaka == 5) { MessageBox.Show("Igrac ima 5 faulova!!", "Gresla", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                pom.BrojLicnihGresaka++;

                //Response r = Communication.Instance.AddRezultatIgraca(pom);
                int index = utakmica.igraci.FindIndex(re => re.Igrac.IgracID == pom.Igrac.IgracID);
                if (index != -1)
                {
                    utakmica.igraci[index] = pom;
                }
                else
                {
                    utakmica.igraci.Add(pom);
                }

                if (!utakmica.igraci.Contains(pom)) { MessageBox.Show("Sistem nije uspesno zabelezio rezultat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                MessageBox.Show("Sistem je uspesno zabelezio rezultat");
                brojGresGos++;

                foreach (PrikazIgracgreske pri in prikazGosti)
                {
                    if (pri.BrojDresa.Equals(odabrani.BrojDresa) && pri.Igrac.Equals(odabrani.ImePrezime))
                    {
                        pri.brojFaulova++;
                        break;
                    }
                }

                igra.DgvGosti.DataSource = null;
                igra.DgvGosti.DataSource = prikazGosti;
            }

            refreshForm();
            forma.Dispose();

        }

        internal void AddPoint(object sender, EventArgs e)
        {
            forma = new FrmHelp();
            dodajPoen = new AddPoints(utakmica);
            dodajPoen.BtnJedan.Click += (s, a) => insertPoint(1);
            dodajPoen.BtnDva.Click += (s, a) => insertPoint(2);
            dodajPoen.BtnTri.Click += (s, a) => insertPoint(3);
            forma.ChangePanel(dodajPoen);
            forma.ShowDialog();
        }

        private void insertPoint(int v)
        {
            if (dodajPoen.CmbTim.SelectedIndex < 0 || dodajPoen.CmbIgraqci.SelectedIndex < 0)
            {
                MessageBox.Show("Morate da odaberete opciju", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Tim tim = dodajPoen.CmbTim.SelectedItem as Tim;
            Igrac ig = dodajPoen.CmbIgraqci.SelectedItem as Igrac;

            if (!tim.NazivTima.Equals(ig.Tim.NazivTima))
            {
                MessageBox.Show("Igrac mora da bude iz istog tima", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Igrac odabrani = dodajPoen.CmbIgraqci.SelectedItem as Igrac;

            RezultatIgraca pom = new RezultatIgraca()
            {
                Utakmica = utakmica,
                Igrac = odabrani
            };
            Response res = Communication.Instance.createScore(pom);//vidi jel ima u bazi za tog igraca rez

            if (res.Exception != null) { MessageBox.Show("Sistem  nije uspesno kreirao rezultat!", "Gresla", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            MessageBox.Show("Sistem je uspesno kreirao rezultat!");

            if (res.Result != null)
            {
                pom = (RezultatIgraca)res.Result;
            }
            pom.BrojPoena += v;

            //Response r = Communication.Instance.AddRezultatIgraca(pom);
            int index = utakmica.igraci.FindIndex(re => re.Igrac.IgracID == pom.Igrac.IgracID);
            if (index != -1)
            {
                utakmica.igraci[index] = pom;
            }
            else
            {
                utakmica.igraci.Add(pom);
            }

            if (!utakmica.igraci.Contains(pom)) { MessageBox.Show("Sistem nije uspesno zabelezio rezultat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            MessageBox.Show("Sistem je uspesno zabelezio rezultat");

            if (res.Exception == null)
            {
                if (tim.NazivTima.Equals(utakmica.Domacin.NazivTima))
                {
                    domaciPoeni += v;
                }
                else
                {
                    gostiPoeni += v;
                }
            }
            else
            {
                MessageBox.Show("Sistem nije uspeo zabelezio rezultat!");
            }

            refreshForm();
            forma.Dispose();
        }

        internal void NextQuarter(object sender, EventArgs e)
        {
            forma = new FrmHelp();

            if(utakmica.cetvrtine.Count > 2 && domaciPoeni != gostiPoeni)
            {
                EndGame();
                return;
            }

            if(brojcet == 2)
            {
                brojTajDomaci = 0;
                brojTajmGosti = 0;
            }

            RezultatCetvrtine nova = new RezultatCetvrtine();
            nova.Utakmica = utakmica;

            if(utakmica.cetvrtine.Count == 0)
            {
                nova.BrojCetvrtine = 1;
                nova.BrojGresakaGosti = brojGresGos;
                nova.BrojGresakaDomaci = brojGResDom;
                nova.BrojTajmautaGosti = brojTajmGosti;
                nova.BrojTajmautaDomaci = brojTajDomaci;
                nova.BrojPoenaDomaci = domaciPoeni;
                nova.BrojPoenaGosti = gostiPoeni;
            }
            else
            {
                utakmica.cetvrtine = utakmica.cetvrtine.OrderBy(x => x.BrojCetvrtine).ToList();
                RezultatCetvrtine prosla = utakmica.cetvrtine[utakmica.cetvrtine.Count - 1];
                nova.BrojCetvrtine = brojcet;
                nova.BrojGresakaGosti = brojGresGos;
                nova.BrojGresakaDomaci = brojGResDom;
                nova.BrojTajmautaGosti = brojTajmGosti;
                nova.BrojTajmautaDomaci = brojTajDomaci;
                nova.BrojPoenaDomaci = domaciPoeni - prosla.BrojPoenaDomaci; 
                nova.BrojPoenaGosti = gostiPoeni - prosla.BrojPoenaGosti; 

            }

            sledecaCet = new Cetvrtina(nova);
            sledecaCet.BtnSledecaCetvrtina.Click += (s, a) => changeQuarter(nova);
            sledecaCet.BtnKraj.Click += end;
            forma.ChangePanel(sledecaCet);
            forma.ShowDialog();
        }

        private void changeQuarter(RezultatCetvrtine nova)
        {
            brojGResDom = 0;
            brojGresGos = 0;
            
            //Response res = Communication.Instance.saveQuarter(nova);
            
            if (brojcet > 0)
            {
                //MessageBox.Show("Sistem je uspeo da unese cetvrtinu");

                //nova.BrojCetvrtine = ((RezultatCetvrtine)res.Result).BrojCetvrtine;
                nova.BrojCetvrtine = brojcet;
                utakmica.cetvrtine.Add(nova);
                brojcet++;
            }
            else
            {
                MessageBox.Show("Sistem ne moze da unese cetvrtinu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refreshForm();
            forma.Dispose();
        }

        private void end(object sender, EventArgs e)
        {
            if(forma != null) {  forma.Dispose(); }
            forma = new FrmHelp();
            pobednik = new Win(utakmica, domaciPoeni, gostiPoeni);
            pobednik.BtnKraj.Click += EndGame;
            forma.ChangePanel(pobednik);
            forma.ShowDialog();
        }

        private void EndGame(object sender, EventArgs e)
        {
            utakmica.VremeZavrsetka = DateTime.Now;
            Response res = Communication.Instance.UpdateGame(utakmica);
            Response r = Communication.Instance.InsertAllPoints(utakmica);

            if(res.Exception == null && r.Exception ==null)
            {
                MessageBox.Show("Utakmica je uspesno uneta!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Utakmica nije uspesno zavrsena!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EndGame()
        {
            if (forma != null) { forma.Dispose(); }
            forma = new FrmHelp();
            pobednik = new Win(utakmica, domaciPoeni, gostiPoeni);
            pobednik.BtnKraj.Click += EndGame;
            forma.ChangePanel(pobednik);
            forma.ShowDialog();
        }

        internal void HostTime(object sender, EventArgs e)
        {

            //ili dodaj negde u utakmicu ili uzmi samo tajmove kao glob
            if(utakmica.cetvrtine.Count < 2 && brojTajDomaci < 2)
            {
                brojTajDomaci++;
                refreshForm();
            }else if(utakmica.cetvrtine.Count >= 2 && brojTajDomaci < 3)
            {
                brojTajDomaci++;
                refreshForm();
            }
            else
            {
                MessageBox.Show(utakmica.Domacin.NazivTima + " tim nema vise tajmauta u " + brojcet + " cetvrtini!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void GuestTime(object sender, EventArgs e)
        {
            if (utakmica.cetvrtine.Count < 2 && brojTajmGosti < 2)
            {
                brojTajmGosti++;
                refreshForm();
            }
            else if (utakmica.cetvrtine.Count >= 2 && brojTajmGosti < 3)
            {
                brojTajmGosti++;
                refreshForm();
            }
            else
            {
                MessageBox.Show(utakmica.Gost.NazivTima + " tim nema vise tajmauta u " + brojcet + " cetvrtini!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void CorrectFaul(object sender, EventArgs e)
        {
            forma = new FrmHelp();
            izbrisiFaul = new DeleteFaul(utakmica);
            izbrisiFaul.BtnIzbrisiFaul.Click += izbrisi;
            forma.ChangePanel(izbrisiFaul);
            forma.ShowDialog();
        }

        private void izbrisi(object sender, EventArgs e)
        {
            if (izbrisiFaul.CmbTim.SelectedIndex < 0)
            {
                MessageBox.Show("Morate da odaberete opciju", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tim tim = izbrisiFaul.CmbTim.SelectedItem as Tim;

            if (izbrisiFaul.DgvPoeni.SelectedRows.Count != 1)
            {
                MessageBox.Show("Mozete da selektujete samo jednu vrednost", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PrikazRezultatIgraca re = izbrisiFaul.DgvPoeni.SelectedRows[0].DataBoundItem as PrikazRezultatIgraca;
            RezultatIgraca rez = new RezultatIgraca()
            {
                Igrac = new Igrac() { IgracID = re.IgracID },
                Utakmica = utakmica
            };
            Response res = Communication.Instance.createScore(rez);

            
            if (res.Exception != null) { MessageBox.Show("Sistem  nije uspesno ucitao rezultat!", "Gresla", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            MessageBox.Show("Sistem je uspesno ucitao rezultat!");

            rez = (RezultatIgraca)res.Result;

            if (rez.BrojLicnihGresaka - 1 < 0)
            {
                MessageBox.Show("Ne mozete da smanjite ispod 0!", "Gresla", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            Igrac i = new Igrac()
            {
                IgracID = rez.Igrac.IgracID
            };
            Response iz = Communication.Instance.GetPlayer(i);
            Igrac ig = (Igrac)iz.Result;

            
            DialogResult r = MessageBox.Show($"Da li sigurno zelite da smanjite broj faulova igracu sa brojem: {ig.BrojDresa}", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {

                rez.BrojLicnihGresaka --;
                Response pok = Communication.Instance.DeleteScore(rez);

                //za dgvDOmaci i gosti update
                if(tim.NazivTima.Equals(utakmica.Domacin.NazivTima))
                {
                    foreach (PrikazIgracgreske pri in prikazDomaci)
                    {
                        if (pri.BrojDresa.Equals(ig.BrojDresa) && pri.Igrac.Equals(ig.ImePrezime))
                        {
                            pri.brojFaulova--;
                            break;
                        }
                    }

                    igra.DgvDomaci.DataSource = null;
                    igra.DgvDomaci.DataSource = prikazDomaci;
                }
                else
                {
                    foreach (PrikazIgracgreske pri in prikazGosti)
                    {
                        if (pri.BrojDresa.Equals(ig.BrojDresa) && pri.Igrac.Equals(ig.ImePrezime))
                        {
                            pri.brojFaulova--;
                            break;
                        }
                    }

                    igra.DgvGosti.DataSource = null;
                    igra.DgvGosti.DataSource = prikazGosti;
                }

                
                if (pok.Exception == null)
                {
                    if (utakmica.Domacin.NazivTima.Equals(ig.Tim.NazivTima))
                    {
                        brojGResDom --;
                    }
                    else
                    {
                        brojGresGos --;
                    }
                    MessageBox.Show("Sistem je uspesno izmenio rezultat!");
                }
                else
                {
                    MessageBox.Show("Sistem nije uspesno izmenio rezultat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            refreshForm();
            forma.Dispose();
        }

        internal void CheckScore()
        {
            RezultatCetvrtine nova = new RezultatCetvrtine();
            nova.Utakmica = utakmica;

            if (utakmica.cetvrtine.Count == 0)
            {
                nova.BrojCetvrtine = 1;
                nova.BrojGresakaGosti = brojGresGos;
                nova.BrojGresakaDomaci = brojGResDom;
                nova.BrojTajmautaGosti = brojTajmGosti;
                nova.BrojTajmautaDomaci = brojTajDomaci;
                nova.BrojPoenaDomaci = domaciPoeni;
                nova.BrojPoenaGosti = gostiPoeni;
            }
            else
            {
                utakmica.cetvrtine = utakmica.cetvrtine.OrderBy(x => x.BrojCetvrtine).ToList();
                RezultatCetvrtine prosla = utakmica.cetvrtine[utakmica.cetvrtine.Count - 1];
                nova.BrojCetvrtine = brojcet;
                nova.BrojGresakaGosti = brojGresGos;
                nova.BrojGresakaDomaci = brojGResDom;
                nova.BrojTajmautaGosti = brojTajmGosti;
                nova.BrojTajmautaDomaci = brojTajDomaci;
                nova.BrojPoenaDomaci = domaciPoeni - prosla.BrojPoenaDomaci;
                nova.BrojPoenaGosti = gostiPoeni - prosla.BrojPoenaGosti;
            }
            Response res = Communication.Instance.saveQuarter(nova);
            if(res.Exception == null)
            {
                MessageBox.Show("Sacuvan je trenutni rezultat!");
            }
            else
            {
                MessageBox.Show("Sistem nije uspesno uneo trenutni rezultat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
