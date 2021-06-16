using Cine__backend.Controllers;
using Cine__backend.Interfaces;
using Cine__backend.Models;
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
    public class PurchaseOrderControllerTest
    {
        private readonly Mock<IPurchaseOrderRepository> _mockRepo;
        private readonly PurchaseOrderController _controller;

        public PurchaseOrderControllerTest()
        {
            _mockRepo = new Mock<IPurchaseOrderRepository>();
            _controller = new PurchaseOrderController(_mockRepo.Object);
        }

        private PurchaseOrder SeedPurchaseOrder(string guid_seed = "")
        {
            PurchaseOrder seedPurchaseOrder = new PurchaseOrder
            {
                UserId = "43aaaa9c-17bd-4e17-b2ec-7603644b8f27",
                Items = new List<Item>(),
                Date = DateTime.Today,
                PaidByPoints = true,
                PurchaseTime = "12:20 am"
            };
            if (guid_seed != "")
            {
                seedPurchaseOrder.Id = new Guid(guid_seed);
            }
            return seedPurchaseOrder;
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetPurchaseOrders();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllBookEntries()
        {
            _mockRepo.Setup(repo => repo.GetPurchaseOrders())
                .Returns(new List<PurchaseOrder>() { new PurchaseOrder(), new PurchaseOrder(), new PurchaseOrder() });
            // Act
            var okResult = _controller.GetPurchaseOrders() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<PurchaseOrder>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            var seedPurchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(p => p.GetPurchaseOrder(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"))).Returns(seedPurchaseOrder);
            var okResult = _controller.GetPurchaseOrder(new Guid("43aaaa9c-17bd-4e17-b2ec-7603644b8f27"));
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<PurchaseOrder>(result.Value);
            Assert.Equal(seedPurchaseOrder, item);
        }

        [Fact]
        public void GetById_WhenCalled_ReturnsNotFoundsResult()
        {
            _mockRepo.Setup(p => p.GetPurchaseOrder(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetPurchaseOrder(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"));
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }
        [Fact]
        public void GetByUserName_WhenCalled_ReturnsOkResultAndCorrectObject()
        {
            string userName = "jlopetegui98";
            _mockRepo.Setup(p => p.GetPurchaseOrdersOfUser(userName)).Returns(new List<PurchaseOrder> { new PurchaseOrder(), new PurchaseOrder()});
            var okResult = _controller.GetPurchaseOrdersOfUser(userName);
            var result = Assert.IsType<OkObjectResult>(okResult);
            var item = Assert.IsType<List<PurchaseOrder>>(result.Value);
            Assert.Equal(2, item.Count);
        }

        [Fact]
        public void GetByUserName_WhenCalled_ReturnsNotFoundsResult()
        {
            string userName = "jlopetegui98";
            _mockRepo.Setup(p => p.GetPurchaseOrdersOfUser(It.IsAny<string>())).Throws(new KeyNotFoundException());
            var notFoundResult = _controller.GetPurchaseOrdersOfUser(userName);
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public void Add_ValidPurchaseOrderPassed_ReturnsCreatedResponse()
        {
            // Arrange
            PurchaseOrder PurchaseOrder = this.SeedPurchaseOrder();
            _mockRepo.Setup(repo => repo.AddPurchaseOrder(PurchaseOrder))
                .Returns(new PurchaseOrder { Id = Guid.NewGuid(), UserId = PurchaseOrder.UserId, PurchaseTime = PurchaseOrder.PurchaseTime, Date = PurchaseOrder.Date, PaidByPoints = PurchaseOrder.PaidByPoints, Items = PurchaseOrder.Items });
            // Act
            var createdResponse = _controller.AddPurchaseOrder(PurchaseOrder);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }
        [Fact]
        public void Add_ValidPurchaseOrderPassed_ReturnsCreatedPurchaseOrder()
        {
            // Arrange
            PurchaseOrder PurchaseOrder = this.SeedPurchaseOrder();
            _mockRepo.Setup(repo => repo.AddPurchaseOrder(PurchaseOrder))
                .Returns(new PurchaseOrder { Id = Guid.NewGuid(), UserId = PurchaseOrder.UserId, PurchaseTime = PurchaseOrder.PurchaseTime, Date = PurchaseOrder.Date, PaidByPoints = PurchaseOrder.PaidByPoints, Items = PurchaseOrder.Items });
            // Act
            var createdResponse = _controller.AddPurchaseOrder(PurchaseOrder) as OkObjectResult;
            var item = createdResponse.Value as PurchaseOrder;
            // Assert
            Assert.IsType<PurchaseOrder>(item);
            Assert.Equal(PurchaseOrder.UserId, item.UserId);
            Assert.Equal(PurchaseOrder.PaidByPoints, item.PaidByPoints);
            Assert.Equal(PurchaseOrder.Date, item.Date);
            Assert.Equal(PurchaseOrder.PurchaseTime, item.PurchaseTime);
            Assert.Equal(PurchaseOrder.Items, item.Items);
        }

        [Fact]
        public void PayPurchaseOrder_ValidPurchaseOrderIdAndCreditCard_ReturnedOkResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            string creditCard = "2344 0234 4546 0000";
            // Act
            var createdResponse = _controller.PayPurchaseOrder(purchaseOrder.Id, creditCard);
            // Assert
            Assert.IsType<OkResult>(createdResponse);
        }

        [Fact]
        public void PayPurchaseOrder_NotValidPurchaseOrderId_ReturnedNotFoundResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            string creditCard = "2344 0234 4546 0000";
            _mockRepo.Setup(repo => repo.PayPurchaseOrder(It.IsAny<Guid>(), It.IsAny<string>())).Throws(new KeyNotFoundException());
            // Act
            var createdResponse = _controller.PayPurchaseOrder(purchaseOrder.Id, creditCard);
            // Assert
            Assert.IsType<NotFoundObjectResult>(createdResponse);
        }

        [Fact]
        public void PayPurchaseOrder_NotValidCreditCard_ReturnedBadRequestResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            string creditCard = "2344 0234 4546 0000";
            _mockRepo.Setup(repo => repo.PayPurchaseOrder(It.IsAny<Guid>(), It.IsAny<string>())).Throws(new Exception());
            // Act
            var createdResponse = _controller.PayPurchaseOrder(purchaseOrder.Id, creditCard);
            // Assert
            Assert.IsType<BadRequestObjectResult>(createdResponse);
        }

        [Fact]
        public void RemoveItems_ValidPurchaseOrderIdAndItemsIds_ReturnedOkResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            List<Guid> items = new List<Guid>();
            // Act
            var createdResponse = _controller.RemoveItems(purchaseOrder.Id, items);
            // Assert
            Assert.IsType<OkResult>(createdResponse);
        }

        [Fact]
        public void RemoveItems_NotValidPurchaseOrderIdOrSomeNotValidItemId_ReturnedNotFoundResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            List<Guid> items = new List<Guid>();
            _mockRepo.Setup(repo => repo.RemoveItems(It.IsAny<Guid>(), It.IsAny<List<Guid>>())).Throws(new KeyNotFoundException());
            // Act
            var createdResponse = _controller.RemoveItems(purchaseOrder.Id, items);
            // Assert
            Assert.IsType<NotFoundObjectResult>(createdResponse);
        }

        [Fact]
        public void RemoveItems_IfErrorRemoving_ReturnedBadRequestResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            List<Guid> items = new List<Guid>();
            _mockRepo.Setup(repo => repo.RemoveItems(It.IsAny<Guid>(), It.IsAny<List<Guid>>())).Throws(new Exception());
            // Act
            var createdResponse = _controller.RemoveItems(purchaseOrder.Id, items);
            // Assert
            Assert.IsType<BadRequestObjectResult>(createdResponse);
        }

        [Fact]
        public void CheckPendingPurchaseOrder_ValidPurchaseOrderId_ReturnedOkResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            // Act
            var createdResponse = _controller.CheckPendingPurchaseOrder(purchaseOrder.Id);
            // Assert
            Assert.IsType<OkResult>(createdResponse);
        }

        [Fact]
        public void CheckPendingPurchaseOrder_NotValidPurchaseOrderId_ReturnedNotFoundResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.CheckPendingToCancel(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var createdResponse = _controller.CheckPendingPurchaseOrder(purchaseOrder.Id);
            // Assert
            Assert.IsType<NotFoundObjectResult>(createdResponse);
        }

        [Fact]
        public void CheckPendingPurchaseOrder_IfError_ReturnedBadRequestResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.CheckPendingToCancel(It.IsAny<Guid>())).Throws(new Exception());
            // Act
            var createdResponse = _controller.CheckPendingPurchaseOrder(purchaseOrder.Id);
            // Assert
            Assert.IsType<BadRequestObjectResult>(createdResponse);
        }

        [Fact]
        public void CancelPurchaseOrder_ValidPurchaseOrderId_ReturnedOkResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            // Act
            var createdResponse = _controller.CancelPurchaseOrder(purchaseOrder.Id);
            // Assert
            Assert.IsType<OkResult>(createdResponse);
        }

        [Fact]
        public void CancelPurchaseOrder_NotValidPurchaseOrderId_ReturnedNotFoundResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.CancelPurchaseOrder(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
            // Act
            var createdResponse = _controller.CancelPurchaseOrder(purchaseOrder.Id);
            // Assert
            Assert.IsType<NotFoundObjectResult>(createdResponse);
        }

        [Fact]
        public void CancelPurchaseOrder_IfError_ReturnedBadRequestResponse()
        {
            // Arrange
            PurchaseOrder purchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
            _mockRepo.Setup(repo => repo.CancelPurchaseOrder(It.IsAny<Guid>())).Throws(new Exception());
            // Act
            var createdResponse = _controller.CancelPurchaseOrder(purchaseOrder.Id);
            // Assert
            Assert.IsType<BadRequestObjectResult>(createdResponse);
        }
        //[Fact]
        //public void Update_ValidPurchaseOrderPassed_ReturnedObjectUpdated()
        //{
        //    // Arrange
        //    PurchaseOrder PurchaseOrder = this.SeedPurchaseOrder("43aaaa9c-17bd-4e17-b2ec-7603644b8f27");
        //    _mockRepo.Setup(repo => repo.UpdatePurchaseOrder(PurchaseOrder))
        //        .Returns(new PurchaseOrder { Id = PurchaseOrder.Id, Income = 30, Expense = PurchaseOrder.Expense, Date = PurchaseOrder.Date, PaymentMethod = PaymentMethod.crédito, Description = PurchaseOrder.Description });
        //    // Act
        //    var createdResponse = _controller.UpdatePurchaseOrder(PurchaseOrder.Id, PurchaseOrder) as OkObjectResult;
        //    var item = createdResponse.Value as PurchaseOrder;
        //    // Assert
        //    Assert.IsType<PurchaseOrder>(item);
        //    Assert.Equal(PurchaseOrder.Id, item.Id);
        //    Assert.Equal(30, item.Income);
        //    Assert.Equal(PaymentMethod.crédito, item.PaymentMethod);
        //}

        //[Fact]
        //public void Delete_Valid_ReturnsOkResult()
        //{
        //    // Act
        //    var okResult = _controller.DeletePurchaseOrder(new Guid());
        //    // Assert
        //    Assert.IsType<OkResult>(okResult);
        //}

        //[Fact]
        //public void Delete_InValid_ReturnsNotFoundsResult()
        //{
        //    // Arrange
        //    _mockRepo.Setup(repo => repo.DeletePurchaseOrder(It.IsAny<Guid>())).Throws(new KeyNotFoundException());
        //    // Act
        //    var notFoundResult = _controller.DeletePurchaseOrder(new Guid());
        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(notFoundResult);
        //}

        //[Fact]
        //public void Update_Invalid_ReturnNotFoundResult()
        //{
        //    _mockRepo.Setup(p => p.UpdatePurchaseOrder(It.IsAny<PurchaseOrder>())).Throws(new KeyNotFoundException());
        //    var notFoundResult = _controller.UpdatePurchaseOrder(new Guid("43bbbb9c-17bd-4e17-b2ec-7603644b8f27"),
        //        new PurchaseOrder());
        //    Assert.IsType<NotFoundObjectResult>(notFoundResult);
        //}
    }
}
