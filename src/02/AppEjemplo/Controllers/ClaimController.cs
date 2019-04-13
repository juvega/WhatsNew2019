using AppEjemplo.Models;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEjemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase    
    {
        private readonly ClaimsDbContext _claimsDbContext;
        public ClaimController(ClaimsDbContext claimsDbContext)
        {
            _claimsDbContext = claimsDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Claims>>> GetClaims()
        {
            var fake = new Faker();
            var takeValue = fake.Random.Number(200, 250);
            return Ok(await _claimsDbContext.Claims.Take(takeValue).ToListAsync());
        }
    }
}
