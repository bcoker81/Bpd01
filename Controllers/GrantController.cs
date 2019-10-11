using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BPD01.Models;
using Microsoft.EntityFrameworkCore;

namespace BPD01.Controllers
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

        [HttpGet("status/{s}")]
        public async Task<IEnumerable<Grants>> GetByStatus(int s)
        {
            List<Grants> grantList = new List<Grants>();
            grantList = await _context.Grants.Where(p => p.Status == s).ToListAsync();
            return grantList;
        }

        [HttpGet("single/{id}")]
        public async Task<Grants> GetById(int id)
        {
            var result = await _context.Grants.Where(p => p.Id == id).FirstAsync();
            return result;
        }
    }
}