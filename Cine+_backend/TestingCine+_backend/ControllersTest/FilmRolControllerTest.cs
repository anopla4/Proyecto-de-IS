using Cine__backend.Controllers;
using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestingCine__backend.ControllersTest
{
    public class FilmRolControllerTest
    {
        private readonly Mock<IFilmRolRepository> _mockRepo;
        private readonly FilmRolController _controller;

        public FilmRolControllerTest()
        {
            _mockRepo = new Mock<IFilmRolRepository>();
            _controller = new FilmRolController(_mockRepo.Object);
        }

        private FilmRol SeedFilmRol(string guid_seed = "")
        {
            var seedFilmRol = new FilmRol
            {
                Name = "TestFilmRol",
            };
            if (guid_seed != "")
            {
                seedFilmRol.Id = new Guid(guid_seed);
            }
            return seedFilmRol;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetFilmRols();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllRoles()
        {
            _mockRepo.Setup(repo => repo.GetRoles())
                .Returns(new List<FilmRol>() { new FilmRol(), new FilmRol(), new FilmRol() });
            // Act
            var okResult = _controller.GetFilmRols() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<FilmRol>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seed = this.SeedFilmRol("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetFilmRol(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seed);
            var okResult = _controller.GetFilmRol(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<FilmRol>(result.Value);
            Assert.Equal(seed, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetFilmRol(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetFilmRol(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnsCreatedResponse()
        {
            // Arrange
            var seed = this.SeedFilmRol();
            _mockRepo.Setup(repo => repo.AddFilmRol(seed))
                .Returns(new FilmRol { Id = new Guid(), Name = seed.Name });
            // Act
            var okResponse = _controller.AddFilmRol(seed);
            // Assert
            Assert.IsType<OkObjectResult>(okResponse);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseHasCreatedItem()
        {
            // Arrange
            var seed = this.SeedFilmRol();
            _mockRepo.Setup(repo => repo.AddFilmRol(seed))
                .Returns(new FilmRol { Id = Guid.NewGuid(), Name = seed.Name });
            // Act
            var okResponse = _controller.AddFilmRol(seed) as OkObjectResult;
            var item = okResponse.Value as FilmRol;
            // Assert
            Assert.IsType<FilmRol>(item);
            Assert.Equal(seed.Name, item.Name);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseCalledAddOnceTime()
        {
            // Arrange
            FilmRol fr = null;
            _mockRepo.Setup(repo => repo.AddFilmRol(It.IsAny<FilmRol>()))
                .Callback<FilmRol>(x => fr = x);
            var seed = this.SeedFilmRol();
            // Act
            _controller.AddFilmRol(seed);
            _mockRepo.Verify(x => x.AddFilmRol(It.IsAny<FilmRol>()), Times.Once);
            // Assert
            Assert.Equal(fr.Name, seed.Name);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.RemoveFilmRol(new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemoveFilmRol(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.RemoveFilmRol(new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Update_Valid_ReturnOkObjectResult()
        {
            var seed = this.SeedFilmRol("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.UpdateFilmRol(seed)).Returns(seed);
            var okResult = _controller.UpdateFilmRol(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                seed);
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<FilmRol>(result.Value);
            Assert.Equal(seed.Id, item.Id);
        }

        [Fact]
        public void Update_Invalid_ReturnNotFoundResult()
        {
            _mockRepo.Setup(p => p.UpdateFilmRol(It.IsAny<FilmRol>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.UpdateFilmRol(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"),
                new FilmRol());
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
