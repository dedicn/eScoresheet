using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Zapisnicar : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string TableName => "Zapisnicar";

        public string Values => $"'{Username}', '{Password}', '{Ime}', '{Prezime}'";

        public object JoinValues => throw new NotImplementedException();

        public object JoinCondition => throw new NotImplementedException();

        public object UpdateValues { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object UpdateCondition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        object IEntity.JoinValues { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        object IEntity.JoinCondition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetReaderListJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
