using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Igrac : IEntity
    {
        public int IgracID { get; set; }
        public string ImePrezime { get; set; }
        public string BrojDresa { get; set; }
        public Tim Tim{ get; set; }
        public string TableName => "Igrac";

        public int UtakmicaID{ get; set; }

        public string Values => $"'{IgracID}','{ImePrezime}', '{BrojDresa}', '{Tim.TimID}'";

        public object JoinValues { get; set ; }
        public object JoinCondition { get ; set; }
        public object UpdateValues { get; set; }
        public object UpdateCondition { get ; set ; }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();   
            while (reader.Read())
            {
                Igrac city = new Igrac()
                {
                    IgracID = (int)reader["IgracID"],
                    ImePrezime = (string)reader["ImePrezime"],
                    BrojDresa = (string)reader["BrojDresa"],
                    Tim = new Tim()
                    {
                        TimID = (int)reader["TimID"],
                        NazivTima = (string)reader["NazivTima"]
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

                Igrac igrac = new Igrac();
                igrac.IgracID = (int)reader[0];
                igrac.ImePrezime = (string)reader[1];
                igrac.BrojDresa = (string)reader[2];
                igrac.Tim = new Tim();
                igrac.Tim.TimID = (int)reader[3];
                igrac.Tim.NazivTima = (string)reader[4];
                list.Add(igrac);
            }

            return list;
        }
    }
}
