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
    public partial class Members : UserControl
    {
        public Members(Utakmica utakmica)
        {
            InitializeComponent();
            BindingList<Tim> kategorije = new BindingList<Tim>((List<Tim>)Communication.Instance.GetAllTeams(utakmica));
            cmbTimovi.DataSource = kategorije;
            cmbTimovi.DisplayMember = "NazivTima";
            cmbTimovi.SelectedIndex = -1;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
