using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Grupa : IEntity
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int BrojClanova { get; set; }
        public TreningProgram TreningProgram { get; set; }
        public List<Clanstvo> Clanstva { get; set; }
        [Browsable(false)]
        public string TableName => "Grupa";
        [Browsable(false)]
        public string InsertValues => $"'{Naziv}', {BrojClanova}, {TreningProgram.Id}";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "ON (G.TreningProgramId = TP.Id)";
        [Browsable(false)]
        public string JoinTable => "JOIN TreningProgram TP";
        [Browsable(false)]
        public string TableAlias => "G";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdateValues => "";
        [Browsable(false)]
        public string GCondition { get; set; }
        [Browsable(false)]
        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Grupa
                {
                    Id = (int)reader[0],
                    Naziv = (string)reader[1],
                    BrojClanova = (int)reader[2],
                    TreningProgram = new TreningProgram
                    {
                        Id = (int)reader[4],
                        Tezina = (int)reader[5],
                        Naziv = (string)reader[6],
                        Cena = (int)reader[7],
                    }
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
