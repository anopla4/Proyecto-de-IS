using Cine__backend.Controllers;
using Cine__backend.Interfaces;
using Cine__backend.Models;
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
    public class BookEntryControllerTest
    {
        private readonly Mock<IBookEntryRepository> _mockRepo;
        private readonly BookEntryController _controller;

        public BookEntryControllerTest()
        {
            _mockRepo = new Mock<IBookEntryRepository>();
            _controller = new BookEntryController(_mockRepo.Object);
        }

        private BookEntry SeedBookEntry(string guid_seed = "")
        {
            BookEntry seedBookEntry = new BookEntry
            {
                Income = 10,
                Expense = 0,
                Date = DateTime.Today,
                PaymentMethod = PaymentMethod.efectivo,
                Description = "unit-testing"
            };
            if (guid_seed != "")
            {
                seedBookEntry.Id = new Guid(guid_seed);
            }
            return seedBookEntry;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetBookEntries();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllBookEntries()
        {
            _mockRepo.Setup(repo => repo.GetBookEntries())
                .Returns(new List<BookEntry>() { new BookEntry(), new BookEntry(), new BookEntry() });
            // Act
            var okResult = _controller.GetBookEntries() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<BookEntry>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seedBookEntry = this.SeedBookEntry("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetBookEntry(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seedBookEntry);
            var okResult = _controller.GetBookEntry(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<BookEntry>(result.Value);
            Assert.Equal(seedBookEntry, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetBookEntry(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetBookEntry(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidBookEntryPassed_ReturnsCreatedResponse()
        {
            // Arrange
            BookEntry bookEntry = this.SeedBookEntry();
            _mockRepo.Setup(repo => repo.AddBookEntry(bookEntry))
                .Returns(new BookEntry { Id = Guid.NewGuid(), Income = bookEntry.Income, Expense = bookEntry.Expense, Date = bookEntry.Date, PaymentMethod = bookEntry.PaymentMethod, Description = bookEntry.Description });
            // Act
            var createdResponse = _controller.AddBookEntry(bookEntry);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }
        [Fact]
        public void Add_ValidBookEntryPassed_ReturnsCreatedBookEntry()
        {
            // Arrange
            BookEntry bookEntry = this.SeedBookEntry();
            _mockRepo.Setup(repo => repo.AddBookEntry(bookEntry))
                .Returns(new BookEntry { Id = Guid.NewGuid(), Income = bookEntry.Income, Expense = bookEntry.Expense, Date = bookEntry.Date, PaymentMethod = bookEntry.PaymentMethod, Description = bookEntry.Description });
            // Act
            var createdResponse = _controller.AddBookEntry(bookEntry) as OkObjectResult;
            var item = createdResponse.Value as BookEntry;
            // Assert
            Assert.IsType<BookEntry>(item);
            Assert.Equal(bookEntry.Income, item.Income);
            Assert.Equal(bookEntry.Expense, item.Expense);
            Assert.Equal(bookEntry.Date, item.Date);
            Assert.Equal(bookEntry.Description, item.Description);
            Assert.Equal(bookEntry.PaymentMethod, item.PaymentMethod);
        }

        [Fact]
        public void Update_ValidBookEntryPassed_ReturnedOkResponse()
        {
            // Arrange
            BookEntry bookEntry = this.SeedBookEntry("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.UpdateBookEntry(bookEntry))
                .Returns(new BookEntry { Id = bookEntry.Id, Income = 30, Expense = bookEntry.Expense, Date = bookEntry.Date, PaymentMethod = PaymentMethod.crédito, Description = bookEntry.Description });
            // Act
            var createdResponse = _controller.UpdateBookEntry(bookEntry.Id, bookEntry);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }

        [Fact]
        public void Update_ValidBookEntryPassed_ReturnedObjectUpdated()
        {
            // Arrange
            BookEntry bookEntry = this.SeedBookEntry("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.UpdateBookEntry(bookEntry))
                .Returns(new BookEntry { Id = bookEntry.Id, Income = 30, Expense = bookEntry.Expense, Date = bookEntry.Date, PaymentMethod = PaymentMethod.crédito, Description = bookEntry.Description });
            // Act
            var createdResponse = _controller.UpdateBookEntry(bookEntry.Id, bookEntry) as OkObjectResult;
            var item = createdResponse.Value as BookEntry;
            // Assert
            Assert.IsType<BookEntry>(item);
            Assert.Equal(bookEntry.Id, item.Id);
            Assert.Equal(30, item.Income);
            Assert.Equal(PaymentMethod.crédito, item.PaymentMethod);
        }

        [Fact]
        public void Delete_Valid_ReturnsOkResult()
        {  
            // Act
            var okResult = _controller.DeleteBookEntry(new Guid());
            // Assert
            Assert.IsType<OkResult>(okResult);
        }

        [Fact]
        public void Delete_InValid_ReturnsNotFoundsResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.DeleteBookEntry(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var notFoundResult = _controller.DeleteBookEntry(new Guid());
            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Update_Invalid_ReturnNotFoundResult()
        {
            _mockRepo.Setup(p => p.UpdateBookEntry(It.IsAny<BookEntry>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.UpdateBookEntry(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"),
                new BookEntry());
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
    }
}
