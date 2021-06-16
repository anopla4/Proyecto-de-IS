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
    public class UserFilmControllerTest
    {
        private readonly Mock<IUserFilmRepository> _mockRepo;
        private readonly UserFilmController _controller;

        public UserFilmControllerTest()
        {
            _mockRepo = new Mock<IUserFilmRepository>();
            _controller = new UserFilmController(_mockRepo.Object);
        }

        private UserFilm SeedUserFilm()
        {
            UserFilm seedUserFilm = new UserFilm
            {
                FilmId = new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f37"),
                UserId = "43aaaa9c-17bd-4e17-b2ec-7603644b8a37",
                Rating = 4,
            };
            return seedUserFilm;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetUserFilms();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllUserFilms()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetUserFilms())
                .Returns(new List<UserFilm>() { new UserFilm(), new UserFilm(), new UserFilm() });
            // Act
            var okResult = _controller.GetUserFilms() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<UserFilm>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        //[Fact]
        //public void GetRatingOfUser_ValidUserIdPasses_ReturnsOkResultAndCorrectObject()
        //{
        //    // Arrange
        //    var userId = "43aaba9c-17bd-4e17-b2ec-7603644b8f27";
        //    _mockRepo.Setup(p => p.GetRatingsOfUser(seedUserFilm.FilmId, seedUserFilm.Date, seedUserFilm.Time)).Returns(new List<DTOSeat> { new DTOSeat(), new DTOSeat(), new DTOSeat() });
        //    // Act
        //    var okResult = _controller.GetSeats(seedUserFilm.FilmId, seedUserFilm.Date, seedUserFilm.Time);
        //    var result = Assert.IsType<OkObjectResult>(okResult);
        //    var item = Assert.IsType<List<DTOSeat>>(result.Value);
        //    // Assert
        //    Assert.Equal(3, item.Count());
        //}

        //[Fact]
        //public void GetSeats_NotValidFilmIdPasses_ReturnsNotFoundResult()
        //{
        //    // Arrange
        //    var seedUserFilm = this.SeedUserFilm("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(p => p.GetSeats(It.IsAny<Guid>(), It.IsAny<DateTime>(), It.IsAny<string>())).Throws(new KeyNotFoundException());
        //    // Act
        //    var Result = _controller.GetSeats(seedUserFilm.FilmId, seedUserFilm.Date, seedUserFilm.Time);
        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(Result);
        //}

        //[Fact]
        //public void GetSeats_NotValidDateOrTimePasses_ReturnsBadRequestResult()
        //{
        //    // Arrange
        //    var seedUserFilm = this.SeedUserFilm("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(p => p.GetSeats(It.IsAny<Guid>(), It.IsAny<DateTime>(), It.IsAny<string>())).Throws(new Exception());
        //    // Act
        //    var Result = _controller.GetSeats(seedUserFilm.FilmId, seedUserFilm.Date, seedUserFilm.Time);
        //    // Assert
        //    Assert.IsType<BadRequestObjectResult>(Result);
        //}
        //[Fact]
        //public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        //{
        //    // Arrange
        //    var seedUserFilm = this.SeedUserFilm("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(p => p.GetUserFilm(new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(new DTOUserFilm { UserFilmId = seedUserFilm.Id, Date = seedUserFilm.Date, priceModifications = new List<DTOPriceModification>(), Room = new Room { Id = seedUserFilm.RoomId, Name = "sala 1" }, StartTime = seedUserFilm.Time, Film = new DTOFilm { Film = new Film { Id = seedUserFilm.FilmId }, Genres = new List<Genre>() } });
        //    // Act
        //    var okResult = _controller.GetUserFilm(new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27"));
        //    var result = Assert.IsType<OkObjectResult>(okResult);
        //    var item = Assert.IsType<DTOUserFilm>(result.Value);
        //    // Assert
        //    Assert.Equal(seedUserFilm.Id, item.UserFilmId);
        //}

        //[Fact]
        //public void GetById_WhenCalled_ReturnsNotFoundsResult()
        //{
        //    // Arrange
        //    var seedUserFilm = this.SeedUserFilm("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(p => p.GetUserFilm(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
        //    var notFoundResult = _controller.GetUserFilm(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
        //    Assert.IsType<NotFoundObjectResult>(notFoundResult);
        //}

        //[Fact]
        //public void Add_ValidUserFilmPassed_ReturnsOkResponse()
        //{
        //    // Arrange
        //    UserFilm UserFilm = this.SeedUserFilm();
        //    _mockRepo.Setup(repo => repo.AddUserFilm(UserFilm, It.IsAny<List<DTOPriceModificationId>>()))
        //        .Returns(new UserFilm { Id = Guid.NewGuid() });
        //    // Act
        //    var createdResponse = _controller.AddUserFilm(UserFilm.FilmId, UserFilm.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = UserFilm.RoomId, Name = "sala 1" }, Time = UserFilm.Time } }, new List<DTOPriceModificationId>());
        //    // Assert
        //    Assert.IsType<OkResult>(createdResponse);
        //}

        //[Fact]
        //public void Add_FilmOrRoomOrPriceModificationsNotFounds_ReturnsNotFoundResult()
        //{
        //    // Arrange
        //    UserFilm UserFilm = this.SeedUserFilm();
        //    _mockRepo.Setup(repo => repo.AddUserFilm(It.IsAny<UserFilm>(), It.IsAny<List<DTOPriceModificationId>>()))
        //        .Throws(new KeyNotFoundException());
        //    // Act
        //    var createdResponse = _controller.AddUserFilm(UserFilm.FilmId, UserFilm.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = UserFilm.RoomId, Name = "sala 1" }, Time = UserFilm.Time } }, new List<DTOPriceModificationId>());
        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void Add_FormatErrorOrOtherErrorCreatingUserFilms_ReturnsBadRequestResult()
        //{
        //    // Arrange
        //    UserFilm UserFilm = this.SeedUserFilm();
        //    _mockRepo.Setup(repo => repo.AddUserFilm(It.IsAny<UserFilm>(), It.IsAny<List<DTOPriceModificationId>>()))
        //        .Throws(new Exception());
        //    // Act
        //    var createdResponse = _controller.AddUserFilm(UserFilm.FilmId, UserFilm.Date, new List<DTORoomTime> { new DTORoomTime { Room = new Room { Id = UserFilm.RoomId, Name = "sala 1" }, Time = UserFilm.Time } }, new List<DTOPriceModificationId>());
        //    // Assert
        //    Assert.IsType<BadRequestObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void RemoveUserFilm_ValidUserFilmId_ReturnedOkResponse()
        //{
        //    // Arrange
        //    UserFilm UserFilm = this.SeedUserFilm("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    // Act
        //    var createdResponse = _controller.RemoveUserFilm(UserFilm.Id);
        //    // Assert
        //    Assert.IsType<OkResult>(createdResponse);
        //}

        //[Fact]
        //public void RemoveUserFilm_NotValidUserFilmId_ReturnedNotFoundResponse()
        //{
        //    // Arrange
        //    UserFilm UserFilm = this.SeedUserFilm("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.RemoveUserFilm(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
        //    // Act
        //    var createdResponse = _controller.RemoveUserFilm(UserFilm.Id);
        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void Update_ValidUserFilmPassed_ReturnsOkResponse()
        //{
        //    // Arrange
        //    UserFilm UserFilm = this.SeedUserFilm("43aaaa9c-27bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.UpdateUserFilm(UserFilm, It.IsAny<List<DTOPriceModificationId>>()))
        //        .Returns(new UserFilm { Id = UserFilm.Id, Date = UserFilm.Date, FilmId = UserFilm.FilmId, Price = 30, Points = 50, RoomId = UserFilm.RoomId, Time = UserFilm.Time });
        //    // Act
        //    var createdResponse = _controller.UpdateUserFilm(UserFilm.Id, UserFilm, new List<DTOPriceModificationId>());
        //    // Assert
        //    Assert.IsType<OkObjectResult>(createdResponse);
        //}
        //[Fact]
        //public void Update_ValidUserFilmPassed_ReturnsCorrectObject()
        //{
        //    // Arrange
        //    UserFilm UserFilm = this.SeedUserFilm("43aaaa9c-27bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.UpdateUserFilm(UserFilm, It.IsAny<List<DTOPriceModificationId>>()))
        //        .Returns(new UserFilm { Id = UserFilm.Id, Date = UserFilm.Date, FilmId = UserFilm.FilmId, Price = 30, Points = 50, RoomId = UserFilm.RoomId, Time = UserFilm.Time });
        //    // Act
        //    var createdResponse = _controller.UpdateUserFilm(UserFilm.Id, UserFilm, new List<DTOPriceModificationId>()) as OkObjectResult;
        //    var item = createdResponse.Value as UserFilm;
        //    // Assert
        //    Assert.IsType<UserFilm>(item);
        //    Assert.Equal(UserFilm.Id, item.Id);
        //    Assert.Equal(30, item.Price);
        //    Assert.Equal(50, item.Points);
        //}
        //[Fact]
        //public void Update_NotValidUserFilmIdOrPriceModificationIdPassed_ReturnsNotFound()
        //{
        //    // Arrange
        //    UserFilm UserFilm = this.SeedUserFilm("43aaaa9c-27bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.UpdateUserFilm(It.IsAny<UserFilm>(), It.IsAny<List<DTOPriceModificationId>>()))
        //        .Throws(new KeyNotFoundException());
        //    // Act
        //    var createdResponse = _controller.UpdateUserFilm(UserFilm.Id, UserFilm, new List<DTOPriceModificationId>());
        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(createdResponse);
        //}

        //[Fact]
        //public void Update_FormatErrorOrAnotherErrorUpdatingUserFilm_ReturnsNotFound()
        //{
        //    // Arrange
        //    UserFilm UserFilm = this.SeedUserFilm("43aaaa9c-27bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.UpdateUserFilm(It.IsAny<UserFilm>(), It.IsAny<List<DTOPriceModificationId>>()))
        //        .Throws(new Exception());
        //    // Act
        //    var createdResponse = _controller.UpdateUserFilm(UserFilm.Id, UserFilm, new List<DTOPriceModificationId>());
        //    // Assert
        //    Assert.IsType<BadRequestObjectResult>(createdResponse);
        //}
    }
}
