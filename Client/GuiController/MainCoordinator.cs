using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        private MainCoordinator()
        {
            
        }

        private FrmMain frmMain;
        private FrmGame frmGame;
        private FrmChange frmChange;
        private FrmHelp frmHelp;
        private FrmLogin frmLogin;

        private Tim domacin;
        private Tim gost;
        private Utakmica utakmica;

        internal void ShowFrmMain(FrmLogin login)
        {
            frmMain = new FrmMain();
            frmMain.AutoSize = true;
            TeamGuiController.Instance.ShowMain(frmMain);
            frmMain.ShowDialog();   
        }

        internal void ShowGameSpecsPanel(Response responseDomacin, Response responseGost)
        {
            domacin = new Tim();
            gost = new Tim();
            domacin = (Tim)responseDomacin.Result;
            gost = (Tim)responseGost.Result;
            frmMain.ChangePanel(GameGuiController.Instance.CreateGameSpecsControl(domacin, gost));
        }

        internal void showHostMemberPanel(Utakmica ut)
        {
            utakmica = ut;
            frmMain.ChangePanel(MembersGuiController.Instance.CreateMembersPanel(ut));
        }

        internal void StartGame()
        {
            if (frmMain != null) { frmMain.Dispose(); }
            if (frmChange != null) { frmChange.Dispose(); }
            frmGame = new FrmGame();
            frmGame.AutoSize = true;
            StartGameGuiController.Instance.ShowGame(frmGame, utakmica);
            frmGame.ShowDialog();
        }

        internal void ShowFrmChange()
        {
            frmMain.Dispose();
            frmChange = new FrmChange();
            frmChange.AutoSize = true;
            frmChange.ShowDialog();
        }

        internal void ShowGamepanel()
        {
            frmChange.ChangePanel(GameGuiController.Instance.ShowGameChangePanel(utakmica));
            Response res = Communication.Instance.GetGame(utakmica);
            if (res.Exception == null)
            {
                utakmica = (Utakmica)res.Result;
            }
        }

        internal void ShowPlayersPanel()
        {
            frmChange.ChangePanel(MembersGuiController.Instance.ShowMembersPanel(utakmica));
        }

        internal void ShowTeamPanel()
        {
            frmChange.ChangePanel(TeamGuiController.Instance.CreateTeamPanel(utakmica));
            Response res = Communication.Instance.GetGame(utakmica);
            if(res.Exception == null)
            {
                utakmica = (Utakmica)res.Result;
            }
        }

        internal void ShowTeamUpdatePanel(Tim vraceniTim)
        {
            frmHelp = new FrmHelp();
            frmHelp.ChangePanel(TeamGuiController.Instance.ShowUpdateTeamPanel(vraceniTim));
            frmHelp.ShowDialog();
        }

        internal void ShutDownFrmHelp()
        {
            frmHelp.Dispose();
        }

        internal void ShowMemberUpdatePanel(Igrac vraceniTim)
        {
            frmHelp = new FrmHelp();
            frmHelp.ChangePanel(MembersGuiController.Instance.ShoUpdateMemberpanel(vraceniTim));
            frmHelp.ShowDialog();
        }

        internal void ShowGameUpdatePanel(Utakmica vraceniTim)
        {
            frmHelp = new FrmHelp();
            frmHelp.ChangePanel(GameGuiController.Instance.ShowGameSpecUpdatePanel(vraceniTim));
            frmHelp.ShowDialog();
        }

        internal void CheckData()
        {
            StartGameGuiController.Instance.CheckScore();
        }

        internal void CheckMainFrmData()
        {
            if(domacin != null && gost!= null)
            {
                if(utakmica == null)
                {
                    Communication.Instance.DeleteTeam(domacin);
                    Communication.Instance.DeleteTeam(gost);
                    return;
                }

                Communication.Instance.DeleteGame(utakmica);
                Communication.Instance.DeletePlayers(gost);
                Communication.Instance.DeletePlayers(domacin);

                Communication.Instance.DeleteTeam(domacin);
                Communication.Instance.DeleteTeam(gost);
            }

            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
            Communication.Instance.Logout();

            //if (frmChange != null) { frmChange.Dispose(); }
            //if(frmGame != null) { frmHelp.Dispose(); }
            //if(frmMain!= null) { frmMain.Dispose(); }
            //if(frmLogin!= null) { frmLogin.Dispose(); }

        }
    }
}
