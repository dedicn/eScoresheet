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
    public partial class GameUpdate : UserControl
    {
        public GameUpdate(Common.Domain.Utakmica vracena)
        {
            InitializeComponent();
            lblDom.Text = lblDom.Text + " " + vracena.Domacin.NazivTima;
            lblGos.Text = lblGos.Text + " " + vracena.Gost.NazivTima;
            lblSifra.Text = vracena.UtakmicaID + " ";
            txtMesto.Text = vracena.Mesto;
            txtVreme.Text = vracena.VremePocetka.ToString("yyyy-MM-dd HH:mm");
            BindingList<TipUtakmice> kategorije = new BindingList<TipUtakmice>((List<TipUtakmice>)Communication.Instance.GetAllGameTypes());
            cmbKategorije.DataSource = kategorije;
            cmbKategorije.DisplayMember = "NazivTipa";
            cmbKategorije.SelectedIndex = vracena.Tip.TipID;
        }
    }
}
