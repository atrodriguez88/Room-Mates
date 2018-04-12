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
                .ThenInclude(rpr => rpr.PropertyRules)
            .Include(r => r.PropertyFeatures)
                .ThenInclude(rpf => rpf.PropertyFeatures)
            .Include(r => r.RoomFeatures)
                .ThenInclude(rrf => rrf.RoomFeatures).ToListAsync();

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
                .ThenInclude(rpr => rpr.PropertyRules)
            .Include(r => r.PropertyFeatures)
                .ThenInclude(rpf => rpf.PropertyFeatures)
            .Include(r => r.RoomFeatures)
                .ThenInclude(rrf => rrf.RoomFeatures).SingleOrDefaultAsync(r => r.Id == id);

            if (room == null)
                return NotFound();            

            var roomResource = mapper.Map<Room, RoomResource>(room);
            return Ok(roomResource);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] SaveRoomResource roomResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var room = mapper.Map<SaveRoomResource, Room>(roomResource);
            room.AvailableFrom = DateTime.Now;

            await context.Rooms.AddAsync(room);
            await context.SaveChangesAsync();

            // Para devolver un forma de objetos en el API
            room = await context.Rooms
            .Include(r => r.Rules)
                .ThenInclude(rpr => rpr.PropertyRules)
            .Include(r => r.PropertyFeatures)
                .ThenInclude(rpf => rpf.PropertyFeatures)
            .Include(r => r.RoomFeatures)
                .ThenInclude(rrf => rrf.RoomFeatures).SingleOrDefaultAsync(r => r.Id == room.Id);

            return Ok(mapper.Map<Room, RoomResource>(room));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> SaveRoom(int id, [FromBody] SaveRoomResource roomResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // var room = await context.Rooms.FindAsync(id);

            var room = await context.Rooms
            .Include(r => r.Rules)
                .ThenInclude(rpr => rpr.PropertyRules)
            .Include(r => r.PropertyFeatures)
                .ThenInclude(rpf => rpf.PropertyFeatures)
            .Include(r => r.RoomFeatures)
                .ThenInclude(rrf => rrf.RoomFeatures).SingleOrDefaultAsync(r => r.Id == id);

            mapper.Map<SaveRoomResource, Room>(roomResource, room);
            room.AvailableFrom = DateTime.Now;

            await context.SaveChangesAsync();    

            return Ok(mapper.Map<Room, RoomResource>(room));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var room = await context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            context.Rooms.Remove(room);
            await context.SaveChangesAsync();
            return Ok(id);
        }
    }
}