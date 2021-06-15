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
    public class RoomControllerTest
    {
        private readonly Mock<IRoomRepository> _mockRepo;
        private readonly RoomController _controller;

        public RoomControllerTest()
        {
            _mockRepo = new Mock<IRoomRepository>();
            _controller = new RoomController(_mockRepo.Object);
        }

        private Room SeedRoom(string guid_seed = "")
        {
            Room seedRoom = new Room
            {
                Name = "Sala 1",
            };
            if (guid_seed != "")
            {
                seedRoom.Id = new Guid(guid_seed);
            }
            return seedRoom;
        }
        private Room SeedRoomToUpdate(string guid_seed = "")
        {
            Room seedRoom = new Room
            {
                Name = "Sala 2",
            };
            if (guid_seed != "")
            {
                seedRoom.Id = new Guid(guid_seed);
            }
            return seedRoom;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetRooms();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllLevels()
        {
            _mockRepo.Setup(repo => repo.GetRooms())
                .Returns(new List<Room>() { new Room(), new Room(), new Room() });
            // Act
            var okResult = _controller.GetRooms() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Room>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seedRoom = this.SeedRoom("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetRoom(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seedRoom);
            var okResult = _controller.GetRoom(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<Room>(result.Value);
            Assert.Equal(seedRoom, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetRoom(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetRoom(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidRoomPassed_ReturnsCreatedResponse()
        {
            // Arrange
            Room room = this.SeedRoom();
            _mockRepo.Setup(repo => repo.AddRoom(room))
                .Returns(new Room { Id = Guid.NewGuid(), Name = room.Name });
            // Act
            var createdResponse = _controller.AddRoom(room);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }
        [Fact]
        public void Add_ValidRoomPassed_ReturnsCreatedRoom()
        {
            // Arrange
            Room room = this.SeedRoom();
            _mockRepo.Setup(repo => repo.AddRoom(room))
                .Returns(new Room { Id = Guid.NewGuid(), Name = room.Name });
            // Act
            var createdResponse = _controller.AddRoom(room) as OkObjectResult;
            var item = createdResponse.Value as Room;
            // Assert
            Assert.IsType<Room>(item);
            Assert.Equal(room.Name, item.Name);
        }

        [Fact]
        public void Update_ValidRoomPassed_ReturnedOkResponse()
        {
            // Arrange
            Room seedRoom = this.SeedRoom("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.UpdateRoom(seedRoom))
                .Returns(new Room { Id = seedRoom.Id, Name = "Sala 2" });
            _mockRepo.Setup(repo => repo.GetRoom(seedRoom.Id))
                .Returns(new Room { Id = seedRoom.Id, Name = seedRoom.Name });
            // Act
            var createdResponse = _controller.RoomUpdate(seedRoom.Id, seedRoom);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }

        [Fact]
        public void Update_ValidRoomPassed_ReturnedObjectUpdated()
        {
            // Arrange
            Room seedRoom = this.SeedRoom("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.UpdateRoom(seedRoom))
                .Returns(new Room { Id = seedRoom.Id, Name = "Sala 2"});
            _mockRepo.Setup(repo => repo.GetRoom(seedRoom.Id))
                .Returns(new Room { Id = seedRoom.Id, Name = seedRoom.Name });
            // Act
            var createdResponse = _controller.RoomUpdate(seedRoom.Id,seedRoom) as OkObjectResult;
            var item = createdResponse.Value as Room;
            // Assert
            Assert.IsType<Room>(item);
            Assert.Equal(seedRoom.Id, item.Id);
            Assert.Equal("Sala 2", item.Name);
        }


    }
}
