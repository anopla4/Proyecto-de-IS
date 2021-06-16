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
    public class ClubMemberControllerTest
    {
        private readonly Mock<IClubMemberRepository> _mockRepo;
        private readonly ClubMemberController _controller;

        public ClubMemberControllerTest()
        {
            _mockRepo = new Mock<IClubMemberRepository>();
            _controller = new ClubMemberController(_mockRepo.Object);
        }

        private ClubMember SeedClubMember(string guid_seed = "")
        {
            var seedClubMember = new ClubMember
            {
                Name = "TestClubMember",
                DateOfBirth = new DateTime(2020, 12, 12),
                Points = 10,
                Nationality = "TestNacionality"
            };
            if (guid_seed != "")
            {
                seedClubMember.Code = new Guid(guid_seed);
                seedClubMember.UserId = guid_seed;
            }
            return seedClubMember;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetClubMembers();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllRoles()
        {
            _mockRepo.Setup(repo => repo.GetClubMembers())
                .Returns(new List<ClubMember>() { new ClubMember(), new ClubMember(), new ClubMember() });
            // Act
            var okResult = _controller.GetClubMembers() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<ClubMember>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seed = this.SeedClubMember("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetClubMember("43aaaa9c-17bd-4e17-b2ec-7603644b8f27")).Returns(seed);
            var okResult = _controller.GetClubMember("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<ClubMember>(result.Value);
            Assert.Equal(seed, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetClubMember(It.IsAny<string>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetClubMember("43bbbb9c-17bd-4e17-b2ec-7603644b8f27");
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnsOkResponse()
        {
            // Arrange
            var seed = this.SeedClubMember();
            _mockRepo.Setup(repo => repo.AddClubMember("43bbbb9c-17bd-4e17-b2ec-7603644b8f27",seed))
                .Returns(new ClubMember { UserId = "43bbbb9c-69bd-4a17-b2ec-7703644c8f27", Name = seed.Name });
            // Act
            var okResponse = _controller.AddClubMember("43bbbb9c-17bd-4e17-b2ec-7603644b8f27",seed);
            // Assert
            Assert.IsType<OkObjectResult>(okResponse);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseHasCreatedItem()
        {
            // Arrange
            var seed = this.SeedClubMember();
            _mockRepo.Setup(repo => repo.AddClubMember("43bbbb9c-17bd-4e17-b2ec-7603644b8f27",seed))
                .Returns(new ClubMember { UserId = "43bbbb9c-69bd-4a17-b2ec-7703644c8f27", Name = seed.Name });
            // Act
            var okResponse = _controller.AddClubMember("43bbbb9c-17bd-4e17-b2ec-7603644b8f27",seed) as OkObjectResult;
            var item = okResponse.Value as ClubMember;
            // Assert
            Assert.IsType<ClubMember>(item);
            Assert.Equal(seed.Name, item.Name);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseCalledAddOnceTime()
        {
            // Arrange
            ClubMember fr = null;
            _mockRepo.Setup(repo => repo.AddClubMember(It.IsAny<string>(),It.IsAny<ClubMember>()))
                .Callback<string,ClubMember>((x,y) => fr = y);
            var seed = this.SeedClubMember();
            // Act
            _controller.AddClubMember("43bbbb9c-69bd-4a17-b2ec-7703644c8f27",seed);
            _mockRepo.Verify(x => x.AddClubMember(It.IsAny<string>(),It.IsAny<ClubMember>()), Times.Once);
            // Assert
            Assert.Equal(fr.Name, seed.Name);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.DeleteClubMember("43bbbb9c-69bd-4a17-b2ec-7703644c8f27");
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemoveClubMember(It.IsAny<string>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.DeleteClubMember("43bbbb9c-69bd-4a17-b2ec-7703644c8f27");
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Update_Valid_ReturnOkObjectResult()
        {
            var seed = this.SeedClubMember("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetClubMember("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))
                .Returns(seed);
            _mockRepo.Setup(p => p.UpdateClubMember(seed)).Returns(seed);
            var okResult = _controller.UpdateClubMember(seed);
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<ClubMember>(result.Value);
            Assert.Equal(seed.UserId, item.UserId);
        }

        [Fact]
        public void Update_Invalid_ReturnNotFoundResult()
        {
            _mockRepo.Setup(p => p.UpdateClubMember(It.IsAny<ClubMember>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.UpdateClubMember(new ClubMember());
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
