using Application.Command;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service.Interface;

namespace Report_Center.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController :Controller
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get(RepotCenterCommand command)
        {
            var result = await _ticketService.GetAfterDatTicket(command);
            return Ok(result);
        }

    }
}
