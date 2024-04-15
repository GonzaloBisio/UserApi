using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NSubstitute;
using System.Threading.Tasks;
using UserApi.Context;
using UserApi.Controllers;
using UserApi.Models;
using Xunit;

namespace UserApi.Tests.Controller
{
    public class UserControllerTests
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UserController> _logger;

        public UserControllerTests()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Connection");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            _context = new AppDbContext(options);
            _logger = A.Fake<ILogger<UserController>>();
        }

        [Fact]
        public async Task UserController_PostUsuario_ReturnSuccessAsync()
        {
            // Arrange
            var user = A.Fake<User>();
            var controller = new UserController(_context, _logger);

            // Act
            var result = await controller.PostUsuario(user);

            // Assertions
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<ObjectResult>(); 
        }
    }
}
