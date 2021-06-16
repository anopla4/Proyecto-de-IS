using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Cine__backend.Context;

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

            if (purchaseOrder.BoxOffice != null)
            {
                double? income = 0;
                int pointsAdd = 0;
                purchaseOrder.State = StatePurchaseOrder.completed;

                foreach(Reservation reservation in purchaseOrder.Items)
                {
                    pointsAdd += 5;
                    reservation.Id = Guid.NewGuid();
                    _context.Items.Add(reservation);
                    income += (double)reservation.Price;
                }
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Income = (double)income, Date = purchaseOrder.Date, Expense = 0, PaymentMethod = PaymentMethod.efectivo, Description = purchaseOrder.BoxOffice });
                if (_context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
                {
                    var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                    currMember.Points += pointsAdd;
                    _context.ClubMembers.Update(currMember);
                }
                _context.PurchaseOrders.Add(purchaseOrder);
                _context.SaveChanges();
                return purchaseOrder;
            }
            if (purchaseOrder.PaidByPoints)
            {
                if (!_context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
                    throw new Exception("El usuario no está autorizado a pagar por puntos. Regístrese como ClubMember para acceder a esta opción.");
                int? points = 0;
                purchaseOrder.State = StatePurchaseOrder.completed;
                foreach (Reservation reservation in purchaseOrder.Items)
                {
                    reservation.Id = Guid.NewGuid();
                    _context.Reservations.Add(reservation);
                    points += reservation.Points;
                }
                if(points > _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId).Points)
                        throw new Exception("No tiene los puntos necesarios para pagar esta orden de compra.");
                var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                currMember.Points -= (int)points;
                _context.PurchaseOrders.Add(purchaseOrder);
                _context.ClubMembers.Update(currMember);
                _context.SaveChanges();
                return purchaseOrder;
            }
            purchaseOrder.State = StatePurchaseOrder.pending;

            foreach (Reservation reservation in purchaseOrder.Items)
            {
                reservation.Id = Guid.NewGuid();
                _context.Reservations.Add(reservation);
            }
            _context.PurchaseOrders.Add(purchaseOrder);
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
            _context.PurchaseOrders.Update(purchaseOrder);
            foreach (Reservation reservation in purchaseOrder.Items)
            {
                pointRest += 5;
                _context.Items.Remove(reservation);
                if (!purchaseOrder.PaidByPoints)
                    price += (double)reservation.Price;
                else
                    points += (int)reservation.Points;
            }
            if (purchaseOrder.PaidByPoints && _context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
            {
                var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                currMember.Points += points;
                _context.ClubMembers.Update(currMember);
                _context.SaveChanges();
                return;
            }
            if (purchaseOrder.BoxOffice != null && purchaseOrder.BoxOffice.Count() > 0)
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
            if (purchaseOrder.CreditCard != null && purchaseOrder.CreditCard.Count() == 19)
            {
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Expense = price, Date = purchaseOrder.Date, Income = 0, PaymentMethod = PaymentMethod.crédito, Description = purchaseOrder.CreditCard });
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
            if (purchaseOrder == null)
                throw new KeyNotFoundException("No se encuentra la orden de compra especificada");
            if (purchaseOrder.State == StatePurchaseOrder.pending)
                purchaseOrder.State = StatePurchaseOrder.canceled;
            foreach (Reservation reservation in purchaseOrder.Items)
            {
                _context.Items.Remove(reservation);
            }
            _context.SaveChanges();
        }

        public List<PurchaseOrder> GetPurchaseOrdersOfUser(string username)
        {
            var user = _context.Users.SingleOrDefault(c => c.UserName == username);
            if (user == null)
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            return _context.PurchaseOrders.Include(c => c.Items).ThenInclude(d => ((Reservation)d).FilmScreening).Include(c => c.Items).ThenInclude(d => ((Reservation)d).Seat).Where(c => c.UserId == user.Id).ToList();
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

        public void PayPurchaseOrder(Guid purchaseOrderId, string creditCard)
        {
            var purchaseOrder = _context.PurchaseOrders.Include(c => c.Items).Include(c => c.User).SingleOrDefault(c => c.Id == purchaseOrderId);
            purchaseOrder.CreditCard = creditCard;
            _context.PurchaseOrders.Update(purchaseOrder);
            if (purchaseOrder == null)
                throw new KeyNotFoundException("No se encuentra la orden de compra especificada");
            if (!(purchaseOrder.State == StatePurchaseOrder.pending))
                throw new Exception("Ya esta orden de compra fue completada");
            double price = 0;
            int pointAdd = 0;
            purchaseOrder.State = StatePurchaseOrder.completed;
            foreach (Reservation reservation in purchaseOrder.Items)
            {
                if (!_context.Reservations.Any(c => c.Id == reservation.Id))
                {
                    _context.Reservations.Add(reservation);
                }   
                pointAdd += 5;
                price += (double)reservation.Price;    
            }
            if (purchaseOrder.CreditCard.Count() == 19)//Ver cantidad del números de una tarjeta
            {
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Expense = 0, Date = purchaseOrder.Date, Income = price, PaymentMethod = PaymentMethod.crédito, Description = purchaseOrder.CreditCard });
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

        public void RemoveItems(Guid purchaseOrderId, List<Guid> itemsIds)
        {
            var purchaseOrder = _context.PurchaseOrders.Include(c => c.Items).Include(c => c.User).SingleOrDefault(c => c.Id == purchaseOrderId);
            if (purchaseOrder == null)
                throw new KeyNotFoundException("No se encuentra la orden de compra especificada");
            List<Reservation> items = new List<Reservation>();
            foreach(var itemId in itemsIds)
            {
                var item = _context.Reservations.Find(itemId);
                if (item == null)
                    throw new KeyNotFoundException($"No se encuentra el item con id = {itemId}");
                items.Add(item);
            }
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
                    price += (double)reservation.Price;
                else
                    points += (int)reservation.Points;
            }
            _context.PurchaseOrders.Update(purchaseOrder);
            if (purchaseOrder.PaidByPoints && _context.ClubMembers.Any(c => c.UserId == purchaseOrder.UserId))
            {
                var currMember = _context.ClubMembers.SingleOrDefault(c => c.UserId == purchaseOrder.UserId);
                currMember.Points += (int)points;
                _context.ClubMembers.Update(currMember);
                _context.SaveChanges();
                return;
            }
            if (purchaseOrder.BoxOffice != null && purchaseOrder.BoxOffice.Count() > 0)
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
            if (purchaseOrder.CreditCard != null && purchaseOrder.CreditCard.Count() == 19)//Ver cantidad del números de una tarjeta
            {
                _context.BookEntries.Add(new BookEntry { Id = Guid.NewGuid(), Expense = price, Date = purchaseOrder.Date, Income = 0, PaymentMethod = PaymentMethod.crédito, Description = purchaseOrder.CreditCard });
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
            DateTime today = DateTime.Now;

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
    