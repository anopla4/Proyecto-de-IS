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

        private Level SeedLevel(string guid_seed="")
        {
            Level seedLevel = new Level
            {
                Name = "Piso",
                PercentOfPriceIncrement = 5
            };
            if(guid_seed != "")
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
                .Returns(new List<Level>() { new Level(), new Level() , new Level()});
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
            // Act
            var createdResponse = _controller.AddLevel(level);
            // Assert
            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }

        [Fact]
        public void Add_ValidLevelPassed_ReturnedResponseHasCreatedItem()
        {
            // Arrange
            Level level = this.SeedLevel();
            // Act
            var createdResponse = _controller.AddLevel(level) as CreatedAtActionResult;
            var item = createdResponse.Value as Level;
            // Assert
            Assert.IsType<Level>(item);
            Assert.Equal(level.Name, item.Name);
        }


    }
}
