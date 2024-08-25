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
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public object SelectValues => "";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdateValues => "";
        [Browsable(false)]
        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
