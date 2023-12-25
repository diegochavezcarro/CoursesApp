using CoursesApp.Api.Controllers;
using CoursesApp.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace CoursesApp.UnitTests.Controllers;

public class TestCoursesController
{
    //get method should return a list of 7 courses
    [Fact]
    public void TestGet()
    {
        // Arrange
        var logger = new Mock<ILogger<CoursesController>>();
        var controller = new CoursesController(logger.Object);

        // Act
        var result = controller.Get();

        // Assert
        Assert.NotNull(result);
        Assert.IsAssignableFrom<IEnumerable<Course>>(result);
        Assert.Equal(7, ((IEnumerable<Course>)result).Count());
    }

    //get method should return a course with id 1
    [Fact]
    public void TestGetById()
    {
        // Arrange
        var logger = new Mock<ILogger<CoursesController>>();
        var controller = new CoursesController(logger.Object);

        // Act
        var result = controller.Get(1);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.Id);
        Assert.Equal("Course 1", result.Name);
        Assert.Equal("Description 1", result.Description);
    }

 
 
}
