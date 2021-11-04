using AssesmentAPI.Models;
using AssesmentAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssesmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoorController : ControllerBase
    {
        private readonly DoorService _operationService;

        public DoorController(DoorService operationService)
        {
            _operationService = operationService;
        }

        [HttpGet]
        public ActionResult<List<Door>> Get() => _operationService.GetDoors();

        [HttpGet("{id}")]
        public ActionResult<Door> Get(string id) => _operationService.GetSingleDoor(id);

        [HttpPost]
        public void Create(Door door) => _operationService.Create(door);

        [HttpPut("{id}")]
        public IActionResult Update(string id, Door door)
        {
            var doorToUpdate = _operationService.GetSingleDoor(id);
            if (doorToUpdate == null)
            {
                return NotFound();
            }
            _operationService.Update(doorToUpdate.Id, door);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var doorToUpdate = _operationService.GetSingleDoor(id);
            if (doorToUpdate == null)
            {
                return NotFound();
            }
            _operationService.Delete(doorToUpdate.Id);
            return NoContent();
        }
    }
}
