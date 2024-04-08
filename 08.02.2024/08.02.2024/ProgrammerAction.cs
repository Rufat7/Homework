using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper;
    public class ProgrammerAction
    {
        private readonly string _connectionString;

        public ProgrammerAction(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Programmer> GetAllProgrammers()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection.Query<Programmer>("SELECT * FROM Cars");
        }
    }

