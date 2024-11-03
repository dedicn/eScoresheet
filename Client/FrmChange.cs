using Client.GuiController;
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
    public partial class FrmChange : Form
    {
        public FrmChange()
        {
            InitializeComponent();
            msUtakmica.Click += (s, a) => MainCoordinator.Instance.ShowGamepanel();
            msIgrqaci.Click += (s, a) => MainCoordinator.Instance.ShowPlayersPanel();
            msTimovi.Click += (s, a) => MainCoordinator.Instance.ShowTeamPanel();
            msKrajUnosa.Click += (s, a) => MainCoordinator.Instance.StartGame();
        }

        public void ChangePanel(Control control)
        {
            pnlChange.Controls.Clear();
            pnlChange.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            //pnlChange.AutoSize = true;
            //pnlChange.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void FrmChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainCoordinator.Instance.CheckMainFrmData();
            throw new Exception("Izadji");
            Application.Exit();
        }
    }
}
