using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class RezultatIgraca : IEntity
    {
        public Igrac Igrac{ get; set; }
        public Utakmica Utakmica{ get; set; }
        public int RedniBroj{ get; set; }
        public int BrojPoena{ get; set; }
        public int BrojLicnihGresaka{ get; set; }

        public string TableName => "RezultatIgraca";

        public string Values => $"'{Igrac.IgracID}', '{Utakmica.UtakmicaID}', '{BrojPoena}', '{BrojLicnihGresaka}'";

        public object JoinValues { get ; set ; }
        public object JoinCondition { get; set ; }
        public object UpdateValues { get; set ; }
        public object UpdateCondition { get ; set ; }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                RezultatIgraca city = new RezultatIgraca()
                {
                    Igrac = new Igrac()
                    {
                        IgracID = (int)reader["IgracID"],
                        ImePrezime = (string)reader["ImePrezime"],
                        BrojDresa = (string)reader["BrojDresa"],
                        Tim = new Tim()
                        {
                            TimID = (int)reader["TimID"],
                            NazivTima = (string)reader["NazivTima"]
                        }
                    },
                    Utakmica = new Utakmica()
                    {
                        UtakmicaID = (int)reader["UtakmicaID"],
                        VremePocetka = (DateTime)reader["VremePocetka"],
                        VremeZavrsetka = (DateTime)reader["VremeZavrsetka"],
                        Mesto = (string)reader["Mesto"],
                        Domacin = new Tim()
                        {
                            TimID = (int)reader["TimID"],
                            NazivTima = (string)reader["NazivTima"],
                        },
                        Gost = new Tim()
                        {
                            TimID = (int)reader["TimID"],
                            NazivTima = (string)reader["NazivTima"],
                        },
                        Tip = new TipUtakmice()
                        {
                            TipID = (int)reader["TipID"],
                            NazivTipa = (string)reader["NazivTipa"],
                        }
                    },
                    BrojPoena = (int)reader["BrojPoena"],
                    BrojLicnihGresaka = (int)reader["BrojLicnihGresaka"]
                };
                list.Add(city);
            }

            return list;
        }

        public List<IEntity> GetReaderListJoin(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                RezultatIgraca city = new RezultatIgraca()
                {
                    Igrac = new Igrac()
                    {
                        IgracID = (int)reader["IgracID"],
                        /*ImePrezime = (string)reader["ImePrezime"],
                        BrojDresa = (string)reader["BrojDresa"],
                        Tim = new Tim()
                        {
                            TimID = (int)reader["TimID"],
                            NazivTima = (string)reader["NazivTima"]
                        }*/
                    },
                    Utakmica = new Utakmica()
                    {
                        UtakmicaID = (int)reader["UtakmicaID"],
                        /*VremePocetka = (DateTime)reader["VremePocetka"],
                        VremeZavrsetka = (DateTime)reader["VremeZavrsetka"],
                        Mesto = (string)reader["Mesto"],
                        Domacin = new Tim()
                        {
                            TimID = (int)reader["TimID"],
                            NazivTima = (string)reader["NazivTima"],
                        },
                        Gost = new Tim()
                        {
                            TimID = (int)reader["TimID"],
                            NazivTima = (string)reader["NazivTima"],
                        },
                        Tip = new TipUtakmice()
                        {
                            TipID = (int)reader["TipID"],
                            NazivTipa = (string)reader["NazivTipa"],
                        }*/
                    },
                    BrojPoena = (int)reader["BrojPoena"],
                    BrojLicnihGresaka = (int)reader["BrojLicnihGresaka"],
                    
                };
                list.Add(city);
            }

            return list;
        }
    }
}
