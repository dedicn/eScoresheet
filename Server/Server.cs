using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using Common;
using Common.Domain;
using DBBroker;
using Server.SystemOperations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Globalization;
using System.Windows.Forms;
using System.ComponentModel;


namespace Server
{
    public class Server
    {

        public List<ClientHandler> clients = new List<ClientHandler>();
        Socket socket;

        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {

            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

                socket.Bind(endPoint);
                socket.Listen(10);

                Thread thread = new Thread(AcceptClient);
                thread.Start();
            }
            catch (SocketException)
            {
                MessageBox.Show("Server ne moze da se pokrene jer je soket vec zauzet!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
            Broker broker = new Broker();
            Tim t = new Tim();
            t.TimID = 12085;
            Igrac ig = new Igrac();
            ig.IgracID = 3643648;
            RezultatIgraca rez = new RezultatIgraca();
            rez.Igrac = ig;
            rez.BrojLicnihGresaka = 2;
            
            Utakmica ut = new Utakmica();
            ut.UtakmicaID = 6526521;
            rez.Utakmica = ut;
            ut.igraci = new List<RezultatIgraca>();
            ut.igraci.Add(rez);
            UnesiRezultatSO iz = new UnesiRezultatSO(ut);
            iz.ExecuteTemplate();
        }

        public void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = socket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket, this);
                    clients.Add(handler);
                    Thread klijentskaNit = new Thread(handler.HandleRequest);
                    klijentskaNit.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        public void Stop()
        {
            socket?.Close();
            socket = null;
            foreach(ClientHandler handler in clients)
            {
                handler.ZatvoriKonekciju();
            }
        }

        public List<PrikazZapisnicar> CheckClients()
        { 
            List<PrikazZapisnicar> vrati = new List<PrikazZapisnicar> ();
            foreach(ClientHandler handler in clients)
            {
                if(handler != null && handler.isLoged == true)
                {
                    vrati.Add(new PrikazZapisnicar() { Username = handler.zapisnicar.Username});
                }
            }
            return vrati;
        }
    }
}
