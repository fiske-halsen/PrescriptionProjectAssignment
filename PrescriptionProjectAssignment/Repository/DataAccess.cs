using PrescriptionProjectAssignment.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using PrescriptionProjectAssignment.Models;

namespace PrescriptionProjectAssignment.Repository
{
    public class DataAccess
    {
        private readonly DapperContext _dapperContext;

        public DataAccess(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<IEnumerable<EmailPrescriptionEntry>> GetDailyEmailPrescriptionReminders()
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var emails = await connection.QueryAsync<EmailPrescriptionEntry>("SELECT * FROM test()");

                return emails;
            }
        }

    }
}
