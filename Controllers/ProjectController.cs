using AssesmentAPI.Models;
using AssesmentAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace AssesmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ProjectService _projectService;

        public ProjectController(ProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public ActionResult<List<Project>> Get() => _projectService.GetProjects();

        [HttpGet("{id}")]
        public ActionResult<Project> Get(string id) => _projectService.GetSingleProject(id);

        [HttpPost]
        public void Create(Project project) => _projectService.Create(project);

        [HttpPut("{id}")]
        public IActionResult Update(string id, Project project)
        {
            var projectToUpdate = _projectService.GetSingleProject(id);
            if (projectToUpdate == null)
            {
                return NotFound();
            }
            _projectService.Update(projectToUpdate.Id, project);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var project = _projectService.GetSingleProject(id);
            if (project == null)
            {
                return NotFound();
            }
            _projectService.Delete(project.Id);
            return NoContent();
        }

    }
}
