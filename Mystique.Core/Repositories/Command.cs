﻿using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Mystique.Core.Repositories
{
    public class Command
    {
        public Command()
        {

        }

        public Command(string sql, List<MySqlParameter> parameters)
        {
            Sql = sql;
            Parameters = parameters;
        }

        public string Sql { get; set; }

        public List<MySqlParameter> Parameters { get; set; } = new List<MySqlParameter>();
    }
}
