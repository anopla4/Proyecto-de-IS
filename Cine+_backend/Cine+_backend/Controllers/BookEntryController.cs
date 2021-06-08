using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookEntryController : ControllerBase
    {
        private IBookEntryRepository _bookEntryRep;
        public BookEntryController(IBookEntryRepository bookEntryRepository)
        {
            this._bookEntryRep = bookEntryRepository;
        }
        [HttpGet]
        public IActionResult GetBookEntrys()
        {
            return Ok(_bookEntryRep.GetBookEntries());
        }
        [HttpGet("{id}")]
        public IActionResult GetBookEntry(Guid id)
        {
            try
            {
                var bookEntry = _bookEntryRep.GetBookEntry(id);
                return Ok(bookEntry);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        public IActionResult AddBookEntry(BookEntry bookEntry)
        {
            try
            {
                bookEntry = _bookEntryRep.AddBookEntry(bookEntry);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + bookEntry.Id, bookEntry);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBookEntry(Guid id, BookEntry bookEntry)
        {
            try
            {
                _bookEntryRep.DeleteBookEntry(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPatch("{id}")]
        public IActionResult UpdateBookEntry(Guid id, BookEntry bookEntry)
        {
            try
            {
                bookEntry = _bookEntryRep.UpdateBookEntry(bookEntry);
                return Ok(bookEntry);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
