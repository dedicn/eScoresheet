using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        public void ChangePanel(Control control)
        {
            pnlHelp.Controls.Clear();
            pnlHelp.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            /*          
            pnlHelp.AutoSize = true;
            pnlHelp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            */
        }
    }
}
