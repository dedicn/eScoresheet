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
    public partial class GameSpecs : UserControl
    {
        
        public GameSpecs(string domaci, string gosti)
        {
            InitializeComponent();
            BindingList<TipUtakmice> kategorije = new BindingList<TipUtakmice>((List<TipUtakmice>)Communication.Instance.GetAllGameTypes());
            cmbKategorije.DataSource = kategorije;
            cmbKategorije.DisplayMember = "NazivTipa";
            cmbKategorije.SelectedIndex = -1;
            lblDom.Text = lblDom.Text +  domaci;
            lblGos.Text = lblGos.Text + gosti;
        }
    }
}
