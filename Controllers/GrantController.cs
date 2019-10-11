using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bpd01.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class GrantController : ControllerBase {
        private readonly ILogger<GrantController> _logger;
        public GrantController (ILogger<GrantController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GrantModel> Get () {
            return null;
        }
    }
}