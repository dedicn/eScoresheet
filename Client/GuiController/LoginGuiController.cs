using Common;
using Common.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class LoginGuiController
    {
        private FrmLogin loginForma;

        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }

        private LoginGuiController() { }

        internal void ShowFrmLogin()
        {
            try
            {
                Communication.Instance.Connect();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                loginForma = new FrmLogin();
                loginForma.AutoSize = true;
                Application.Run(loginForma);
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        public void Login(object sender, EventArgs e)
        {
            
            Zapisnicar zapisnicar = new Zapisnicar
            {
                Username = loginForma.TxtUsername.Text,
                Password = loginForma.TxtPassword.Text,
            };
            Response response = Communication.Instance.Login(zapisnicar);
            if (response.Exception == null && response.Result != null)
            {
                
                MessageBox.Show("Uspesno ste se ulogvali!", "Uspesno ulogvanje");
                loginForma.Visible = false;
                MainCoordinator.Instance.ShowFrmMain(loginForma);
            }else if(response.Exception == null)
            {
                MessageBox.Show("Ne postoji zapisnicar sa tim kredencijalima!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginForma.TxtPassword.Text = "";
                loginForma.TxtUsername.Text = "";
            }
            else
            {
                MessageBox.Show(">>>" + response.Exception.ToString());
            }
        }
    }
}
