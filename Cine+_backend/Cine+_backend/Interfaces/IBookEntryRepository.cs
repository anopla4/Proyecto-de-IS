using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IBookEntryRepository
    {
        public BookEntry GetBookEntry(Guid bookEntryId);
        public IList<BookEntry> GetBookEntries();
        public BookEntry AddBookEntry(BookEntry bookEntry);
        public BookEntry UpdateBookEntry(BookEntry bookEntry);
        public void DeleteBookEntry(Guid bookEntryId);

    }
}
