
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Browsable(false)]
        public string TableName => "TreningProgram";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "TP";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdateValues => "";
        [Browsable(false)]
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
