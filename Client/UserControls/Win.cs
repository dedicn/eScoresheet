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
    public partial class Win : UserControl
    {
        public Win(Common.Domain.Utakmica utakmica, int domaci, int gosti)
        {
            InitializeComponent();
            lblRezultat.Text = "   " + domaci + " : " + gosti;

            if(domaci > gosti)
            {
                lblPobednik.Text = "Pobednik je: " + utakmica.Domacin.NazivTima;
            }else if(gosti > domaci)
            {
                lblPobednik.Text = "Pobednik je: " + utakmica.Gost.NazivTima;
            }
            else
            {
                lblPobednik.Text = "Neresen rezultat!";
            }
        }
    }
}
