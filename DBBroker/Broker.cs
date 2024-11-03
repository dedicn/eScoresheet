using Common;
using Common.Domain;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }

        public void ponisti()
        {
            connection.Rollback();
        }

        public void potvrdi()
        {
            connection.Commit();
        }

        public void zapocniTransakciju()
        {
            connection.BeginTransaction();
        }

        public void zatvoriKonekciju()
        {
            connection.CloseConnection();
        }

        public void otvoriKonekciju()
        {
            connection.OpenConnection();
        }

        public Zapisnicar Login(Zapisnicar zapisnicar)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from [Zapisnicar] where username = '{zapisnicar.Username}' and password = '{zapisnicar.Password}'";
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    zapisnicar.Ime = (string)reader["Ime"];
                    zapisnicar.Prezime = (string)reader["Prezime"];
                    zapisnicar.Id = (int)reader["ID"];
                    return zapisnicar;
                }
            }
            finally
            {
                reader.Close();
            }
            return null;
        }

        public void Add(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {obj.TableName} values({obj.Values})";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public int AddAndReturnID(IEntity obj, string Column)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {obj.TableName} output inserted.{Column} values({obj.Values} )";
            int insertedId = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            return insertedId;
        }

        public List<IEntity> getAll(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {obj.TableName}";
            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = obj.GetReaderList(reader);
            reader.Close();
            command.Dispose();
            return list;
        }

        public List<IEntity> getAllWithCondition(IEntity obj, string condition="")
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select {obj.JoinValues} from {obj.TableName} {obj.JoinCondition} {condition}";
            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = obj.GetReaderListJoin(reader);
            reader.Close();
            command.Dispose();
            return list;
        }

        public void Update(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"update {obj.TableName} set {obj.UpdateValues} where {obj.UpdateCondition}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void Delete(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"delete from {obj.TableName} where {obj.UpdateValues}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
