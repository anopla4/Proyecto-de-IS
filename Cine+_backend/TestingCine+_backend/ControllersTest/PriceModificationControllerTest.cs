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
    public class PriceModificationControllerTest
    {
        private readonly Mock<IPriceModificationRepository> _mockRepo;
        private readonly PriceModificationController _controller;

        public PriceModificationControllerTest()
        {
            _mockRepo = new Mock<IPriceModificationRepository>();
            _controller = new PriceModificationController(_mockRepo.Object);
        }

        private PriceModification SeedPriceModification(string guid_seed = "")
        {
            var seedPriceModification = new PriceModification
            {
                Name = "TestPriceModification",
                Value = 13,
                Description = "TestPriceModificationDescription",
                Type = "TestPriceModificationType"
            };
            if (guid_seed != "")
            {
                seedPriceModification.Id = new Guid(guid_seed);
            }
            return seedPriceModification;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetPriceModifications();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllRoles()
        {
            _mockRepo.Setup(repo => repo.GetPriceModifications())
                .Returns(new List<PriceModification>() { new PriceModification(), new PriceModification(), new PriceModification() });
            // Act
            var okResult = _controller.GetPriceModifications() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<PriceModification>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seed = this.SeedPriceModification("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetPriceModification(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seed);
            var okResult = _controller.GetPriceModification(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<PriceModification>(result.Value);
            Assert.Equal(seed, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetPriceModification(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetPriceModification(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnsOkResponse()
        {
            // Arrange
            var seed = this.SeedPriceModification();
            _mockRepo.Setup(repo => repo.AddPriceModification(seed))
                .Returns(new PriceModification { Id = new Guid(), Name = seed.Name });
            // Act
            var okResponse = _controller.AddPriceModification(seed);
            // Assert
            Assert.IsType<OkObjectResult>(okResponse);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseHasCreatedItem()
        {
            // Arrange
            var seed = this.SeedPriceModification();
            _mockRepo.Setup(repo => repo.AddPriceModification(seed))
                .Returns(new PriceModification { Id = Guid.NewGuid(), Name = seed.Name });
            // Act
            var okResponse = _controller.AddPriceModification(seed) as OkObjectResult;
            var item = okResponse.Value as PriceModification;
            // Assert
            Assert.IsType<PriceModification>(item);
            Assert.Equal(seed.Name, item.Name);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseCalledAddOnceTime()
        {
            // Arrange
            PriceModification fr = null;
            _mockRepo.Setup(repo => repo.AddPriceModification(It.IsAny<PriceModification>()))
                .Callback<PriceModification>(x => fr = x);
            var seed = this.SeedPriceModification();
            // Act
            _controller.AddPriceModification(seed);
            _mockRepo.Verify(x => x.AddPriceModification(It.IsAny<PriceModification>()), Times.Once);
            // Assert
            Assert.Equal(fr.Name, seed.Name);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.RemovePriceModification(new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemovePriceModification(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.RemovePriceModification(new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Update_Valid_ReturnOkObjectResult()
        {
            var seed = this.SeedPriceModification("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.UpdatePriceModification(seed)).Returns(seed);
            var okResult = _controller.UpdatePriceModification(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                seed);
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<PriceModification>(result.Value);
            Assert.Equal(seed.Id, item.Id);
        }

        [Fact]
        public void Update_Invalid_ReturnNotFoundResult()
        {
            _mockRepo.Setup(p => p.UpdatePriceModification(It.IsAny<PriceModification>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.UpdatePriceModification(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"),
                new PriceModification());
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
