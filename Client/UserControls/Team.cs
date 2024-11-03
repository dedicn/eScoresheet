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
    public partial class Team : UserControl
    {
        public Team(Tim tim)
        {
            InitializeComponent();
            txtNaziv.Text = tim.NazivTima;
            lblSifraTima.Text = tim.TimID + "";
        }
    }
}
