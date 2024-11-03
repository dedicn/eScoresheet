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
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
            btnIzmena.Click += StartGameGuiController.Instance.ChangeScore;
            btnLicna.Click += StartGameGuiController.Instance.AddFaul;
            btnPoen.Click += StartGameGuiController.Instance.AddPoint;
            btnSLedeca.Click += StartGameGuiController.Instance.NextQuarter;
            btnTajmDomaci.Click += StartGameGuiController.Instance.HostTime;
            btnTajmGosti.Click += StartGameGuiController.Instance.GuestTime;
            btnIzbrisiLicnu.Click += StartGameGuiController.Instance.CorrectFaul;
        }

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainCoordinator.Instance.CheckData();
            Application.Exit();
        }
    }
}
