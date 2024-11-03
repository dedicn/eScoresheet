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
    public partial class AllMembers : UserControl
    {
        public AllMembers(Common.Domain.Utakmica utakmica)
        {
            InitializeComponent();
            BindingList<Igrac> kategorije = new BindingList<Igrac>((List<Igrac>)Communication.Instance.GetPlayersForTeam(utakmica));
            dgvIgraci.DataSource = kategorije;
            foreach (DataGridViewColumn kolona in dgvIgraci.Columns)
            {
                kolona.Visible = false;
            }
            dgvIgraci.Columns["IgracID"].Visible = true;
            dgvIgraci.Columns["ImePrezime"].Visible = true;
            dgvIgraci.Columns["BrojDresa"].Visible = true;
        }
    }
}
