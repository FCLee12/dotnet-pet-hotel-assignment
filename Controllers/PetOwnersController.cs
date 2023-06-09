using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetOwnersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnersController(ApplicationContext context) {
            _context = context;
        }

[HttpPost]
        public ActionResult Post(PetOwner owner){
            //insert into the table
            _context.Add(owner);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Post), new {id = owner.id}, owner);
        }

        // This is just a stub for GET / to prevent any weird frontend errors that 
        // occur when the route is missing in this controller
        [HttpGet]

        public IEnumerable<PetOwner> GetPetOwners()
        {
            var petOwners = _context.PetOwners.Include(po => po.Pets).ToList();

            return petOwners;
        }

        
    }
}
