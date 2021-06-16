using Cine__backend.Controllers;
using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestingCine__backend.ControllersTest
{
    public class FilmControllerTest
    {
        private readonly Mock<IFilmRepository> _mockRepo;
        private readonly FilmController _controller;

        public FilmControllerTest()
        {
            _mockRepo = new Mock<IFilmRepository>();
            _controller = new FilmController(_mockRepo.Object);
        }

        private Film SeedFilm(string guid_seed = "")
        {
            var seedFilm = new Film
            {
                Name = "TestFilm",
                Country = "TestCountry",
                Year = "2000"
            };
            if (guid_seed != "")
            {
                seedFilm.Id = new Guid(guid_seed);
            }
            return seedFilm;
        }

        private DTOFilm SeedDTOFilm(string guid_seed = "")
        {
            var seedDto = new DTOFilm
            {
                Film = this.SeedFilm(guid_seed),
                Genres = new List<Genre> {
                    new Genre { Name = "TestGenre1"},
                    new Genre { Name = "TestGenre2"}}
            };
            return seedDto;
        }

        private DTOFilmStaff SeedDTOFilmStaff(string guid_seed = "")
        {
            var seedDto = new DTOFilmStaff
            {
                Film = this.SeedFilm(guid_seed),
                Genres = new List<Genre> {
                    new Genre { Name = "TestGenre1"},
                    new Genre { Name = "TestGenre2"}},
                Staff = new List<DTOMemberRol> { 
                    new DTOMemberRol
                    {
                        Member = "TestMember1", 
                        Rol = new FilmRol{Name = "TestRole1"}
                    },
                    new DTOMemberRol
                    {
                        Member = "TestMember2",
                        Rol = new FilmRol{Name = "TestRole2"}
                    }
                }           
            };
            return seedDto;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetFilms();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllFilms()
        {
            _mockRepo.Setup(repo => repo.GetFilms())
                .Returns(new List<DTOFilm>() { new DTOFilm(), new DTOFilm(), new DTOFilm() });
            // Act
            var okResult = _controller.GetFilms() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<DTOFilm>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetAllWithStaff_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetFilmsWithStaff();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAllWithStaff_WhenCalled_ReturnsAllFilmsWithStaff()
        {
            _mockRepo.Setup(repo => repo.GetFilmsWithStaff())
                .Returns(new List<DTOFilmStaff>() { new DTOFilmStaff(), 
                                        new DTOFilmStaff(), new DTOFilmStaff() });
            // Act
            var okResult = _controller.GetFilmsWithStaff() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<DTOFilmStaff>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seedDto = this.SeedDTOFilm("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetFilm(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seedDto);
            var okResult = _controller.GetFilm(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<DTOFilm>(result.Value);
            Assert.Equal(seedDto, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetFilm(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetFilm(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void GetByIdFilmStaff_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            _mockRepo.Setup(repo => repo.GetFilmStaff(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27")))
                .Returns(new List<DTOMemberRol>() { new DTOMemberRol(), 
                                    new DTOMemberRol(), new DTOMemberRol()});
            // Act
            var okResult = _controller.GetFilmStaff(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27")) as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<DTOMemberRol>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetByIdFilmStaff_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetFilmStaff(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetFilmStaff(new Guid("43aacb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnsOkResponse()
        {
            // Arrange
            var seedDto = this.SeedDTOFilmStaff();
            _mockRepo.Setup(repo => repo.AddFilm(seedDto.Film, (List<Genre>)seedDto.Genres, (List<DTOMemberRol>)seedDto.Staff))
                .Returns(this.SeedDTOFilmStaff(new Guid().ToString()));
            // Act
            var okResponse = _controller.AddFilm(seedDto.Film, (List<Genre>)seedDto.Genres, (List<DTOMemberRol>)seedDto.Staff);
            // Assert
            Assert.IsType<OkObjectResult>(okResponse);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseHasCreatedItem()
        {
            // Arrange
            var seedDto = this.SeedDTOFilmStaff();
            _mockRepo.Setup(repo => repo.AddFilm(seedDto.Film, (List<Genre>)seedDto.Genres, (List<DTOMemberRol>)seedDto.Staff))
                .Returns(this.SeedDTOFilmStaff(new Guid().ToString()));
            // Act
            var okResponse = _controller.AddFilm(seedDto.Film, (List<Genre>)seedDto.Genres, (List<DTOMemberRol>)seedDto.Staff) as OkObjectResult;
            var item = okResponse.Value as DTOFilmStaff;
            // Assert
            Assert.IsType<DTOFilmStaff>(item);
            Assert.Equal(seedDto.Film.Name, item.Film.Name);
        }

        [Fact]
        public void Add_ValidValuePassed_ReturnedResponseCalledAddOnceTime()
        {
            // Arrange
            DTOFilmStaff dto_fs = null;
            _mockRepo.Setup(repo => repo.AddFilm(It.IsAny<Film>(), It.IsAny<List<Genre>>(), It.IsAny<List<DTOMemberRol>>()))
                .Callback<Film,List<Genre>,List<DTOMemberRol>>((x,y,z) => dto_fs = new DTOFilmStaff { Film=x, Genres=y, Staff=z });
            var seed = this.SeedDTOFilmStaff();
            // Act
            _controller.AddFilm(seed.Film, (List<Genre>)seed.Genres, (List<DTOMemberRol>)seed.Staff);
            _mockRepo.Verify(x => x.AddFilm(It.IsAny<Film>(), It.IsAny<List<Genre>>(), It.IsAny<List<DTOMemberRol>>()), Times.Once);
            // Assert
            Assert.Equal(dto_fs.Film.Name, seed.Film.Name);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.DeleteFilm(new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.DeleteFilm(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.DeleteFilm(new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Update_Valid_ReturnOkObjectResult()
        {
            var seedFilm = this.SeedFilm("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            var dto_fs = this.SeedDTOFilmStaff("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetFilm(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27")))
                .Returns(this.SeedDTOFilm("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            _mockRepo.Setup(p => p.UpdateFilm(dto_fs.Film, (List<Genre>)dto_fs.Genres, (List<DTOMemberRol>)dto_fs.Staff))
                .Returns(dto_fs);
            var okResult = _controller.UpdateFilm(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"),
                dto_fs.Film, (List<Genre>)dto_fs.Genres, (List<DTOMemberRol>)dto_fs.Staff);
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<DTOFilmStaff>(result.Value);
            Assert.Equal(dto_fs.Film.Id, item.Film.Id);
        }

        [Fact]
        public void Update_Invalid_ReturnNotFoundResult()
        {
            _mockRepo.Setup(p => p.UpdateFilm(It.IsAny<Film>(), It.IsAny<List<Genre>>(), It.IsAny<List<DTOMemberRol>>()))
                .Throws(new KeyNotFoundException());
            var notFoundResult = _controller.UpdateFilm(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"),new Film(), new List<Genre>(), new List<DTOMemberRol>());
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
