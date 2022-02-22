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
        Task<List<ReportCenterDto>> GetAfterDatTicket( RepotCenterCommand command);
        Task<List<ReportCenterDto>> GetAfterDatTicketSP(RepotCenterCommand command);

    }
}
