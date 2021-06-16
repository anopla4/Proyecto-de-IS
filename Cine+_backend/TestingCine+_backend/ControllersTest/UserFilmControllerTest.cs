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

        [Fact]
        public void GetFilmsStatics_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetFilmsStatics();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetFilmsStatics_WhenCalled_ReturnsAllUserFilms()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetFilmsStatics())
                .Returns(new List<DTOFilmStatics>() { new DTOFilmStatics(), new DTOFilmStatics(), new DTOFilmStatics() });
            // Act
            var okResult = _controller.GetFilmsStatics() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<DTOFilmStatics>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
        [Fact]
        public void GetRatingOfUser_ValidUserIdPasses_ReturnsOkResultAndCorrectObject()
        {
            // Arrange
            var userId = "43aaba9c-17bd-4e17-b2ec-7603644b8f27";
            _mockRepo.Setup(p => p.GetRatingsOfUser(userId)).Returns(new List<UserFilm> { new UserFilm(), new UserFilm(), new UserFilm() });
            // Act
            var okResult = _controller.GetRatingsOfUser(userId);
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<List<UserFilm>>(result.Value);
            // Assert
            Assert.Equal(3, item.Count());
        }

        [Fact]
        public void GetRatingOfUser_NotValidUserIdPasses_ReturnsNotFoundResult()
        {
            // Arrange
            var userId = "43aaba9c-17bd-4e17-b2ec-7603644b8f27";
            _mockRepo.Setup(p => p.GetRatingsOfUser(It.IsAny<string>())).Throws(new KeyNotFoundException());
            // Act
            var Result = _controller.GetRatingsOfUser(userId);
            // Assert
            Assert.IsType<NotFoundObjectResult>(Result);
        }

        [Fact]
        public void GetStaticsForFilm_ValidFilmIdPasses_ReturnsOkResultAndCorrectObject()
        {
            // Arrange
            var filmId = new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetStaticsForFilm(filmId)).Returns(new DTOFilmStatics());
            // Act
            var okResult = _controller.GetStaticsForFilm(filmId);
            // Assert
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<DTOFilmStatics>(result.Value);
        }

        [Fact]
        public void GetStaticsForFilm_NotValidFilmIdPasses_ReturnsNotFoundResult()
        {
            // Arrange
            var filmId = new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetStaticsForFilm(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var Result = _controller.GetStaticsForFilm(filmId);
            // Assert
            Assert.IsType<NotFoundObjectResult>(Result);
        }
        
        [Fact]
        public void GetUserFilm_ValidFilmIdUserIdPasses_ReturnsOkResultAndCorrectObject()
        {
            // Arrange
            var filmId = new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            var userId = "43aaba9c-17bd-4e17-b2ec-7603644b9f27";
            _mockRepo.Setup(p => p.GetUserFilm(userId,filmId)).Returns(new UserFilm { UserId = userId, FilmId = filmId, Rating = 4});
            // Act
            var okResult = _controller.GetUserFilm(userId,filmId);
            // Assert
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<UserFilm>(result.Value);
            Assert.Equal(filmId, item.FilmId);
            Assert.Equal(userId, item.UserId);
            Assert.Equal(4, item.Rating);
        }

        [Fact]
        public void GetUserFilm_NotValidFilmIdOrUserIdPasses_ReturnsNotFoundResult()
        {
            //Arrange
            var filmId = new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            var userId = "43aaba9c-17bd-4e17-b2ec-7603644b9f27";
            _mockRepo.Setup(p => p.GetUserFilm(It.IsAny<string>(), It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var Result = _controller.GetUserFilm(userId, filmId);
            // Assert
            Assert.IsType<NotFoundObjectResult>(Result);
        }

        [Fact]
        public void AddRating_ValidFilmIdUserIdAndRatingPasses_ReturnsOkResult()
        {
            // Arrange
            var filmId = new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            var userId = "43aaba9c-17bd-4e17-b2ec-7603644b9f27";
            // Act
            var okResult = _controller.AddRating(userId, filmId, 4);
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void AddRating_NotValidFilmIdOrUserIdPasses_ReturnsNotFoundResult()
        {
            //Arrange
            var filmId = new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            var userId = "43aaba9c-17bd-4e17-b2ec-7603644b9f27";
            _mockRepo.Setup(p => p.AddUserFilm(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<int>())).Throws(new KeyNotFoundException());
            // Act
            var Result = _controller.AddRating(userId, filmId, 4);
            // Assert
            Assert.IsType<NotFoundObjectResult>(Result);
        }

        [Fact]
        public void AddRating_NotValidRatingPasses_ReturnsBadRequestResult()
        {
            //Arrange
            var filmId = new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            var userId = "43aaba9c-17bd-4e17-b2ec-7603644b9f27";
            _mockRepo.Setup(p => p.AddUserFilm(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<int>())).Throws(new Exception());
            // Act
            var Result = _controller.AddRating(userId, filmId, 4);
            // Assert
            Assert.IsType<BadRequestObjectResult>(Result);
        }

        [Fact]
        public void RemoveUserFilm_ValidFilmIdUserIdPasses_ReturnsOkResult()
        {
            // Arrange
            var filmId = new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            var userId = "43aaba9c-17bd-4e17-b2ec-7603644b9f27";
            // Act
            var okResult = _controller.DeleteUserFilm(userId, filmId);
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void RemoveUserFilm_NotValidFilmIdOrUserIdPasses_ReturnsNotFoundResult()
        {
            //Arrange
            var filmId = new Guid("43aaba9c-17bd-4e17-b2ec-7603644b8f27");
            var userId = "43aaba9c-17bd-4e17-b2ec-7603644b9f27";
            _mockRepo.Setup(p => p.DeleteUserFilm(It.IsAny<string>(), It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var Result = _controller.DeleteUserFilm(userId, filmId);
            // Assert
            Assert.IsType<NotFoundObjectResult>(Result);
        }
    }
}
