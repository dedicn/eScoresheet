using Common;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Sender sender;
        private Receiver receiver;
        private Socket socket;
        private Server server;
        public bool isLoged;
        public bool isLogedOut = false;
        public bool isServerOn;
        public Zapisnicar zapisnicar;

        public override string ToString()
        {
            return zapisnicar != null ? $"{zapisnicar.Username}" : "";
        }

        public ClientHandler(Socket socket, Server server)
        {
            isServerOn = true;
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
            this.server = server;
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {


                    Request req = (Request)receiver.Receive();

                    if (!isServerOn)
                    {
                        Response s = new Response();
                        s.Exception = new IOException();
                        sender.Send(s);
                        break;
                    }
                    Response r = ProcessRequest(req);

                    if (r == null)  
                    {
                        break;
                    }
                    sender.Send(r);
                }
                socket.Close();
                socket = null;
            }
            catch (IOException)
            {

                Debug.WriteLine("Servr ugasen");
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response r = new Response();
            try
            {
                switch (req.Operation)
                {
                    case Operation.Login:
                        r.Result = Controller.Instance.Login((Zapisnicar)req.Argument);
                        zapisnicar = (Zapisnicar)req.Argument;
                        isLoged = true;
                        break;
                    case Operation.Logout:
                        server.clients.Remove(this);
                        zapisnicar = null;
                        isLoged = true;
                        isLoged = false;
                        r = null;
                        break;
                    case Operation.SaveTeam:
                        r.Result = Controller.Instance.SaveTeam((Tim)req.Argument);
                        break;
                    case Operation.GetAllGameTypes:
                        r.Result = Controller.Instance.GetAllGameTypes();
                        break;
                    case Operation.SaveGame:
                        Controller.Instance.SaveGame((Utakmica)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.GetAllTeams:
                        r.Result = Controller.Instance.GetAllTeams((Utakmica)req.Argument);
                        break;
                    case Operation.GetAllPlayers:
                        r.Result = Controller.Instance.GetALlPlayers((Utakmica)req.Argument);
                        break;
                    case Operation.SavePlayer:
                        Controller.Instance.SavePlayer((Igrac)req.Argument);
                        break;
                    case Operation.GetAllTeamsByName:
                        r.Result = Controller.Instance.GetAllTeamsByName((Tim)req.Argument);
                        break;
                    case Operation.GetTeam:
                        r.Result = Controller.Instance.GetTeam((Tim)req.Argument);
                        break;
                    case Operation.UpdateTeam:
                        Controller.Instance.UpdateTeam((Tim)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.UpdateGame:
                        Controller.Instance.UpdateGame((Utakmica)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.UpdatePlayer:
                        Controller.Instance.UpdatePlayer((Igrac)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.GetALlGamesByPass:
                        r.Result = Controller.Instance.GetAllGamesByPass((Utakmica)req.Argument);
                        break;
                    case Operation.GetAllGames:
                        r.Result = Controller.Instance.GetAllGames();
                        break;
                    case Operation.GetGame:
                        r.Result = Controller.Instance.GetGame((Utakmica)req.Argument);
                        break;
                    case Operation.CreateScore:
                        r.Result = Controller.Instance.CreateScore((RezultatIgraca)req.Argument);
                        break;
                    
                    case Operation.GetAllScores:
                        r.Result = Controller.Instance.GetAllScores((RezultatIgraca)req.Argument);
                        break;
                    case Operation.GetAllPlayersByName:
                        r.Result = Controller.Instance.GetAllPlayersByName((Igrac)req.Argument);
                        break;
                    case Operation.DeleteScore:
                        Controller.Instance.DeleteScore((RezultatIgraca)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.saveQuarter:
                        r.Result = Controller.Instance.SaveQuarter((RezultatCetvrtine)req.Argument);
                        break;
                    case Operation.GetPlayer:
                        r.Result = Controller.Instance.GetPlayer((Igrac)req.Argument);
                        break;
                    case Operation.deleteGame:
                        Controller.Instance.DeleteGame((Utakmica)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.deletePlayers:
                        Controller.Instance.DeletePlayers((Tim)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.deleteTeam:
                        Controller.Instance.DeleteTeam((Tim)req.Argument);
                        r.Result = req.Argument;
                        break;

                    case Operation.insertAllPoints:
                        Controller.Instance.SaveScore((Utakmica)req.Argument);
                        r.Result = req.Argument;
                        break;
                }
            }
            catch (Exception ex)
            {
                r.Exception = ex;
                Debug.WriteLine(ex.Message);
                Console.WriteLine("Pukne ovde");
            }
            return r;
        }

        internal void ZatvoriKonekciju()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
