
using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Domain
{
    [Serializable]
    public class TreningProgram : IEntity
    {
        public int Id { get; set; }

        public int Tezina { get; set; }

        public string Naziv { get; set; }

        public int Cena { get; set; }

        public string TableName => "TreningProgram";

        public string InsertValues => "";

        public string IdName => "Id";

        public string JoinCondition => "";

        public string JoinTable => "";

        public string TableAlias => "";

        public object SelectValues => "*";

        public string WhereCondition => "";

        public string GetUpdateValues => "";

        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();

            while (reader.Read())
            {
                result.Add(new TreningProgram
                {
                    Id = (int)reader[0],
                    Tezina = (int)reader[1],
                    Naziv = (string)reader[2],
                    Cena = (int)reader[3]
                });
            }
            return result;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
