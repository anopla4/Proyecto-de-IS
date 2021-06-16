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
    public class SeatSectionLevelRoomControllerTest
    {
        private readonly Mock<ISeatSectionLevelRoomRepository> _mockRepo;
        private readonly SeatSectionLevelRoomController _controller;

        public SeatSectionLevelRoomControllerTest()
        {
            _mockRepo = new Mock<ISeatSectionLevelRoomRepository>();
            _controller = new SeatSectionLevelRoomController(_mockRepo.Object);
        }

        private SeatSectionLevelRoom SeedSeatSectionLevelRoom(Guid seatId,Guid sectionId,Guid levelId,Guid roomId)
        {
            SeatSectionLevelRoom seedSeatSectionLevelRoom = new SeatSectionLevelRoom
            {
                SeatId = seatId,
                SectionId = sectionId,
                LevelId = levelId,
                RoomId = roomId
                
            };
            return seedSeatSectionLevelRoom;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetSeatSectionLevelRoom(new Guid(), new Guid(), new Guid(), new Guid());
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllSeatSectionLevelRooms()
        {
            _mockRepo.Setup(repo => repo.GetAllSeatSectionLevelRoom())
                .Returns(new List<SeatSectionLevelRoom>() { new SeatSectionLevelRoom(), new SeatSectionLevelRoom(), new SeatSectionLevelRoom() });
            // Act
            var okResult = _controller.GetAllSeatSectionLevelRooms() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<SeatSectionLevelRoom>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seed = this.SeedSeatSectionLevelRoom(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43dddd9c-17bd-4e17-b2ec-7603644b8f27"));
            _mockRepo.Setup(p => p.GetSeatSectionLevelRoom(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43dddd9c-17bd-4e17-b2ec-7603644b8f27"))).
                Returns(new SeatSectionLevelRoom {
                LevelId = seed.LevelId, SeatId = seed.SeatId, SectionId = seed.SectionId, 
                RoomId = seed.RoomId});
            var okResult = _controller.GetSeatSectionLevelRoom(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43dddd9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<SeatSectionLevelRoom>(result.Value);
            Assert.Equal(seed.LevelId, item.LevelId);
            Assert.Equal(seed.SeatId, item.SeatId);
            Assert.Equal(seed.SectionId, item.SectionId);
            Assert.Equal(seed.RoomId, item.RoomId);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetSeatSectionLevelRoom(It.IsAny<Guid>(), It.IsAny<Guid>(), It.IsAny<Guid>(), It.IsAny<Guid>()))
                .Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetSeatSectionLevelRoom(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43dddd9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidSeatSectionLevelRoomPassed_ReturnsOkResponse()
        {
            // Arrange
            SeatSectionLevelRoom seed = this.SeedSeatSectionLevelRoom(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43dddd9c-17bd-4e17-b2ec-7603644b8f27"));
            _mockRepo.Setup(repo => repo.AddSeatSectionLevelRoom(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43dddd9c-17bd-4e17-b2ec-7603644b8f27")));
            // Act
            var createdResponse = _controller.AddSeatSectionLevelRoom(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43dddd9c-17bd-4e17-b2ec-7603644b8f27"));
            // Assert
            Assert.IsType<OkResult>(createdResponse);
        }
        

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.RemoveSeatSectionLevelRoom(new Guid(), new Guid(),
                new Guid(), new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemoveSeatSectionLevelRoom(It.IsAny<Guid>(), It.IsAny<Guid>(), 
                It.IsAny<Guid>(), It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.RemoveSeatSectionLevelRoom(new Guid(), new Guid(),
                new Guid(), new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

    }
}
