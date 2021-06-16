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
    public class ReservationControllerTest
    {
        private readonly Mock<IReservationRepository> _mockRepo;
        private readonly ReservationController _controller;

        public ReservationControllerTest()
        {
            _mockRepo = new Mock<IReservationRepository>();
            _controller = new ReservationController(_mockRepo.Object);
        }

        private Reservation SeedReservation(string guid_seed = "")
        {
            var seedReservation = new Reservation
            {
                Points = 10,
                Price = 12,
            };
            if (guid_seed != "")
            {
                seedReservation.Id = new Guid(guid_seed);
            }
            return seedReservation;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetReservationsFromFilmScreening(new Guid());
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAllByFilmScreeningId_WhenCalled_ReturnsAllReservations()
        {
            _mockRepo.Setup(repo => repo.GetReservationsFromFilmScreening(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27")))
                .Returns(new List<Reservation>() { new Reservation(), new Reservation(), new Reservation() });
            // Act
            var okResult = _controller.GetReservationsFromFilmScreening(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27")) as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Reservation>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnsOkResponse()
        {
            // Arrange
            var seed = this.SeedReservation();
            _mockRepo.Setup(repo => repo.AddReservation(seed));
            // Act
            var okResponse = _controller.AddReservation(seed);
            // Assert
            Assert.IsType<OkResult>(okResponse);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseCalledAddOnceTime()
        {
            // Arrange
            Reservation fr = null;
            _mockRepo.Setup(repo => repo.AddReservation(It.IsAny<Reservation>()))
                .Callback<Reservation>(x => fr = x);
            var seed = this.SeedReservation();
            // Act
            _controller.AddReservation(seed);
            _mockRepo.Verify(x => x.AddReservation(It.IsAny<Reservation>()), Times.Once);
            // Assert
            Assert.Equal(fr.Price, seed.Price);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.DeleteReservation(new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemoveReservation(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.DeleteReservation(new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
