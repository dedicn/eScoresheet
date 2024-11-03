using Common;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client
{
    public class Communication
    {
        private static Communication _instance;
        public static Communication Instance
        {
            get
            {
                if (_instance == null) _instance = new Communication();
                return _instance;
            }
        }
        private Communication()
        {

        }

        Socket socket;
        Sender sender;
        Receiver receiver;

        public void Connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));
                sender = new Sender(socket);
                receiver = new Receiver(socket);
            }
            catch (Exception)
            {

                MessageBox.Show("Trenutno se ne moze uspostaviti konekcija sa serverom!");
                foreach (Form form in Application.OpenForms)
                {
                    form.Close();
                }
                Application.Exit();
                throw new Exception("Ugasi");
            }
        }

        internal Response Login(Zapisnicar zapisnicar)
        {
            try
            {
                Request req = new Request
                {
                    Argument = zapisnicar,
                    Operation = Operation.Login
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch(IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response SaveTeam(Tim tim)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.SaveTeam,
                    Argument = tim
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }

        }

        internal void Logout()
        {
            try
            {
                Request request = new Request { Operation = Operation.Logout };
                sender.Send(request);
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        internal object GetAllGameTypes()
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetAllGameTypes
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response.Result;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response SaveGame(Utakmica ut)
        {
            try
            {
                Request request = new Request
                {
                    Argument = ut,
                    Operation = Operation.SaveGame,

                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal object GetAllTeams(Utakmica utakmica)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetAllTeams,
                    Argument = utakmica
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response.Result;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response SavePlayer(Igrac igrac)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.SavePlayer,
                    Argument = igrac
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal object GetPlayersForTeam(Utakmica utakmica)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetAllPlayers,
                    Argument = utakmica
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response.Result;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal object GetAllTeamsByName(Tim utakmica)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetAllTeamsByName,
                    Argument = utakmica
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response.Result;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response GetTeam(Tim tim)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetTeam,
                    Argument = tim
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response UpdateTeam(Tim tim)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.UpdateTeam,
                    Argument = tim
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response UpdateGame(Utakmica tim)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.UpdateGame,
                    Argument = tim
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response UpdatePlayer(Igrac tim)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.UpdatePlayer,
                    Argument = tim
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal object GetAllPlayersByName(Igrac prenos)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetAllPlayersByName,
                    Argument = prenos
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response.Result;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response GetPlayer(Igrac tim)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetPlayer,
                    Argument = tim
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal object GetAllGamesByPass(Utakmica prenos)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetALlGamesByPass,
                    Argument = prenos
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response.Result;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response GetGame(Utakmica tim)
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetGame,
                    Argument = tim
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal object GetAllGames()
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.GetAllGames,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response.Result;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response AddRezultatIgraca(RezultatIgraca odabrani)
        {
            try
            {
                Request request = new Request
                {
                    Argument = odabrani,
                    Operation = Operation.SaveScore,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response createScore(RezultatIgraca novi)
        {
            try
            {
                Request request = new Request
                {
                    Argument = novi,
                    Operation = Operation.CreateScore,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal object GetAllScores(RezultatIgraca r)
        {
            try
            {
                Request request = new Request
                {
                    Argument = r,
                    Operation = Operation.GetAllScores,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response.Result;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response DeleteScore(RezultatIgraca re)
        {
            try
            {
                Request request = new Request
                {
                    Argument = re,
                    Operation = Operation.DeleteScore,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal Response saveQuarter(RezultatCetvrtine nova)
        {
            try
            {
                Request request = new Request
                {
                    Argument = nova,
                    Operation = Operation.saveQuarter,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return response;
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        internal void DeleteTeam(Tim domacin)
        {
            try
            {
                Request request = new Request
                {
                    Argument = domacin,
                    Operation = Operation.deleteTeam,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();

            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        internal void DeleteGame(Utakmica utakmica)
        {
            try
            {
                Request request = new Request
                {
                    Argument = utakmica,
                    Operation = Operation.deleteGame,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();

            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        internal void DeletePlayers(Tim domacin)
        {
            try
            {
                Request request = new Request
                {
                    Argument = domacin,
                    Operation = Operation.deletePlayers,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();

            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;
                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        internal Response InsertAllPoints(Utakmica utakmica)
        {
            try
            {
                Request request = new Request
                {
                    Argument = utakmica,
                    Operation = Operation.insertAllPoints,
                };
                sender.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException ez)
            {
                Response response = new Response();
                response.Exception = ez;

                MessageBox.Show("Greska prilikom prihvatanja podataka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;    
            }
            catch (IOException e)
            {
                MessageBox.Show("Server je prestao sa radom!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }
    }
}
