using Application.Command;
using Application.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Report_Center.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] ReportCenterCommand command)
        {
            var result = await _ticketService.GetAfterDatTicket(command);
            return Ok(result);
        }

        [HttpGet("getyear")]
        public async Task<IActionResult> GetSP([FromQuery] ReportCenterCommand command)
        {
            var result = await _ticketService.Getyearticket(command);
            return Ok(result);
        }

        [HttpGet("get6month")]
        public async Task<IActionResult> Get6Month([FromQuery] ReportCenterCommand command)
        {
            var result = await _ticketService.Get6MonthTicket(command);
            return Ok(result);
        }


        [HttpGet("getthismonth")]
        public async Task<IActionResult> GetThisMonth([FromQuery] ReportCenterCommand command)
        {
            var result = await _ticketService.GetThisMonth(command);
            return Ok(result);
        }


    }

}
