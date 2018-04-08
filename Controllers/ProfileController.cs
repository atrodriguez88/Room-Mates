using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Room_Mates.Controllers.Resources;
using Room_Mates.Core.Models;
using Room_Mates.Persistent;

namespace Room_Mates.Controllers
{
    [Route("/api/profiles")]
    public class ProfileController : Controller
    {
        private readonly RoomDbContext context;
        private readonly IMapper mapper;
        public ProfileController(RoomDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProfile([FromBody] ProfileResource profileResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var profile = mapper.Map<ProfileResource, Core.Models.Profile>(profileResource);
            profile.MovingDate = DateTime.Now;
            
            await context.AddAsync(profile);
            await context.SaveChangesAsync();

            return Ok(mapper.Map<Core.Models.Profile, ProfileResource>(profile));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> SaveProfile(int id, [FromBody] ProfileResource profileResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var profile = await context.Profiles.FindAsync(id);
            mapper.Map<ProfileResource, Core.Models.Profile>(profileResource, profile);
            profile.MovingDate = DateTime.Now;

            await context.SaveChangesAsync();

            return Ok(mapper.Map<Core.Models.Profile, ProfileResource>(profile));
        }

        [HttpGet]
        public async Task<IActionResult> GetProfiles()
        {
            var users = await context.Profiles.Include(p => p.Ocupation).ToListAsync();
            if (users == null)
            {
                return NoContent();
            }
            return Ok(mapper.Map<List<Core.Models.Profile>, List<ProfileResource>>(users));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var profile = await context.Profiles.Include(p => p.Ocupation).SingleOrDefaultAsync(p => p.Id == id);
            if (profile == null)
            {
                return NotFound();
            }
            var profileResource = mapper.Map<Core.Models.Profile, ProfileResource>(profile);
            return Ok();
        }

    }
}