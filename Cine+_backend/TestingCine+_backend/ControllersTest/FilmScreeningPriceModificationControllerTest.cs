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
    public class FilmScreeningPriceModificationControllerTest
    {
        private readonly Mock<IFilmScreeningPriceModificationRepository> _mockRepo;
        private readonly FilmScreeningPriceModificationController _controller;

        public FilmScreeningPriceModificationControllerTest()
        {
            _mockRepo = new Mock<IFilmScreeningPriceModificationRepository>();
            _controller = new FilmScreeningPriceModificationController(_mockRepo.Object);
        }

        private FilmScreeningPriceModification SeedFilmScreeningPriceModification(string fsId = "", string pmodId = "")
        {
            var seed= new FilmScreeningPriceModification
            {
                Optional = true
            };
            if (fsId != "")
            {
                seed.FilmScreening = new FilmScreening { Id = new Guid(fsId) };
                seed.FilmScreeningId = new Guid(fsId);
            }
            if (pmodId != "")
            {
                seed.PriceModification = new PriceModification { Id = new Guid(pmodId) };
                seed.PriceModificationId = new Guid(pmodId);
            }
            return seed;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetFilmScreeningPriceModifications();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllFSPriceMod()
        {
            _mockRepo.Setup(repo => repo.GetFilmScreeningPriceModifications())
                .Returns(new List<FilmScreeningPriceModification>() { new FilmScreeningPriceModification(), new FilmScreeningPriceModification(), new FilmScreeningPriceModification() });
            // Act
            var okResult = _controller.GetFilmScreeningPriceModifications() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<FilmScreeningPriceModification>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetByIds_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seed = this.SeedFilmScreeningPriceModification("43aaaa9c-17bd-4e17-b2ec-7603644b8f27", "43cccc9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetFilmScreeningPriceModification(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"), 
                new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seed);
            var okResult = _controller.GetFilmScreeningPriceModification(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<FilmScreeningPriceModification>(result.Value);
            Assert.Equal(seed, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetFilmScreeningPriceModification(It.IsAny<Guid>(), It.IsAny<Guid>()))
                .Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetFilmScreeningPriceModification(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("43cccc9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void GetByFilmSSId_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetPriceModificationOfFilmScreening(new Guid());
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAllByFSId_WhenCalled_ReturnsAllPriceMod()
        {
            _mockRepo.Setup(repo => repo.GetPriceModificationsOfFilmScreening(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27")))
                .Returns(new List<PriceModification>(){ new PriceModification(),new PriceModification(),new PriceModification()});
            // Act
            var okResult = _controller.GetPriceModificationOfFilmScreening(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27")) as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<PriceModification>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetAllByFSId_WhenCalled_ReturnsNotFound()
        {
            _mockRepo.Setup(repo => repo.GetPriceModificationsOfFilmScreening(It.IsAny<Guid>()))
                .Throws(new KeyNotFoundException());
            // Act
            var notFound = _controller.GetPriceModificationOfFilmScreening(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFound);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnsOkResponse()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.AddFilmScreeningPriceModifications(It.IsAny<FilmScreening>(),
                It.IsAny<List<PriceModification>>()));
            // Act
            var okResponse = _controller.AddFilmScreeningPriceModifications(new FilmScreening(), new List<PriceModification>());
            // Assert
            Assert.IsType<OkResult>(okResponse);
        }

        [Fact]
        public void Add_InvalidValuePassed_ReturnedNotFound()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.AddFilmScreeningPriceModifications(It.IsAny<FilmScreening>(),
                It.IsAny<List<PriceModification>>())).Throws(new KeyNotFoundException());
            // Act
            var notFound = _controller.AddFilmScreeningPriceModifications(new FilmScreening(), new List<PriceModification>());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFound);
        }


        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.RemoveFilmScreeningPriceModification(new Guid(), new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemoveFilmScreeningPriceModification(It.IsAny<Guid>(), It.IsAny<Guid>()))
                .Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.RemoveFilmScreeningPriceModification(new Guid(), new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Update_Valid_ReturnOkObjectResult()
        {
            var seed = this.SeedFilmScreeningPriceModification("43aaaa9c-17bd-4e17-b2ec-7603644b8f27", "43cccc9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.UpdateFilmScreeningPriceModification(seed.FilmScreening, new List<PriceModification> { seed.PriceModification }));
            var okResult = _controller.UpdateFilmScreeningPriceModifications(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"), seed.FilmScreening,
                new List<PriceModification> { seed.PriceModification });
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Update_Invalid_ReturnNotFoundResult()
        {
            _mockRepo.Setup(p => p.UpdateFilmScreeningPriceModification(It.IsAny<FilmScreening>(),
                It.IsAny<List<PriceModification>>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.UpdateFilmScreeningPriceModifications(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"),
                new FilmScreening(), new List<PriceModification>());
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
