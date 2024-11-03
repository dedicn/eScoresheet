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
    public partial class UpdateMember : UserControl
    {
        public UpdateMember(Igrac ig, Utakmica utakmica)
        {
            InitializeComponent();
            lblSifraIgraca.Text = ig.IgracID + "";
            txtBrojDresa.Text = ig.BrojDresa;
            txtImePrezime.Text = ig.ImePrezime;
            BindingList<Tim> kategorije = new BindingList<Tim>((List<Tim>)Communication.Instance.GetAllTeams(utakmica));
            cmbTimovi.DataSource = kategorije;
            cmbTimovi.DisplayMember = "NazivTima";
            if(ig.Tim.TimID == utakmica.Domacin.UtakmicaID) { cmbTimovi.SelectedIndex = 0; } else { cmbTimovi.SelectedIndex = 1; }
            
        }
    }
}
