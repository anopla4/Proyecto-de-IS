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
    public class SectionControllerTest
    {
        private readonly Mock<ISectionRepository> _mockRepo;
        private readonly SectionController _controller;

        public SectionControllerTest()
        {
            _mockRepo = new Mock<ISectionRepository>();
            _controller = new SectionController(_mockRepo.Object);
        }

        private Section SeedSection(string guid_seed = "")
        {
            Section seedSection = new Section
            {
                Name = "Sala 1",
            };
            if (guid_seed != "")
            {
                seedSection.Id = new Guid(guid_seed);
            }
            return seedSection;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetSections();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllSections()
        {
            _mockRepo.Setup(repo => repo.GetSections())
                .Returns(new List<Section>() { new Section(), new Section(), new Section() });
            // Act
            var okResult = _controller.GetSections() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Section>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seedSection = this.SeedSection("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetSection(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seedSection);
            var okResult = _controller.GetSection(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<Section>(result.Value);
            Assert.Equal(seedSection, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetSection(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetSection(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidSectionPassed_ReturnsCreatedResponse()
        {
            // Arrange
            Section Section = this.SeedSection();
            _mockRepo.Setup(repo => repo.AddSection(Section))
                .Returns(new Section { Id = Guid.NewGuid(), Name = Section.Name });
            // Act
            var createdResponse = _controller.AddSection(Section);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }
        [Fact]
        public void Add_ValidSectionPassed_ReturnsCreatedSection()
        {
            // Arrange
            Section Section = this.SeedSection();
            _mockRepo.Setup(repo => repo.AddSection(Section))
                .Returns(new Section { Id = Guid.NewGuid(), Name = Section.Name });
            // Act
            var createdResponse = _controller.AddSection(Section) as OkObjectResult;
            var item = createdResponse.Value as Section;
            // Assert
            Assert.IsType<Section>(item);
            Assert.Equal(Section.Name, item.Name);
        }

        [Fact]
        public void Update_ValidSectionPassed_ReturnedOkResponse()
        {
            // Arrange
            Section seedSection = this.SeedSection("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.UpdateSection(seedSection))
                .Returns(new Section { Id = seedSection.Id, Name = "Sala 2" });
            _mockRepo.Setup(repo => repo.GetSection(seedSection.Id))
                .Returns(new Section { Id = seedSection.Id, Name = seedSection.Name });
            // Act
            var createdResponse = _controller.UpdateSection(seedSection.Id, seedSection);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }

        [Fact]
        public void Update_ValidSectionPassed_ReturnedObjectUpdated()
        {
            // Arrange
            Section seedSection = this.SeedSection("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.UpdateSection(seedSection))
                .Returns(new Section { Id = seedSection.Id, Name = "Sala 2" });
            _mockRepo.Setup(repo => repo.GetSection(seedSection.Id))
                .Returns(new Section { Id = seedSection.Id, Name = seedSection.Name });
            // Act
            var createdResponse = _controller.UpdateSection(seedSection.Id, seedSection) as OkObjectResult;
            var item = createdResponse.Value as Section;
            // Assert
            Assert.IsType<Section>(item);
            Assert.Equal(seedSection.Id, item.Id);
            Assert.Equal(seedSection.Name, item.Name);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.RemoveSection(new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemoveSection(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.RemoveSection(new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Update_Invalid_ReturnNotFoundResult()
        {
            _mockRepo.Setup(p => p.UpdateSection(It.IsAny<Section>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.UpdateSection(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"),
                new Section());
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
