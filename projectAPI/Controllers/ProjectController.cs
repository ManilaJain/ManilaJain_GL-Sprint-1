using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAPI.Controllers
{
    [Route("api/project")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Project> GetAllProjects()
        {
            var projectList = new List<Project>();
            // Call repository layer to get all projects
            // ProjectList = ProjectRepository.GetAllProjects();
            return projectList;
        }

        [HttpGet]
        [Route("{projectId}")]
        public Project GetProject(int projectId)
        {
            var project = new Project();
            // Call repository layer to get project
            // project = ProjectRepository.GetProject();
            return project;
        }

        [HttpPut]
        public bool UpdateProject([FromBody] Project projectDetail)
        {
            bool projectUpdated = false;
            // Call repository layer to update project
            // projectUpdated = ProjectRepository.UpdateProject(projectDetail);
            return projectUpdated;
        }

        [HttpPost]
        public bool CreateUser([FromBody] Project projectDetail)
        {
            bool projectCreated = false;
            // Call repository layer to update project
            // projectCreated = ProjectRepository.CreateProject(projectDetail);
            return projectCreated;
        }
    }
}
