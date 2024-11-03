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
    public partial class Cetvrtina : UserControl
    {

        public Cetvrtina(RezultatCetvrtine nova)
        {
            InitializeComponent();
            Nova = nova;
            lblCetvrtina.Text = nova.BrojCetvrtine + "";
            lblPoeniDomaci.Text = nova.BrojPoenaDomaci + "";
            lblPoeniGosti.Text = nova.BrojPoenaGosti + "";
        }

        public RezultatCetvrtine Nova { get; }
    }
}
