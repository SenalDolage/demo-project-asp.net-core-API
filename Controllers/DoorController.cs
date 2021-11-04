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
        public ActionResult<Door> Get(int id) => _operationService.GetSingleDoor(id);

        [HttpPost]
        public void Create(Door door) => _operationService.Create(door);

        [HttpPut("{id}")]
        public IActionResult Update(int id, Door door)
        {
            var doorToUpdate = _operationService.GetSingleDoor(id);
            if (doorToUpdate == null)
            {
                return NotFound();
            }
            _operationService.Update(doorToUpdate.doorId, door);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var project = _operationService.GetSingleDoor(id);
            if (project == null)
            {
                return NotFound();
            }
            _operationService.Delete(project.projectId);
            return NoContent();
        }
    }
}
