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
    public class Top10ControllerTest
    {
        private readonly Mock<ITop10Repository> _mockRepo;
        private readonly Top10Controller _controller;

        public Top10ControllerTest()
        {
            _mockRepo = new Mock<ITop10Repository>();
            _controller = new Top10Controller(_mockRepo.Object);
        }

        private Top10Film SeedTop10Film()
        {
            Top10Film seedTop10Film = new Top10Film
            {
                FilmId = new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f37")
            };
            return seedTop10Film;
        }

        [Fact]
        public void GetTop10_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetTop10();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetTop10_WhenCalled_ReturnsTop10Movies()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetTop10())
                .Returns(new List<Top10Film>() { new Top10Film(), new Top10Film(), new Top10Film(), new Top10Film(), new Top10Film(), new Top10Film(), new Top10Film(), new Top10Film(), new Top10Film(), new Top10Film() });
            // Act
            var okResult = _controller.GetTop10() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Top10Film>>(okResult.Value);
            Assert.Equal(10, items.Count);
        }

        [Fact]
        public void GetTop10FilmById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seedTop10Film = this.SeedTop10Film();
            _mockRepo.Setup(p => p.GetTop10Film(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f37"))).Returns(seedTop10Film);
            var okResult = _controller.GetMovieInTop10(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f37"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<Top10Film>(result.Value);
            Assert.Equal(seedTop10Film, item);
        }

        [Fact]
        public void GetTop10FilmById_WhenFilmIdNotValid_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetTop10Film(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetMovieInTop10(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void AddTop10_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.AddTop10(new List<Film> { new Film(), new Film() });
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void AddTop10_WhenSomeFilmIdNotValid_ReturnsNotFoundResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.AddTop10Film(It.IsAny<Film>()))
                .Throws(new KeyNotFoundException());
            // Act
            var Result = _controller.AddTop10(new List<Film> { new Film(), new Film()});
            // Assert
            Assert.IsType<NotFoundObjectResult>(Result);
        }

        [Fact]
        public void RemoveTop10Film_WhenIsValidFilmId_ReturnsOkResult()
        {
            // Arrange
            var seedTop10Film = this.SeedTop10Film();
            // Act
            var okResult = _controller.RemoveFilmFromTop10(seedTop10Film.FilmId);
            // Assert
            var result = Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void RemoveTop10Film_WhenFilmIdIsNotValid_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.RemoveTop10Film(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.RemoveFilmFromTop10(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
