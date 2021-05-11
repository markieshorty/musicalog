using Microsoft.AspNetCore.Mvc;
using Musicalog.Domain.Coordinators;
using Musicalog.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Musicalog.Api
{
    [Route("[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumCoordinator _albumCoordinator;
        public AlbumController(IAlbumCoordinator albumCoordinator)
        {
            _albumCoordinator = albumCoordinator;
        }
        // GET: api/<AlbumController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AlbumController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AlbumController>
        [HttpPost]
        public ActionResult Post([FromBody] Album album)
        {
            var newAlbum = _albumCoordinator.InsertAlbum(album);
            return Created($"uri+{newAlbum.AlbumId}", newAlbum);
        }

        // PUT api/<AlbumController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlbumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
