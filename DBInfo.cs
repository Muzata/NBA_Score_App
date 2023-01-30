using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace SQLite
{
    internal class DBInfo
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Team { get; set; }
        public string HomeGame { get; set; }
        public string AwayGame { get; set; }

        public DBInfo() { }

        public DBInfo(string C1, string C2, string C3)
        {
            Team = C1;
            HomeGame = C2;
            AwayGame = C3;
        }

    }
}
