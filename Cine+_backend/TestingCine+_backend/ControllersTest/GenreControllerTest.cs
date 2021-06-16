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
    public class GenreControllerTest
    {
        private readonly Mock<IGenreRepository> _mockRepo;
        private readonly GenreController _controller;

        public GenreControllerTest()
        {
            _mockRepo = new Mock<IGenreRepository>();
            _controller = new GenreController(_mockRepo.Object);
        }

        private Genre SeedGenre(string guid_seed = "")
        {
            var seedGenre = new Genre
            {
                Name = "TestGenre",
            };
            if (guid_seed != "")
            {
                seedGenre.Id = new Guid(guid_seed);
            }
            return seedGenre;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetGenres();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllRoles()
        {
            _mockRepo.Setup(repo => repo.GetGenres())
                .Returns(new List<Genre>() { new Genre(), new Genre(), new Genre() });
            // Act
            var okResult = _controller.GetGenres() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Genre>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seed = this.SeedGenre("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetGenre(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seed);
            var okResult = _controller.GetGenre(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<Genre>(result.Value);
            Assert.Equal(seed, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetGenre(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetGenre(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnsOkResponse()
        {
            // Arrange
            var seed = this.SeedGenre();
            _mockRepo.Setup(repo => repo.AddGenre(seed))
                .Returns(new Genre { Id = new Guid(), Name = seed.Name});
            // Act
            var okResponse = _controller.AddGenre(seed);
            // Assert
            Assert.IsType<OkObjectResult>(okResponse);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseHasCreatedItem()
        {
            // Arrange
            var seed = this.SeedGenre();
            _mockRepo.Setup(repo => repo.AddGenre(seed))
                .Returns(new Genre { Id = Guid.NewGuid(), Name = seed.Name});
            // Act
            var okResponse = _controller.AddGenre(seed) as OkObjectResult;
            var item = okResponse.Value as Genre;
            // Assert
            Assert.IsType<Genre>(item);
            Assert.Equal(seed.Name, item.Name);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseCalledAddOnceTime()
        {
            // Arrange
            Genre gen = null;
            _mockRepo.Setup(repo => repo.AddGenre(It.IsAny<Genre>()))
                .Callback<Genre>(x => gen = x);
            var seed = this.SeedGenre();
            // Act
            _controller.AddGenre(seed);
            _mockRepo.Verify(x => x.AddGenre(It.IsAny<Genre>()), Times.Once);
            // Assert
            Assert.Equal(gen.Name, seed.Name);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.RemoveGenre(new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemoveGenre(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.RemoveGenre(new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Update_Valid_ReturnOkObjectResult()
        {
            var seed = this.SeedGenre("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.UpdateGenre(seed)).Returns(seed);
            var okResult = _controller.UpdateGenre(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                seed);
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<Genre>(result.Value);
            Assert.Equal(seed.Id, item.Id);
        }

        [Fact]
        public void Update_Invalid_ReturnNotFoundResult()
        {
            _mockRepo.Setup(p => p.UpdateGenre(It.IsAny<Genre>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.UpdateGenre(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"),
                new Genre());
            Assert.IsType<BadRequestObjectResult>(notFoundResult);
        }
    }
}
