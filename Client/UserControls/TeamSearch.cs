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
    public partial class TeamSearch : UserControl
    {
        public TeamSearch(Common.Domain.Utakmica utakmica)
        {
            InitializeComponent();
            //dgvTimovi.DataSource = null;
            BindingList<Tim> kategorije = new BindingList<Tim>((List<Tim>)Communication.Instance.GetAllTeams(utakmica));
            dgvTimovi.DataSource = kategorije;

            foreach (DataGridViewColumn kolona in dgvTimovi.Columns)
            {
                kolona.Visible = false;
            }
            dgvTimovi.Columns["TimID"].Visible = true;
            dgvTimovi.Columns["NazivTima"].Visible = true;
            
        }
    }
}
