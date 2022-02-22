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
        public async Task<IActionResult> Get([FromQuery] RepotCenterCommand command)
        {
            var result = await _ticketService.GetAfterDatTicket(command);
            return Ok(result);
        }

        [HttpGet("getSP")]
        public async Task<IActionResult> GetSP([FromQuery] RepotCenterCommand command)
        {
            var result = await _ticketService.GetAfterDatTicketSP(command);
            return Ok(result);
        }


    }
}
