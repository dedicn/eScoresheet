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
    public partial class AddFaulPanel : UserControl
    {
        BindingList<Igrac> prikazDomaci = new BindingList<Igrac>();
        BindingList<Igrac> prikazGosti = new BindingList<Igrac>();
        BindingList<Igrac> ig;
        Utakmica utakmica;
        public AddFaulPanel(Utakmica utakmica)
        {
            InitializeComponent();
            cmbIgraci.DataSource = null;
            cmbTimovi.DataSource = null;
            this.utakmica = utakmica;
            BindingList<Tim> kategorije = new BindingList<Tim>((List<Tim>)Communication.Instance.GetAllTeams(utakmica));
            cmbTimovi.DataSource = kategorije;
            cmbTimovi.DropDownStyle = ComboBoxStyle.DropDown;
            cmbTimovi.DisplayMember = "NazivTima";
            cmbTimovi.SelectedIndex = -1;
            cmbIgraci.Enabled = false;

            ig = new BindingList<Igrac>((List<Igrac>)Communication.Instance.GetPlayersForTeam(utakmica));
            cmbIgraci.DataSource = ig;
            cmbIgraci.DropDownStyle = ComboBoxStyle.DropDown;
            cmbIgraci.DisplayMember = "ImePrezime";
            cmbIgraci.SelectedIndex = -1;
            cmbIgraci.Enabled = false;
        }

        private void cmbTimovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ig != null)
            {
                cmbIgraci.Enabled = true;
                prikazDomaci = new BindingList<Igrac>(ig.Where(igrac => igrac.Tim.TimID == utakmica.Domacin.TimID).ToList());
                prikazGosti = new BindingList<Igrac>(ig.Where(igrac => igrac.Tim.TimID == utakmica.Gost.TimID).ToList());

                if (cmbTimovi.SelectedIndex == 0)
                {
                    cmbIgraci.DataSource = prikazDomaci;
                }
                else
                {
                    cmbIgraci.DataSource = prikazGosti;
                }
            }
        }

        private void cmbIgraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (ig != null)
            {
                cmbIgraci.Enabled = true;
                prikazDomaci = new BindingList<Igrac>(ig.Where(igrac => igrac.Tim.TimID == utakmica.Domacin.TimID).ToList());
                prikazGosti = new BindingList<Igrac>(ig.Where(igrac => igrac.Tim.TimID == utakmica.Gost.TimID).ToList());

                if (cmbTimovi.SelectedIndex == 0)
                {
                    cmbIgraci.DataSource = prikazDomaci;
                }
                else
                {
                    cmbIgraci.DataSource = prikazGosti;
                }
            }
            */
        }
    }
}
