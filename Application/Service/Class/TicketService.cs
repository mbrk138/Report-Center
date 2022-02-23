using Application.Command;
using Application.Dto;
using Application.Service.Interface;
using Dapper;
using Infrastructure.Persis;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace Application.Service.Class
{
    public class TicketService : ITicketService
    {
        private readonly DateBassDbContext _context;

        public TicketService(DateBassDbContext context)
        {
            _context = context;
        }
        public async Task<List<ReportCenterDto>> GetAfterDatTicket(ReportCenterCommand command)
        {
            var query = " select COUNT(Tickets.Id) 'Count' ,sum(Schedules.Price)'sum' ,YEAR(SubmitDate) as SubmitDate  " +
                        "from Tickets" +
                        " inner join Schedules on Tickets.ScheduleId = Schedules.Id " +
                        $"where FunType = N'{command.FunType}' and WhereBuy ='{(int)command.WhereBuy}' " +
                        " GROUP BY  SubmitDate ";
            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<ReportCenterDto>(query);
                return result.ToList();
            }
        }

        public async Task<List<ReportCenterDto>> Getyearticket(ReportCenterCommand command)
        {
            var query = "SP_Tickets_GetReportDay";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<ReportCenterDto>(query,new { funtype=command.FunType, whrebuy=command.WhereBuy } ,commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<ReportCenterDto>> Get6MonthTicket(ReportCenterCommand command)
        {
            var query = "SP_Tickets_Get6Month";
            using(var connection=_context.CreateConnection())
            {
                var result = await connection.QueryAsync<ReportCenterDto>(query, new { funtype = command.FunType, whrebuy = command.WhereBuy }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<ReportCenterDto>> GetThisMonth(ReportCenterCommand command)
        {
            var query = "SP_Tickets_ThisMonth";
            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<ReportCenterDto>(query, new { funtype = command.FunType, whrebuy = command.WhereBuy }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ReportCenterDto>> GetThisDay(ReportCenterCommand command)
        {
            var query = "SP_Tickes_ThisDay";
            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<ReportCenterDto>(query, new { funtype = command.FunType, whrebuy = command.WhereBuy }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

    }
}
