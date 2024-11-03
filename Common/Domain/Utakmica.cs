using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Utakmica : IEntity
    {
        public int UtakmicaID { get; set; }
        public DateTime VremePocetka { get; set; }
        public DateTime? VremeZavrsetka{ get; set; }
        public string Mesto { get; set;}
        public Tim Domacin{ get; set; }
        public Tim Gost{ get; set; }
        public TipUtakmice Tip{ get; set; }

        public List<RezultatCetvrtine> cetvrtine { get; set; }
        public List<RezultatIgraca> igraci { get; set; }

        public string ImeIgraca{ get; set; }

        public string TableName => "Utakmica";

        public string Values => $"'{UtakmicaID}','{VremePocetka.ToString("yyyy-MM-dd HH:mm")}', '{VremeZavrsetka?.ToString("yyyy-MM-dd HH:mm")}', " +
            $"'{Mesto}', '{Domacin.TimID}', '{Gost.TimID}', '{Tip.TipID}'";

        public object JoinValues { get; set; } = $"Utakmica.UtakmicaID, Domacin.TimID, Domacin.NazivTima, Gost.TimID,Gost.NazivTima";
       
        public object JoinCondition { get; set; } = $"INNER JOIN Tim AS Domacin ON Utakmica.Domacin = Domacin.TimID INNER JOIN Tim AS Gost ON Utakmica.Gost = Gost.TimID";
        public object UpdateValues { get; set ; }
        public object UpdateCondition { get ; set ; }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                Utakmica city = new Utakmica()
                {
                    UtakmicaID = (int)reader["UtakmicaID"],
                    VremePocetka = (DateTime)reader["VremePocetka"],
                    VremeZavrsetka = (DateTime)reader["VremeZavrsetka"],
                    Mesto = (string)reader["Mesto"],
                    Domacin = new Tim()
                    {
                        TimID = (int)reader["DomacinID"],
                        NazivTima = (string)reader["DomacinNazivTima"],
                    },
                    Gost = new Tim()
                    {
                        TimID = (int)reader["GostTimID"],
                        NazivTima = (string)reader["GostNazivTima"],
                    },
                    Tip = new TipUtakmice()
                    {
                        TipID = (int)reader["IDTipa"],
                        //NazivTipa = (string)reader["NazivTipa"],
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
                Utakmica city = new Utakmica()
                {
                    UtakmicaID = (int)reader["UtakmicaID"],
                    VremePocetka = (DateTime)reader["VremePocetka"],
                    VremeZavrsetka = (DateTime)reader["VremeZavrsetka"],
                    Mesto = (string)reader["Mesto"],
                    Domacin = new Tim()
                    {
                        TimID = (int)reader["DomacinID"],
                        NazivTima = (string)reader["DomacinNazivTima"],
                    },
                    Gost = new Tim()
                    {
                        TimID = (int)reader["GostID"],
                        NazivTima = (string)reader["GostNazivTima"],
                    },
                    Tip = new TipUtakmice()
                    {
                        TipID = (int)reader["IDTipa"],
                        //NazivTipa = (string)reader["NazivTipa"],
                    }

                };
                list.Add(city);
            }

            return list;
        }
    }
}

