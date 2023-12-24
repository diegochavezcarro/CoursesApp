// Path: CoursesApp.Api/Controllers/CoursesController.cs
using CoursesApp.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoursesApp.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CoursesController : ControllerBase
{
    private readonly ILogger<CoursesController> _logger;

    public CoursesController(ILogger<CoursesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Course> Get()
    {
        _logger.LogInformation("Getting all courses");
        return new List<Course>
        {
            new Course { Id = 1, Name = "Course 1", Description = "Description 1" },
            new Course { Id = 2, Name = "Course 2", Description = "Description 2" },
            new Course { Id = 3, Name = "Course 3", Description = "Description 3" },
            new Course { Id = 4, Name = "Course 4", Description = "Description 4" },
            new Course { Id = 5, Name = "Course 5", Description = "Description 5" },
            new Course { Id = 6, Name = "Course 6", Description = "Description 6" },
            new Course { Id = 7, Name = "Course 7", Description = "Description 7" },
        };
    }

    [HttpGet("{id}")]
    public Course Get(int id)
    {
        _logger.LogInformation($"Getting course with id {id}");
        return new Course { Id = id, Name = $"Course {id}", Description = $"Description {id}" };
    }
}


