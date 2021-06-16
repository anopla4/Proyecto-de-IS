using Cine__backend.Controllers;
using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using Cine__backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestingCine__backend.ControllersTest
{
    public class FilmScreeningControllerTest
    {
        private readonly Mock<IFilmScreeningRepository> _mockRepo;
        private readonly FilmScreeningController _controller;

        public FilmScreeningControllerTest()
        {
            _mockRepo = new Mock<IFilmScreeningRepository>();
            _controller = new FilmScreeningController(_mockRepo.Object);
        }

        private FilmScreening SeedFilmScreening(string guid_seed = "")
        {
            FilmScreening seedFilmScreening = new FilmScreening
            {
                RoomId = new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                FilmId = new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f37"),
                Date = DateTime.Today,
                Time = "10:00 PM",
                Price = 20.00,
                Points = 10
            };
            if (guid_seed != "")
            {
                seedFilmScreening.Id = new Guid(guid_seed);
            }
            return seedFilmScreening;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetFilmScreenings();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllBookEntries()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetFilmScreenings())
                .Returns(new List<DTOFilmScreening>() { new DTOFilmScreening(), new DTOFilmScreening(), new DTOFilmScreening() });
            // Act
            var okResult = _controller.GetFilmScreenings() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<DTOFilmScreening>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetSeats_ValidFilmDateAndTimePasses_ReturnsOkResultAndCorrectObject()
        {
            // Arrange
            var seedFilmScreening = this.SeedFilmScreening("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetSeats(seedFilmScreening.FilmId, seedFilmScreening.Date, seedFilmScreening.Time)).Returns(new List<DTOSeat> { new DTOSeat(), new DTOSeat(), new DTOSeat() });
            // Act
            var okResult = _controller.GetSeats(seedFilmScreening.FilmId, seedFilmScreening.Date, seedFilmScreening.Time);
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<List<DTOSeat>>(result.Value);
            // Assert
            Assert.Equal(3,item.Count());
        }

        [Fact]
        public void GetSeats_NotValidFilmIdPasses_ReturnsNotFoundResult()
        {
            // Arrange
            var seedFilmScreening = this.SeedFilmScreening("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetSeats(It.IsAny<Guid>(), It.IsAny<DateTime>(), It.IsAny<string>())).Throws(new KeyNotFoundException());
            // Act
            var Result = _controller.GetSeats(seedFilmScreening.FilmId, seedFilmScreening.Date, seedFilmScreening.Time);
            // Assert
            Assert.IsType<NotFoundObjectResult>(Result);
        }

        [Fact]
        public void GetSeats_NotValidDateOrTimePasses_ReturnsBadRequestResult()
        {
            // Arrange
            var seedFilmScreening = this.SeedFilmScreening("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetSeats(It.IsAny<Guid>(), It.IsAny<DateTime>(), It.IsAny<string>())).Throws(new Exception());
            // Act
            var Result = _controller.GetSeats(seedFilmScreening.FilmId, seedFilmScreening.Date, seedFilmScreening.Time);
            // Assert
            Assert.IsType<BadRequestObjectResult>(Result);
        }
        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            // Arrange
            var seedFilmScreening = this.SeedFilmScreening("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetFilmScreening(new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(new DTOFilmScreening { FilmScreeningId = seedFilmScreening.Id, Date = seedFilmScreening.Date, priceModifications = new List<DTOPriceModification>(), Room = new Room { Id = seedFilmScreening.RoomId, Name = "sala 1" }, StartTime = seedFilmScreening.Time, Film = new DTOFilm {Film = new Film { Id = seedFilmScreening.FilmId}, Genres = new List<Genre>() } });
            // Act
            var okResult = _controller.GetFilmScreening(new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<DTOFilmScreening>(result.Value);
            // Assert
            Assert.Equal(seedFilmScreening.Id, item.FilmScreeningId);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            // Arrange
            var seedFilmScreening = this.SeedFilmScreening("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetFilmScreening(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetFilmScreening(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidFilmScreeningPassed_ReturnsOkResponse()
        {
           // Arrange
           FilmScreening filmScreening = this.SeedFilmScreening();
            _mockRepo.Setup(repo => repo.AddFilmScreening(filmScreening, It.IsAny<List<DTOPriceModificationId>>()))
                .Returns(new FilmScreening { Id = Guid.NewGuid() });
           // Act
           var createdResponse = _controller.AddFilmScreening(filmScreening.FilmId, filmScreening.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = filmScreening.RoomId, Name = "sala 1" }, Time = filmScreening.Time } }, new List<DTOPriceModificationId>());
           // Assert
           Assert.IsType<OkResult>(createdResponse);
        }

        [Fact]
        public void Add_FilmOrRoomOrPriceModificationsNotFounds_ReturnsNotFoundResult()
        {
            // Arrange
            FilmScreening filmScreening = this.SeedFilmScreening();
            _mockRepo.Setup(repo => repo.AddFilmScreening(It.IsAny<FilmScreening>(), It.IsAny<List<DTOPriceModificationId>>()))
                .Throws(new KeyNotFoundException());
            // Act
            var createdResponse = _controller.AddFilmScreening(filmScreening.FilmId, filmScreening.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = filmScreening.RoomId, Name = "sala 1" }, Time = filmScreening.Time } }, new List<DTOPriceModificationId>());
            // Assert
            Assert.IsType<NotFoundObjectResult>(createdResponse);
        }

        [Fact]
        public void Add_FormatErrorOrOtherErrorCreatingFilmScreenings_ReturnsBadRequestResult()
        {
            // Arrange
            FilmScreening filmScreening = this.SeedFilmScreening();
            _mockRepo.Setup(repo => repo.AddFilmScreening(It.IsAny<FilmScreening>(), It.IsAny<List<DTOPriceModificationId>>()))
                .Throws(new Exception());
            // Act
            var createdResponse = _controller.AddFilmScreening(filmScreening.FilmId, filmScreening.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = filmScreening.RoomId, Name = "sala 1" }, Time = filmScreening.Time } }, new List<DTOPriceModificationId>());
            // Assert
            Assert.IsType<BadRequestObjectResult>(createdResponse);
        }

        [Fact]
        public void RemoveFilmScreening_ValidFilmScreeningId_ReturnedOkResponse()
        {
            // Arrange
            FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            // Act
            var createdResponse = _controller.RemoveFilmScreening(FilmScreening.Id);
            // Assert
            Assert.IsType<OkResult>(createdResponse);
        }

        [Fact]
        public void RemoveFilmScreening_NotValidFilmScreeningId_ReturnedNotFoundResponse()
        {
            // Arrange
            FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.RemoveFilmScreening(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var createdResponse = _controller.RemoveFilmScreening(FilmScreening.Id);
            // Assert
            Assert.IsType<NotFoundObjectResult>(createdResponse);
        }
        
        [Fact]
        public void Update_ValidFilmScreeningPassed_ReturnsOkResponse()
        {
            // Arrange
            FilmScreening filmScreening = this.SeedFilmScreening("43aaaa9c-27bd-4e17-b2ec-7603644b8f27");
            // Act
            var createdResponse = _controller.UpdateFilmScreening(filmScreening.FilmId, filmScreening.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = filmScreening.RoomId, Name = "sala 1" }, Time = filmScreening.Time } }, new List<DTOPriceModificationId>());
            // Assert
            Assert.IsType<OkResult>(createdResponse);
        }

        [Fact]
        public void Update_NotValidFilmIdPassed_ReturnsNotFound()
        {
            // Arrange
            FilmScreening filmScreening = this.SeedFilmScreening("43aaaa9c-27bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.RemoveFilmScreenings(It.IsAny<Guid>(), It.IsAny<DateTime>()))
                .Throws(new KeyNotFoundException());
            // Act
            var createdResponse = _controller.UpdateFilmScreening(filmScreening.FilmId, filmScreening.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = filmScreening.RoomId, Name = "sala 1" }, Time = filmScreening.Time } }, new List<DTOPriceModificationId>());
            // Assert
            Assert.IsType<NotFoundObjectResult>(createdResponse);
        }

        [Fact]
        public void Update_NotValidDatePassed_ReturnsBadRequest()
        {
            // Arrange
            FilmScreening filmScreening = this.SeedFilmScreening("43aaaa9c-27bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.RemoveFilmScreenings(It.IsAny<Guid>(), It.IsAny<DateTime>()))
                .Throws(new Exception());
            // Act
            var createdResponse = _controller.UpdateFilmScreening(filmScreening.FilmId, filmScreening.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = filmScreening.RoomId, Name = "sala 1" }, Time = filmScreening.Time } }, new List<DTOPriceModificationId>());
            // Assert
            Assert.IsType<BadRequestObjectResult>(createdResponse);
        }

        [Fact]
        public void Update_NotValidRoomIdOrPriceModificationIdPassed_ReturnsNotFound()
        {
            // Arrange
            FilmScreening filmScreening = this.SeedFilmScreening("43aaaa9c-27bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.AddFilmScreening(It.IsAny<FilmScreening>(), It.IsAny<List<DTOPriceModificationId>>()))
                .Throws(new KeyNotFoundException());
            // Act
            var createdResponse = _controller.UpdateFilmScreening(filmScreening.FilmId, filmScreening.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = filmScreening.RoomId, Name = "sala 1" }, Time = filmScreening.Time } }, new List<DTOPriceModificationId>());
            // Assert
            Assert.IsType<NotFoundObjectResult>(createdResponse);
        }

        [Fact]
        public void Update_ErrorAddingFilmScreening_ReturnsBadRequest()
        {
            // Arrange
            FilmScreening filmScreening = this.SeedFilmScreening("43aaaa9c-27bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.AddFilmScreening(It.IsAny<FilmScreening>(), It.IsAny<List<DTOPriceModificationId>>()))
                .Throws(new Exception());
            // Act
            var createdResponse = _controller.UpdateFilmScreening(filmScreening.FilmId, filmScreening.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = filmScreening.RoomId, Name = "sala 1" }, Time = filmScreening.Time } }, new List<DTOPriceModificationId>());
            // Assert
            Assert.IsType<BadRequestObjectResult>(createdResponse);
        }
    }
}
