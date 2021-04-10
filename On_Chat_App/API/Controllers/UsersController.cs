using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Collections.Generic;
using API.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            
            return await _context.Users.ToListAsync();
               
        }

//Pour Example : api/users/4
         [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id){
            
            return await _context.Users.FindAsync(id);
               
        }
    }
}