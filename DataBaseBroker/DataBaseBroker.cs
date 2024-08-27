using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Policy;

namespace DataBaseBroker
{
    public class DBBroker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public DBBroker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FitnesKlub;Integrated Security=True;Connect Timeout=5; MultipleActiveResultSets=true;");
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
            Debug.WriteLine(">>>>>>>>>>> get ALL: " + command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public int Save(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"INSERT INTO {entity.TableName} OUTPUT Inserted.ID VALUES ({entity.InsertValues})";
            Debug.WriteLine(">>>>>>>>>>> Save: " + command.CommandText);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public List<IEntity> GetSpecific(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);

            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} where {entity.GeneralCondition}";
            Debug.WriteLine(">>>>>>>>>>> get specific: " + command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;

        }

        public void Update(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"UPDATE {entity.TableName} SET {entity.GetUpdateValues} WHERE {entity.WhereCondition}";
            Debug.WriteLine(">>>>>>>>>>> Update query: " + command.CommandText);

            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }
    }
}

