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
    [Route("/api/rooms")]
    public class RoomController : Controller
    {
        private readonly RoomDbContext context;
        private readonly IMapper mapper;
        public RoomController(RoomDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetRooms()
        {
            var room = await context.Rooms
            .Include(r => r.Rules)
            .Include(r => r.PropertyFeatures)
            .Include(r => r.RoomFeatures)
            .Include(r => r.PrefOcuppations).ToListAsync();

            if (room == null)
            {
                return NoContent();
            }

            return Ok(mapper.Map<List<Room>, List<RoomResource>>(room));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            var room = await context.Rooms
            .Include(r => r.Rules)
            .Include(r => r.PropertyFeatures)
            .Include(r => r.RoomFeatures)
            .Include(r => r.PrefOcuppations).SingleOrDefaultAsync(r => r.Id == id);

            if (room == null)
                return NotFound();            

            var roomResource = mapper.Map<Room, RoomResource>(room);
            return Ok(roomResource);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] RoomResource roomResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var room = mapper.Map<RoomResource, Room>(roomResource);
            room.AvailableFrom = DateTime.Now;

            await context.Rooms.AddAsync(room);
            await context.SaveChangesAsync();

            return Ok(mapper.Map<Room, RoomResource>(room));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> SaveRoom(int id, [FromBody] RoomResource roomResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // var room = await context.Rooms.FindAsync(id);

            var room = await context.Rooms
            .Include(r => r.Rules)
            .Include(r => r.PropertyFeatures)
            .Include(r => r.RoomFeatures)
            .Include(r => r.PrefOcuppations).SingleOrDefaultAsync(r => r.Id == id);
            mapper.Map<RoomResource, Room>(roomResource, room);
            room.AvailableFrom = DateTime.Now;

            await context.SaveChangesAsync();            

            return Ok(mapper.Map<Room, RoomResource>(room));
        }

    }
}