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
    public partial class AllGamesPanel : UserControl
    {
        public AllGamesPanel(Utakmica utakmica)
        {
            InitializeComponent();
            //dgvUtakmice.DataSource = null;
            BindingList<Utakmica> kategorije = new BindingList<Utakmica>((List<Utakmica>)Communication.Instance.GetAllGames());
            dgvUtakmice.DataSource = kategorije;
            foreach (DataGridViewColumn kolona in dgvUtakmice.Columns)
            {
                kolona.Visible = false;
            }
            dgvUtakmice.Columns["UtakmicaID"].Visible = true;
            dgvUtakmice.Columns["VremePocetka"].Visible = true;
            dgvUtakmice.Columns["Mesto"].Visible = true;

            /*dgvUtakmice.Columns["Domacin"].Visible = false;
            dgvUtakmice.Columns["Gost"].Visible = false;
            dgvUtakmice.Columns["Tip"].Visible = false;
            
            DataGridViewComboBoxColumn atCol = new DataGridViewComboBoxColumn();
            atCol.DataSource = new BindingList<TipUtakmice>((List<TipUtakmice>)Communication.Instance.GetAllGameTypes());
            
            atCol.DataPropertyName = "TipUtakmice";
            atCol.DisplayMember = "NazivTipa";
            atCol.ValueMember = "Self";

            atCol.Name = "TipUtakmice";
            dgvUtakmice.Columns.Add(atCol);


            */


        }
    }
}
