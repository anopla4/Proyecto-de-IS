using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private AppDbContext _context;
        public PurchaseOrderRepository(AppDbContext context)
        {
            _context = context;
        }
        public PurchaseOrder AddPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            purchaseOrder.Id = Guid.NewGuid();

            if (purchaseOrder.BoxOffice.Count() > 0)
            {
                double income = 0;
                int pointsAdd = 0;
                purchaseOrder.State = StatePurchaseOrder.completed;

                foreach(Reservation reservation in purchaseOrder.Items)
                {
                    pointsAdd += 5;
                    reservation.Id = Guid.NewGuid();
                    _context.Items.Add(reservation);
                    income += reservation.Price;
                }
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Income = income, Date = purchaseOrder.Date, Expense = 0, PaymentMethod = PaymentMethod.efectivo, Description = purchaseOrder.BoxOffice });
                if (_context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
                {
                    var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                    currMember.Points += pointsAdd;
                    _context.ClubMembers.Update(currMember);
                }
                _context.SaveChanges();
                return purchaseOrder;
            }
            if (purchaseOrder.PaidByPoints)
            {
                if (!_context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
                    throw new Exception("El usuario no está autorizado a pagar por puntos. Regístrese como ClubMember para acceder a esta opción.");
                int points = 0;
                purchaseOrder.State = StatePurchaseOrder.completed;
                foreach (Reservation reservation in purchaseOrder.Items)
                {
                    reservation.Id = Guid.NewGuid();
                    _context.Items.Add(reservation);
                    points += reservation.Points;
                }
                if(points > _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId).Points)
                        throw new Exception("No tiene los puntos necesarios para pagar esta orden de compra.");
                var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                currMember.Points -= points;
                _context.ClubMembers.Update(currMember);
                _context.SaveChanges();
                return purchaseOrder;
            }
            purchaseOrder.State = StatePurchaseOrder.pending;

            foreach (Reservation reservation in purchaseOrder.Items)
            {
                reservation.Id = Guid.NewGuid();
                _context.Items.Add(reservation);
            }
            _context.SaveChanges();
            return purchaseOrder;
        }

        public void CancelPurchaseOrder(Guid purchaseOrderId)
        {
            PurchaseOrder purchaseOrder = _context.PurchaseOrders.Include(c => c.Items).Include(c => c.User).SingleOrDefault(c => c.Id == purchaseOrderId);
            if (purchaseOrder == null)
                throw new KeyNotFoundException("No se encuentra la orden de compra especificada");
            if (!(purchaseOrder.State == StatePurchaseOrder.pending) && !(purchaseOrder.State == StatePurchaseOrder.completed))
                throw new Exception("Ya esta orden de compra fue cancelada");
            if(!CanCancel(purchaseOrder.Date, purchaseOrder.PurchaseTime))
                throw new Exception("No puede ser cancelada su orden de compra, pues ya expiro el tiempo permitido");
            double price = 0;
            int points = 0;
            int pointRest = 0;
            purchaseOrder.State = StatePurchaseOrder.canceled;
            foreach (Reservation reservation in purchaseOrder.Items)
            {
                pointRest += 5;
                _context.Items.Remove(reservation);
                if (!purchaseOrder.PaidByPoints)
                    price += reservation.Price;
                else
                    points += reservation.Points;
            }
            if (purchaseOrder.PaidByPoints && _context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
            {
                var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                currMember.Points += points;
                _context.ClubMembers.Update(currMember);
                _context.SaveChanges();
                return;
            }
            if (purchaseOrder.BoxOffice.Count() > 0)
            {
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Expense = price, Date = purchaseOrder.Date, Income = 0, PaymentMethod = PaymentMethod.efectivo, Description = purchaseOrder.BoxOffice });
                if(_context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
                {
                    var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                    currMember.Points -= pointRest;
                    _context.ClubMembers.Update(currMember);
                }
                _context.SaveChanges();

            }
            if (purchaseOrder.CredictCard.Count() == 8 && purchaseOrder.State == StatePurchaseOrder.completed)//Ver cantidad del números de una tarjeta
            {
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Expense = price, Date = purchaseOrder.Date, Income = 0, PaymentMethod = PaymentMethod.crédito, Description = purchaseOrder.CredictCard });
                if (_context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
                {
                    var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                    currMember.Points -= pointRest;
                    _context.ClubMembers.Update(currMember);
                }
                _context.SaveChanges();
                return;
            }

            throw new Exception("No es válida la orden de compra");
        }

        public void CheckPendingToCancel(Guid purchaseOrderId)
        {
            PurchaseOrder purchaseOrder = _context.PurchaseOrders.Include(c => c.Items).Include(c => c.User).SingleOrDefault(c => c.Id == purchaseOrderId);
            if (purchaseOrder.State == StatePurchaseOrder.pending)
                purchaseOrder.State = StatePurchaseOrder.canceled;
            foreach (Reservation reservation in purchaseOrder.Items)
            {
                _context.Items.Remove(reservation);
            }
            _context.SaveChanges();
        }

        public PurchaseOrder GetPurchaseOrder(Guid purchaseOrderId)
        {
            var purchaseOrder = _context.PurchaseOrders.Include(c => c.Items).Include(c => c.User).SingleOrDefault(c => c.Id == purchaseOrderId);
            if (purchaseOrder == null)
                throw new KeyNotFoundException("No se encuentra la orden de compra especificada");
            return purchaseOrder;
        }

        public List<PurchaseOrder> GetPurchaseOrders()
        {
            return _context.PurchaseOrders.Include(c => c.Items).Include(c => c.User).ToList();
        }

        public void PayPurchaseOrder(Guid purchaseOrderId)
        {
            var purchaseOrder = _context.PurchaseOrders.Include(c => c.Items).Include(c => c.User).SingleOrDefault(c => c.Id == purchaseOrderId);
            if (purchaseOrder == null)
                throw new KeyNotFoundException("No se encuentra la orden de compra especificada");
            if (!(purchaseOrder.State == StatePurchaseOrder.pending))
                throw new Exception("Ya esta orden de compra fue completada");
            double price = 0;
            int pointAdd = 0;
            purchaseOrder.State = StatePurchaseOrder.canceled;
            foreach (Reservation reservation in purchaseOrder.Items)
            {
                if (!_context.Reservations.Any(c => c.Id == reservation.Id))
                {
                    _context.Reservations.Add(reservation);
                }   
                pointAdd += 5;
                price += reservation.Price;    
            }
            if (purchaseOrder.CredictCard.Count() == 8)//Ver cantidad del números de una tarjeta
            {
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Expense = 0, Date = purchaseOrder.Date, Income = price, PaymentMethod = PaymentMethod.crédito, Description = purchaseOrder.CredictCard });
                if (_context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
                {
                    var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                    currMember.Points += pointAdd;
                    _context.ClubMembers.Update(currMember);
                }
                _context.SaveChanges();
                return;
            }
            throw new Exception("No es válida la orden de compra");
        }

        public void RemoveItems(Guid purchaseOrderId, List<Item> items)
        {
            var purchaseOrder = _context.PurchaseOrders.Include(c => c.Items).Include(c => c.User).SingleOrDefault(c => c.Id == purchaseOrderId);
            if (purchaseOrder == null)
                throw new KeyNotFoundException("No se encuentra la orden de compra especificada");
            double price = 0;
            int points = 0;
            int pointsRest = 0;
            foreach(Reservation reservation in items)
            {
                pointsRest += 5;
                bool del = purchaseOrder.Items.Remove(reservation);
                if (!del)
                {
                    throw new Exception($"El item con ID = {reservation.Id} no es válido");
                }
                if (!purchaseOrder.PaidByPoints)
                    price += reservation.Price;
                else
                    points += reservation.Points;
            }
            if (purchaseOrder.PaidByPoints && _context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
            {
                var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                currMember.Points += points;
                _context.ClubMembers.Update(currMember);
                _context.SaveChanges();
                return;
            }
            if (purchaseOrder.BoxOffice.Count() > 0)
            {
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Expense = price, Date = purchaseOrder.Date, Income = 0, PaymentMethod = PaymentMethod.efectivo, Description = purchaseOrder.BoxOffice });
                if (_context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
                {
                    var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                    currMember.Points -= pointsRest;
                    _context.ClubMembers.Update(currMember);
                }
                _context.SaveChanges();

            }
            if (purchaseOrder.CredictCard.Count() == 8)//Ver cantidad del números de una tarjeta
            {
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Expense = price, Date = purchaseOrder.Date, Income = 0, PaymentMethod = PaymentMethod.crédito, Description = purchaseOrder.CredictCard });
                if (_context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
                {
                    var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                    currMember.Points -= pointsRest;
                    _context.ClubMembers.Update(currMember);
                }
                _context.SaveChanges();
                return;
            }

            throw new Exception("No es válida la orden de compra");

        }

        bool CanCancel(DateTime date, string time)
        {
            DateTime today = DateTime.Today;
            if (date > today.Date)
                return true;
            int timeHour = int.Parse(time.Split(":")[0]) + ((time.Split(":")[1].Split()[1] == "PM") ? 12 : 0);
            int timeMin = int.Parse(time.Split(":")[1].Split()[0]);
            int difHour = timeHour - today.Hour;
            int difMin = timeMin - today.Minute;
            if (difHour > 2)
            {
                return true;
            }
            if (difHour == 2 && difMin > 0)
            {
                return true;
            }
            return false;
            
        }
    }
}
    