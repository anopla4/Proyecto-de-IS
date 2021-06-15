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
    
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetLevels();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllLevels()
        {
            _mockRepo.Setup(repo => repo.GetLevels())
                .Returns(new List<Level>() { new Level(), new Level() , new Level()});
            // Act
            var okResult = _controller.GetLevels() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Level>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
