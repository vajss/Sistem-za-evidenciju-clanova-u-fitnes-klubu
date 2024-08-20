using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Contexts;

namespace DataBaseBroker
{
    public class DBBroker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public DBBroker()
        {
            connection = new SqlConnection("@Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FitnesKlub;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {
            transaction?.Rollback();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public void Save(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"INSERT INTO {entity.TableName} VALUES ({entity.InsertValues})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

/*        public int GetNewId(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select max({entity.IdName}) from {entity.TableName}";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)result;
            }
        }*/

        public List<IEntity> GetSpecific(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} where {entity.GeneralCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;

        }

        public void Update(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"UPDATE {entity.TableName} SET {entity.GetUpdateValues} WHERE {entity.WhereCondition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }
    }
}

