using Npgsql;
using System;
using System.Data;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Services
{
    public class QueryDB
    {

        //
        public static async Task QueryDBTestAsync()
        {
            var connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=P@ris2027!;Database=postgres;";

            await using var conn = new NpgsqlConnection(connectionString);
            await conn.OpenAsync();
            string Patients = "\"Patients\"";
            //await using var cmd = new NpgsqlCommand("SELECT \"Email\" FROM " + Patients, conn);
            await using var cmd = new NpgsqlCommand("SELECT test()", conn);
            await using var reader = await cmd.ExecuteReaderAsync();
            System.Diagnostics.Debug.WriteLine("test");
            while (await reader.ReadAsync())
            {
                System.Diagnostics.Debug.WriteLine(reader.GetString(0));
            }
        }
    }
}
