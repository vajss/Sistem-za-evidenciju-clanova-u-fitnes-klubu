﻿using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domen
{
    public interface IEntity
    {
        string TableName { get; }
        string InsertValues { get; }
        string IdName { get; }
        string JoinCondition { get; }
        string JoinTable { get; }
        string TableAlias { get; }
        object SelectValues { get; }
        string WhereCondition { get; }
        string GetUpdateValues { get; }
        string GeneralCondition { get; }
        List<IEntity> GetEntities(SqlDataReader reader);
    }
}
