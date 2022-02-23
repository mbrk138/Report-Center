using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Application.Command;
using Application.Dto;

namespace Application.Service.Interface
{
    public interface ITicketService
    {
        Task<List<ReportCenterDto>> GetAfterDatTicket(ReportCenterCommand command);
        Task<List<ReportCenterDto>> Getyearticket(ReportCenterCommand command);
        Task<List<ReportCenterDto>> Get6MonthTicket(ReportCenterCommand command);
        Task<List<ReportCenterDto>> GetThisMonth(ReportCenterCommand command);
    }
}
