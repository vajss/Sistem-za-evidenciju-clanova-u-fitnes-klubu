using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;

namespace Domain
{
    [Serializable]
    public class Termin : IEntity
    {
        public int Id { get; set; }
        public string TerminId { get; set; }
        public DateTime Datum { get; set; }
        public int Trajanje { get; set; }
        public Grupa Grupa { get; set; }

        [Browsable(false)]
        public string TableName => "Termin";
        [Browsable(false)]
        public string InsertValues => $"'{TerminId}','{Datum:d.M.yyyy. HH:mm:ss}', '{Trajanje}', {Grupa.Id}";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "ON (TE.GrupaId = G.Id)";
        [Browsable(false)]
        public string JoinTable => "JOIN Grupa G";
        [Browsable(false)]
        public string TableAlias => "TE";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => $"TE.Id={Id}";
        [Browsable(false)]
        public string GetUpdateValues => "";
        [Browsable(false)]
        public string GCondition { get; set; }
        [Browsable(false)]
        public string GeneralCondition => $"{GCondition}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Termin
                {
                    Id = (int)reader[0],
                    TerminId = (string)reader[1],
                    //Datum = Convert.ToDateTime(reader[2]),
                    Datum = DateTime.ParseExact(reader[2].ToString(), "d.M.yyyy. HH:mm:ss", CultureInfo.InvariantCulture),
                    Trajanje = (int)reader[3],
                    Grupa = new Grupa { 
                        Id = (int)reader[5],
                        Naziv = (string)reader[6]
                    }
                });
            }
            return result;
        }
    }
}
