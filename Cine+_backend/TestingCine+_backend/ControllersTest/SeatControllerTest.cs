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
    public class SeatControllerTest
    {
        private readonly Mock<ISeatRepository> _mockRepo;
        private readonly SeatController _controller;

        public SeatControllerTest()
        {
            _mockRepo = new Mock<ISeatRepository>();
            _controller = new SeatController(_mockRepo.Object);
        }

        private Seat SeedSeat(string guid_seed = "")
        {
            Seat seedSeat = new Seat
            {
                Code = "SeatTest",
            };
            if (guid_seed != "")
            {
                seedSeat.Id = new Guid(guid_seed);
            }
            return seedSeat;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetSeats();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllSeats()
        {
            _mockRepo.Setup(repo => repo.GetSeats())
                .Returns(new List<Seat>() { new Seat(), new Seat(), new Seat() });
            // Act
            var okResult = _controller.GetSeats() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Seat>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seedSeat = this.SeedSeat("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetSeat(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seedSeat);
            var okResult = _controller.GetSeat(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<Seat>(result.Value);
            Assert.Equal(seedSeat, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetSeat(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetSeat(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidSeatPassed_ReturnsCreatedResponse()
        {
            // Arrange
            Seat Seat = this.SeedSeat();
            _mockRepo.Setup(repo => repo.AddSeat(Seat))
                .Returns(new Seat { Id = Guid.NewGuid(), Code = Seat.Code });
            // Act
            var createdResponse = _controller.AddSeat(Seat);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }
        [Fact]
        public void Add_ValidSeatPassed_ReturnsCreatedSeat()
        {
            // Arrange
            Seat Seat = this.SeedSeat();
            _mockRepo.Setup(repo => repo.AddSeat(Seat))
                .Returns(new Seat { Id = Guid.NewGuid(), Code = Seat.Code });
            // Act
            var createdResponse = _controller.AddSeat(Seat) as OkObjectResult;
            var item = createdResponse.Value as Seat;
            // Assert
            Assert.IsType<Seat>(item);
            Assert.Equal(Seat.Code, item.Code);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.RemoveSeat(new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemoveSeat(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.RemoveSeat(new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
