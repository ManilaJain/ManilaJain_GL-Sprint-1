using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projectAPI.Controllers
{
    [Route("api/task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Task> GetAllTasks()
        {
            var taskList = new List<Task>();
            // Call repository layer to get all tasks
            // taskList = ProjectRepository.GetAllTasks();
            return taskList;
        }

        [HttpGet]
        [Route("{taskId}")]
        public Task GetTask(int taskId)
        {
            var task = new Task();
            // Call repository layer to get task
            // project = ProjectRepository.GetTask();
            return task;
        }

        [HttpPut]
        public bool UpdateTask([FromBody] Task taskDetail)
        {
            bool taskUpdated = false;
            // Call repository layer to update task
            // taskUpdated = ProjectRepository.UpdateTask(taskDetail);
            return taskUpdated;
        }

        [HttpPost]
        public bool CreateTask([FromBody] Task taskDetail)
        {
            bool taskCreated = false;
            // Call repository layer to update task
            // taskCreated = ProjectRepository.CreateTak(taskDetail);
            return taskCreated;
        }
    }
}
