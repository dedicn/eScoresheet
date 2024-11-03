using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class ChangePoints : UserControl
    {
        BindingList<Igrac> prikazDomaci = new BindingList<Igrac>();
        BindingList<Igrac> prikazGosti = new BindingList<Igrac>();
        BindingList<Igrac> ig;
        BindingList<RezultatIgraca> rez;
        Utakmica utakmica;
        public ChangePoints(Utakmica utakmica)
        {
            InitializeComponent();
            this.utakmica = utakmica;
            dgvPoeni.DataSource = null ;
            BindingList<Tim> kategorije = new BindingList<Tim>((List<Tim>)Communication.Instance.GetAllTeams(utakmica));
            cmbTimovi.DataSource = kategorije;
            cmbTimovi.DropDownStyle = ComboBoxStyle.DropDown;
            cmbTimovi.DisplayMember = "NazivTima";
            cmbTimovi.SelectedIndex = -1;

            
        }
        private void cmbTimovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPoeni.DataSource = null;
            //prikazDomaci = new BindingList<Igrac>(ig.Where(igrac => igrac.Tim.TimID == utakmica.Domacin.TimID).ToList());
            //prikazGosti = new BindingList<Igrac>(ig.Where(igrac => igrac.Tim.TimID == utakmica.Gost.TimID).ToList());

            if (cmbTimovi.SelectedIndex != -1)
            {
                Igrac i = new Igrac()
                {
                    Tim = cmbTimovi.SelectedItem as Tim,
                };
                RezultatIgraca r = new RezultatIgraca()
                {
                    Utakmica = utakmica,
                    Igrac = i,
                };
                object obj = Communication.Instance.GetAllScores(r);
                if(obj != null)
                {
                    List<RezultatIgraca> p = (List<RezultatIgraca>)obj;

                    rez = new BindingList<RezultatIgraca>(p);
                    

                    
                    if (rez == null) { MessageBox.Show("Sistem ne moze da nadje rezultate po zadatoj vrednosti", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    MessageBox.Show("Sistem je nasao rezultate po zadatoj vrednosti!");


                    BindingList<PrikazRezultatIgraca> pomocna = new BindingList<PrikazRezultatIgraca>();

                    foreach(RezultatIgraca pr in rez)
                    {
                        PrikazRezultatIgraca h = new PrikazRezultatIgraca()
                        {
                            IgracID = pr.Igrac.IgracID,
                            UtakmicaID = pr.Utakmica.UtakmicaID,
                            BrojLicnihGresaka = pr.BrojLicnihGresaka,
                            BrojPoena = pr.BrojPoena,
                        };
                        pomocna.Add(h);
                    }
                    dgvPoeni.DataSource = pomocna;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da nadje rezultate po zadatoj vrednosti", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }


        }

        
    }
}