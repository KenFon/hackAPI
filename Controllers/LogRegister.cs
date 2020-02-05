using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackAPI.Data;
using hackAPI.Dtos;
using hackAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace hackAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class LogController : ControllerBase
    {
        private readonly DataContext _context;

        public LogController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetLogs()
        {
            var logs = await _context.User.ToListAsync();

            return Ok(logs);
        }

        [HttpGet("{comp}")]
        public async Task<IActionResult> GetLogsByCompany(int comp)
        {
            var logs = await _context.User.Where(x => x.Company == comp).ToListAsync();

            return Ok(logs);
        }
    }
}