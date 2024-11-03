using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class RezultatCetvrtine : IEntity
    {
        public int BrojCetvrtine { get; set; }
        public int BrojPoenaDomaci { get; set; }
        public int BrojPoenaGosti { get; set; }
        public int BrojTajmautaDomaci { get; set; }
        public int BrojTajmautaGosti { get; set; }
        public int BrojGresakaDomaci { get; set; }
        public int BrojGresakaGosti { get; set; }
        public Utakmica Utakmica { get; set; }

        public string TableName => "RezultatCetvrtine";

        public string Values => $"'{BrojCetvrtine}', '{BrojPoenaDomaci}', '{BrojPoenaGosti}', '{BrojTajmautaDomaci}', '{BrojTajmautaGosti}', " +
            $"'{BrojGresakaDomaci}', '{BrojGresakaGosti}', '{Utakmica.UtakmicaID}'";

        public object UpdateValues { get ; set ; }
        public object UpdateCondition { get ; set ; }
        public object JoinValues { get ; set ; }
        public object JoinCondition { get ; set ; }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                RezultatCetvrtine city = new RezultatCetvrtine()
                {
                    BrojCetvrtine = (int)reader["BrojCetvrtine"],
                    BrojPoenaDomaci = (int)reader["BrojPoenaDomaci"],
                    BrojPoenaGosti = (int)reader["BrojPoenaGosti"],
                    BrojTajmautaDomaci = (int)reader["BrojTajmautaDomaci"],
                    BrojTajmautaGosti = (int)reader["BrojTajmautaGosti"],
                    BrojGresakaDomaci = (int)reader["BrojGresakaDomaci"],
                    BrojGresakaGosti = (int)reader["BrojGresakaGosti"],
                    Utakmica = new Utakmica()
                    {
                        UtakmicaID = (int)reader["UtakmicaID"],
                        VremePocetka = (DateTime)reader["VremePocetka"],
                        VremeZavrsetka = (reader["VremeZavrsetka"] != DBNull.Value ? (DateTime)reader["VremeZavrsetka"] : (DateTime?)null),
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
                    }

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
                RezultatCetvrtine city = new RezultatCetvrtine()
                {
                    BrojCetvrtine = (int)reader["BrojCetvrtine"],
                    BrojPoenaDomaci = (int)reader["BrojPoenaDomaci"],
                    BrojPoenaGosti = (int)reader["BrojPoenaGosti"],
                    BrojTajmautaDomaci = (int)reader["BrojTajmautaDomaci"],
                    BrojTajmautaGosti = (int)reader["BrojTajmautaGosti"],
                    BrojGresakaDomaci = (int)reader["BrojGresakaDomaci"],
                    BrojGresakaGosti = (int)reader["BrojGresakaGosti"],
                    Utakmica = new Utakmica()
                    {
                        UtakmicaID = (int)reader["UtakmicaID"],
                        /*
                        VremePocetka = (DateTime)reader["VremePocetka"],
                        VremeZavrsetka = (reader["VremeZavrsetka"] != DBNull.Value ? (DateTime)reader["VremeZavrsetka"] : (DateTime?)null),
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
                    }

                };
                list.Add(city);
            }

            return list;
        }
    }
}
