using InvoiceManagement.API.Data;
using InvoiceManagement.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InvoiceManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            var user = _context.Users
                .FirstOrDefault(u =>
                    u.Username == login.Username &&
                    u.Password == login.Password);

            if (user == null)
            {
                return Unauthorized("Invalid username or password");
            }

            return Ok(new
            {
                message = "Login successful",
                username = user.Username,
                role = user.Role
            });
        }
    }
}
