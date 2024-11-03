using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class TipUtakmice : IEntity
    {
        public int TipID{ get; set; }
        public string NazivTipa { get; set;}

        public string TableName => "TipUtakmice";

        public string Values => $"'{NazivTipa}'";

        public TipUtakmice Self => this;
        public object JoinValues => throw new NotImplementedException();

        public object JoinCondition => throw new NotImplementedException();

        public object UpdateValues { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object UpdateCondition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        object IEntity.JoinValues { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        object IEntity.JoinCondition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                TipUtakmice city = new TipUtakmice()
                {
                    TipID = (int)reader["TipID"],
                    NazivTipa = (string)reader["NazivTipa"],
                    
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
                TipUtakmice city = new TipUtakmice()
                {
                    TipID = (int)reader["TipID"],
                    NazivTipa = (string)reader["NazivTipa"],

                };
                list.Add(city);
            }

            return list;
        }
    }
}
