using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Tim : IEntity
    {
        public int TimID{ get; set; }
        public string NazivTima { get; set;}

        public int UtakmicaID { get; set; }

        public string TableName => "Tim";

        public string Values => $"'{NazivTima}'";

        public object JoinValues { get; set; }
        public object JoinCondition { get; set; }
        public object UpdateValues { get ; set; }
        public object UpdateCondition { get ; set; }

        

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                Tim city = new Tim()
                {
                    TimID = (int)reader["TimID"],
                    NazivTima = (string)reader["NazivTima"],

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
                Tim city = new Tim()
                {
                    TimID = (int)reader["TimID"],
                    NazivTima = (string)reader["NazivTima"],

                };
                list.Add(city);
            }

            return list;
        }
    }
}
