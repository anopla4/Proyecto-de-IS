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
        //[Fact]
        //public void Add_ValidFilmScreeningPassed_ReturnsCreatedFilmScreening()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening();
        //    _mockRepo.Setup(repo => repo.AddFilmScreening(FilmScreening))
        //        .Returns(new FilmScreening { Id = Guid.NewGuid(), UserId = FilmScreening.UserId, PurchaseTime = FilmScreening.PurchaseTime, Date = FilmScreening.Date, PaidByPoints = FilmScreening.PaidByPoints, Items = FilmScreening.Items });
        //    // Act
        //    var createdResponse = _controller.AddFilmScreening(FilmScreening) as OkObjectResult;
        //    var item = createdResponse.Value as FilmScreening;
        //    // Assert
        //    Assert.IsType<FilmScreening>(item);
        //    Assert.Equal(FilmScreening.UserId, item.UserId);
        //    Assert.Equal(FilmScreening.PaidByPoints, item.PaidByPoints);
        //    Assert.Equal(FilmScreening.Date, item.Date);
        //    Assert.Equal(FilmScreening.PurchaseTime, item.PurchaseTime);
        //    Assert.Equal(FilmScreening.Items, item.Items);
        //}

        //[Fact]
        //public void PayFilmScreening_ValidFilmScreeningIdAndCreditCard_ReturnedOkResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    string creditCard = "2344 0234 4546 0000";
        //    // Act
        //    var createdResponse = _controller.PayFilmScreening(FilmScreening.Id, creditCard);
        //    // Assert
        //    Assert.IsType<OkResult>(createdResponse);
        //}

        //[Fact]
        //public void PayFilmScreening_NotValidFilmScreeningId_ReturnedNotFoundResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    string creditCard = "2344 0234 4546 0000";
        //    _mockRepo.Setup(repo => repo.PayFilmScreening(It.IsAny<Guid>(), It.IsAny<string>())).Throws(new KeyNotFoundException());
        //    // Act
        //    var createdResponse = _controller.PayFilmScreening(FilmScreening.Id, creditCard);
        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void PayFilmScreening_NotValidCreditCard_ReturnedBadRequestResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    string creditCard = "2344 0234 4546 0000";
        //    _mockRepo.Setup(repo => repo.PayFilmScreening(It.IsAny<Guid>(), It.IsAny<string>())).Throws(new Exception());
        //    // Act
        //    var createdResponse = _controller.PayFilmScreening(FilmScreening.Id, creditCard);
        //    // Assert
        //    Assert.IsType<BadRequestObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void RemoveItems_ValidFilmScreeningIdAndItemsIds_ReturnedOkResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    List<Guid> items = new List<Guid>();
        //    // Act
        //    var createdResponse = _controller.RemoveItems(FilmScreening.Id, items);
        //    // Assert
        //    Assert.IsType<OkResult>(createdResponse);
        //}

        //[Fact]
        //public void RemoveItems_NotValidFilmScreeningIdOrSomeNotValidItemId_ReturnedNotFoundResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    List<Guid> items = new List<Guid>();
        //    _mockRepo.Setup(repo => repo.RemoveItems(It.IsAny<Guid>(), It.IsAny<List<Guid>>())).Throws(new KeyNotFoundException());
        //    // Act
        //    var createdResponse = _controller.RemoveItems(FilmScreening.Id, items);
        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void RemoveItems_IfErrorRemoving_ReturnedBadRequestResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    List<Guid> items = new List<Guid>();
        //    _mockRepo.Setup(repo => repo.RemoveItems(It.IsAny<Guid>(), It.IsAny<List<Guid>>())).Throws(new Exception());
        //    // Act
        //    var createdResponse = _controller.RemoveItems(FilmScreening.Id, items);
        //    // Assert
        //    Assert.IsType<BadRequestObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void CheckPendingFilmScreening_ValidFilmScreeningId_ReturnedOkResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    // Act
        //    var createdResponse = _controller.CheckPendingFilmScreening(FilmScreening.Id);
        //    // Assert
        //    Assert.IsType<OkResult>(createdResponse);
        //}

        //[Fact]
        //public void CheckPendingFilmScreening_NotValidFilmScreeningId_ReturnedNotFoundResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.CheckPendingToCancel(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
        //    // Act
        //    var createdResponse = _controller.CheckPendingFilmScreening(FilmScreening.Id);
        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void CheckPendingFilmScreening_IfError_ReturnedBadRequestResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.CheckPendingToCancel(It.IsAny<Guid>())).Throws(new Exception());
        //    // Act
        //    var createdResponse = _controller.CheckPendingFilmScreening(FilmScreening.Id);
        //    // Assert
        //    Assert.IsType<BadRequestObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void CancelFilmScreening_ValidFilmScreeningId_ReturnedOkResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    // Act
        //    var createdResponse = _controller.CancelFilmScreening(FilmScreening.Id);
        //    // Assert
        //    Assert.IsType<OkResult>(createdResponse);
        //}

        //[Fact]
        //public void CancelFilmScreening_NotValidFilmScreeningId_ReturnedNotFoundResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.CancelFilmScreening(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
        //    // Act
        //    var createdResponse = _controller.CancelFilmScreening(FilmScreening.Id);
        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void CancelFilmScreening_IfError_ReturnedBadRequestResponse()
        //{
        //    // Arrange
        //    FilmScreening FilmScreening = this.SeedFilmScreening("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.CancelFilmScreening(It.IsAny<Guid>())).Throws(new Exception());
        //    // Act
        //    var createdResponse = _controller.CancelFilmScreening(FilmScreening.Id);
        //    // Assert
        //    Assert.IsType<BadRequestObjectResult>(createdResponse);
        //}
    }
}
