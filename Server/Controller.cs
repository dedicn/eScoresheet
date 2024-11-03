using Common;
using Common.Domain;
using DBBroker;
using Server.SystemOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        private Broker broker;

        private static Controller instace;

        public static Controller Instance { get
            {
                if(instace == null) instace = new Controller();
                return instace;
            } 
        }

        private Controller() { broker = new Broker(); }


        public Zapisnicar Login(Zapisnicar zapisnicar)
        {
            LoginSO so = new LoginSO(zapisnicar);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal Tim SaveTeam(Tim argument)
        {
            UnesiTimSO unesi = new UnesiTimSO(argument);
            unesi.ExecuteTemplate();
            return unesi.Result;
        }

        internal object GetAllGameTypes()
        {
            UcitajTipoveUtakmicaSO kategorije = new UcitajTipoveUtakmicaSO();
            kategorije.ExecuteTemplate();
            return kategorije.Result;
        }

        internal void SaveGame(Utakmica argument)
        {
            UnesiUtakmicuSO unos = new UnesiUtakmicuSO(argument);
            unos.ExecuteTemplate();
        }

        internal object GetAllTeams(Utakmica argument)
        {
            UcitajTimoveSO ucitaj = new UcitajTimoveSO(argument);
            ucitaj.ExecuteTemplate();
            return ucitaj.Result;
        }

        internal object GetALlPlayers(Utakmica argument)
        {
            UcitajIgraceSO ucitaj = new UcitajIgraceSO(argument);
            ucitaj.ExecuteTemplate();
            return ucitaj.Result;
        }

        internal void SavePlayer(Igrac argument)
        {
            UnesiIgracaSO unesi = new UnesiIgracaSO(argument);
            unesi.ExecuteTemplate();
        }

        internal object GetAllTeamsByName(Tim argument)
        {
            NadjiTimoveSO unesi = new NadjiTimoveSO(argument);
            unesi.ExecuteTemplate();
            return unesi.Result;
        }

        internal object GetTeam(Tim argument)
        {
            UcitajTimSO ucitaj = new UcitajTimSO(argument);
            ucitaj.ExecuteTemplate();
            return ucitaj.Result;
        }

        internal void UpdateTeam(Tim argument)
        {
            IzmeniTimSO izmeni = new IzmeniTimSO(argument);
            izmeni.ExecuteTemplate();
        }

        internal void UpdateGame(Utakmica argument)
        {
            IzmeniUtakmicuSO izmeni = new IzmeniUtakmicuSO(argument);
            izmeni.ExecuteTemplate();
        }

        internal void UpdatePlayer(Igrac argument)
        {
            IzmeniIgracaSO izmeni = new IzmeniIgracaSO(argument);
            izmeni.ExecuteTemplate();
        }

        internal object GetAllGamesByPass(Utakmica argument)
        {
            NadjiUtakmiceSO nadji = new NadjiUtakmiceSO(argument);
            nadji.ExecuteTemplate();
            return nadji.Result;
        }

        internal object GetAllGames()
        {
            UcitajUtakmiceSO ucitajUtakmiceSO = new UcitajUtakmiceSO();
            ucitajUtakmiceSO.ExecuteTemplate();
            return ucitajUtakmiceSO.Result;
        }

        internal object GetGame(Utakmica argument)
        {
            UcitajUtakmicuSO ucitaj = new UcitajUtakmicuSO(argument);
            ucitaj.ExecuteTemplate();
            return ucitaj.Result;
        }

        internal void SaveScore(Utakmica argument)
        {
            UnesiRezultatSO unesi = new UnesiRezultatSO(argument);
            unesi.ExecuteTemplate();
        }

        internal object CreateScore(RezultatIgraca argument)
        {
            KreirajRezultatSO ucitaj = new KreirajRezultatSO(argument);
            ucitaj.ExecuteTemplate();
            return ucitaj.Result;
        }

        internal object GetAllScores(RezultatIgraca argument)
        {
            NadjiRezultateSO ucitaj = new NadjiRezultateSO(argument);
            ucitaj.ExecuteTemplate();
            return ucitaj.Result;
        }

        internal object GetAllPlayersByName(Igrac argument)
        {
            NadjiIgrqaceSO nadji = new NadjiIgrqaceSO(argument);
            nadji.ExecuteTemplate();
            return nadji.Result;
        }

        internal void DeleteScore(RezultatIgraca argument)
        {
            ObrisiRezultatSO obrisi = new ObrisiRezultatSO(argument);
            obrisi.ExecuteTemplate();
        }

        internal object SaveQuarter(RezultatCetvrtine argument)
        {
            IzracunajRezultatSO iz = new IzracunajRezultatSO(argument );
            iz.ExecuteTemplate();
            return iz.Result;
        }

        internal object GetPlayer(Igrac argument)
        {
            UcitajIgracaSO uc = new UcitajIgracaSO(argument);
            uc.ExecuteTemplate();
            return uc.Result;
        }

        internal void DeleteGame(Utakmica argument)
        {
            IzbrisiUtakmicu uc = new IzbrisiUtakmicu(argument);
            uc.ExecuteTemplate();
        }

        internal void DeletePlayers(Tim argument)
        {
            IzbrisiIgrace uc = new IzbrisiIgrace(argument);
            uc.ExecuteTemplate();
        }

        internal void DeleteTeam(Tim argument)
        {
            IzbrisiTim uc = new IzbrisiTim(argument);
            uc.ExecuteTemplate();
        }
    }
}
