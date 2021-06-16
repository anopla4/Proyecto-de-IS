using Cine__backend.Authentication;
using Cine__backend.Controllers;
using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TestingCine__backend.ControllersTest
{
    public class UserControllerTest
    {
        private readonly Mock<IUserRepository> _mockRepo;
        private readonly UserController _controller;

        public UserControllerTest()
        {
            _mockRepo = new Mock<IUserRepository>();
            _controller = new UserController(_mockRepo.Object);
        }

        private User SeedUser(string id = "")
        {
            var seedUser = new User
            {
                UserName = "TestUserName",
                Email = "testEmail@test.com",
                EmailConfirmed = true,
            };
            if (id != "")
            {
                seedUser.Id = id;
            }
            return seedUser;
        }
        private UserAccountModel SeedUserAccountModel(string id = "")
        {
            var user = this.SeedUser(id);
            var seed = new UserAccountModel
            {
                ClubMember = false,
                Email = user.Email,
                Roles = new List<string>(),
                UserName = user.UserName
            };
            return seed;
        }

        [Fact]
        public async void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.GetUsersAsync();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public async void GetAll_WhenCalled_ReturnsAllUsers()
        {
            _mockRepo.Setup(repo =>  repo.GetUsersAsync())
                .ReturnsAsync(new List<UserAccountModel> { new UserAccountModel(), new UserAccountModel() });
            // Act
            var okResult = await _controller.GetUsersAsync() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<UserAccountModel>>(okResult.Value);
            Assert.Equal(2, items.Count);
        }

        [Fact]
        public async void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seeduser = this.SeedUser("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            var seedAcc = this.SeedUserAccountModel("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetUserByIdAsync("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))
                .ReturnsAsync(seedAcc);
            var okResult = await _controller.GetUserByIdAsync("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<UserAccountModel>(result.Value);
            Assert.Equal(seeduser.UserName, item.UserName);
        }

        [Fact]
        public async void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetUserByIdAsync(It.IsAny<string>())).Throws(new KeyNotFoundException());
            var notFoundResult = await _controller.GetUserByIdAsync("43bbbb9c-17bd-4e17-b2ec-7603644b8f27");
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }


        [Fact]
        public async void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.RemoveUserByIdAsync(new Guid().ToString());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public async void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.RemoveUserByIdAsync(It.IsAny<string>()))
                .Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = await _controller.RemoveUserByIdAsync(new Guid().ToString());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public async void UpdateUsersRoles_Valid_ReturnsOkResultWithModels()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.UpdateUsersRoles(It.IsAny<List<UserRolesModel>>()))
                .ReturnsAsync(new List<UserAccountModel>());
            // Act
            var okResult = await _controller.UsersRolesAsync(new List<UserRolesModel>()) as OkObjectResult;
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
            Assert.IsType<List<UserAccountModel>>(okResult.Value);
        }

        [Fact]
        public async void UpdateUsersRoles_Invalid_ReturnsNotFound()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.UpdateUsersRoles(It.IsAny<List<UserRolesModel>>()))
                .Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = await _controller.UsersRolesAsync(new List<UserRolesModel>());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

    }
}
