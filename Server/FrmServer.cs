using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;
        private System.Windows.Forms.Timer timer;
        public FrmServer()
        {
            InitializeComponent();
            btnUgasi.Enabled = false;

            
        }


        private void btnPokreni1_Click(object sender, EventArgs e)
        {
            server = new Server();
            //Thread osvezavanje = new Thread(Timer_Tick);
            //osvezavanje.Start();
            //timer = new System.Threading.Timer(Timer_Tick, null, 0, 1000);
            btnUgasi.Enabled = true;
            btnPokreni1.Enabled = false;
            lblServer.Text = "Server je pokrenut";
            server.Start();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            List<PrikazZapisnicar> l = server.CheckClients();
            BindingList<PrikazZapisnicar> list = new BindingList<PrikazZapisnicar>(l);

            dgvKorisnici.DataSource = list;
        }

        private void btnUgasi_Click(object sender, EventArgs e)
        {
            btnPokreni1.Enabled=true;
            btnUgasi.Enabled=false;
            lblServer.Text = "Server je zaustavljen";
            server.Stop();
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            server?.Stop();
            Application.Exit();
        }
    }
}
