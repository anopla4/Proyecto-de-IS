using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IPurchaseOrderRepository
    {
        List<PurchaseOrder> GetPurchaseOrders();
        PurchaseOrder GetPurchaseOrder(Guid purchaseOrderId);
        PurchaseOrder AddPurchaseOrder(PurchaseOrder purchaseOrder);
        void PayPurchaseOrder(Guid purchaseOrderId);
        void RemoveItems(Guid purchaseOrderId, List<Item> items);
        void CancelPurchaseOrder(Guid purchaseOrderId);
        void CheckPendingToCancel(Guid purchaseOrderId);
    }
}
