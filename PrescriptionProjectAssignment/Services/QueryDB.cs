using Npgsql;
using System;
using System.Data;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Services
{
    public class QueryDB
    {
        public static async Task QueryDBTestAsync()
        {
            var connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=P@ris2027!;Database=postgres;";

            await using var conn = new NpgsqlConnection(connectionString);
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand("INSERT INTO testtable(lastname) VALUES ('JENS') ", conn);
            await using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Console.WriteLine(reader.GetTimeStamp(0));
            }
        }
    }
}
