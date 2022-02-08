using Infrastructure.Persis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Application.Service.Interface;
using System.Threading.Tasks;
using Application.Dto;
using Application.Command;
using Dapper;

namespace Application.Service.Class
{
    public class TicketService :ITicketService
    {
        private readonly DateBassDbContext _context;

        public TicketService(DateBassDbContext context)
        {
            _context = context;
        }

        public async Task<List<ReportCenterDto>> GetAfterDatTicket(RepotCenterCommand command)
        {
            var query = "";
            using (var connection=_context.CreateConnection())
            {
                var result = await connection.QueryAsync<ReportCenterDto>(query);
                return result.ToList();
            }

        }
    }
}
