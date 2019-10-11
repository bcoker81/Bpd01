using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bpd01.Controllers
{
    [ApiController]
    [Route("grants")]
    public class GrantController : ControllerBase
    {
        private readonly ILogger<GrantController> _logger;
        private readonly GRANTrakContext _context;
        public GrantController(ILogger<GrantController> logger, GRANTrakContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("status{gStatus}")]
        public async Task<IActionResult> GetByStatus(int gStatus)
        {
            return null;
        }
    }
}