using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class BookEntryRepository : IBookEntryRepository
    {
        private AppDbContext _context;

        public BookEntryRepository(AppDbContext context)
        {
            this._context = context;
        }
        public BookEntry AddBookEntry(BookEntry bookEntry)
        {
            bookEntry.Id = Guid.NewGuid();
            _context.BookEntries.Add(bookEntry);
            _context.SaveChanges();
            return bookEntry;
        }

        public void DeleteBookEntry(Guid bookEntryId)
        {
            var bookEntry = _context.BookEntries.Find(bookEntryId);
            if (bookEntry == null)
            {
                throw new KeyNotFoundException("No se encuentra el registro especificado");
            }
            _context.BookEntries.Remove(bookEntry);
            _context.SaveChanges();
            return;
        }

        public IList<BookEntry> GetBookEntries()
        {
            return _context.BookEntries.ToList();
        }

        public BookEntry GetBookEntry(Guid bookEntryId)
        {
            var bookEntry = _context.BookEntries.Find(bookEntryId);
            if (bookEntry == null)
            {
                throw new KeyNotFoundException("No se encuentra el registro especificado");
            }
            return bookEntry;
        }

        public BookEntry UpdateBookEntry(BookEntry bookEntry)
        {
            var currBookEntry = _context.BookEntries.Find(bookEntry.Id);
            if (currBookEntry == null)
            {
                throw new KeyNotFoundException("No se encuentra el registro especificado");
            }
            currBookEntry.Date = bookEntry.Date;
            currBookEntry.Description = bookEntry.Description;
            currBookEntry.Expense = bookEntry.Expense;
            currBookEntry.Income = bookEntry.Income;
            currBookEntry.PaymentMethod = bookEntry.PaymentMethod;
            _context.BookEntries.Update(currBookEntry);
            _context.SaveChanges();
            return currBookEntry;
        }
    }
}
