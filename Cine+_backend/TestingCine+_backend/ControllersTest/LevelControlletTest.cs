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
    public class LevelControlletTest
    {
        private readonly Mock<ILevelRepository> _mockRepo;
        private readonly LevelController _controller;

        public LevelControlletTest()
        {
            _mockRepo = new Mock<ILevelRepository>();
            _controller = new LevelController(_mockRepo.Object);
        }

        private Level SeedLevel(string guid_seed = "")
        {
            Level seedLevel = new Level
            {
                Name = "Piso",
                PercentOfPriceIncrement = 5
            };
            if (guid_seed != "")
            {
                seedLevel.Id = new Guid(guid_seed);
            }
            return seedLevel;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetLevels();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllLevels()
        {
            _mockRepo.Setup(repo => repo.GetLevels())
                .Returns(new List<Level>() { new Level(), new Level(), new Level() });
            // Act
            var okResult = _controller.GetLevels() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Level>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seedLevel = this.SeedLevel("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetLevel(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seedLevel);
            var okResult = _controller.GetLevel(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<Level>(result.Value);
            Assert.Equal(seedLevel, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetLevel(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetLevel(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidLevelPassed_ReturnsCreatedResponse()
        {
            // Arrange
            Level level = this.SeedLevel();
            _mockRepo.Setup(repo => repo.AddLevel(level))
                .Returns(new Level { Id = new Guid(), Name = level.Name, PercentOfPriceIncrement = level.PercentOfPriceIncrement });
            // Act
            var okResponse = _controller.AddLevel(level);
            // Assert
            Assert.IsType<OkObjectResult>(okResponse);
        }

        [Fact]
        public void Add_ValidLevelPassed_ReturnedResponseHasCreatedItem()
        {
            // Arrange
            Level level = this.SeedLevel();
            _mockRepo.Setup(repo => repo.AddLevel(level))
                .Returns(new Level { Id = Guid.NewGuid(), Name = level.Name, PercentOfPriceIncrement = level.PercentOfPriceIncrement });
            // Act
            var okResponse = _controller.AddLevel(level) as OkObjectResult;
            var item = okResponse.Value as Level;
            // Assert
            Assert.IsType<Level>(item);
            Assert.Equal(level.Name, item.Name);
        }

        [Fact]
        public void Add_ValidLevelPassed_ReturnedResponseCalledAddOnceTime()
        {
            // Arrange
            Level lev = null;
            _mockRepo.Setup(repo => repo.AddLevel(It.IsAny<Level>()))
                .Callback<Level>(x => lev = x);
            Level seed = this.SeedLevel();
            // Act
            _controller.AddLevel(seed);
            _mockRepo.Verify(x => x.AddLevel(It.IsAny<Level>()), Times.Once);
            // Assert
            Assert.Equal(lev.Name, seed.Name);
            Assert.Equal(lev.PercentOfPriceIncrement, seed.PercentOfPriceIncrement);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.DeleteLevel(new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.DeleteLevel(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.DeleteLevel(new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Update_Valid_ReturnOkObjectResult()
        {
            var seedLevel = this.SeedLevel("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetLevel(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27")))
                .Returns(seedLevel);
            _mockRepo.Setup(p => p.UpdateLevel(seedLevel)).Returns(seedLevel);
            var okResult = _controller.LevelUpdate(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                this.SeedLevel());
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<Level>(result.Value);
            Assert.Equal(seedLevel.Id, item.Id);
        }

        [Fact]
        public void Update_Invalid_ReturnNotFoundResult()
        {
            _mockRepo.Setup(p => p.UpdateLevel(It.IsAny<Level>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.LevelUpdate(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"),
                new Level());
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

    }
}
