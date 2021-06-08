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
        [HttpGet("{bookEntryId}")]
        public IActionResult GetBookEntry(Guid bookEntryId)
        {
            try
            {
                var bookEntry = _bookEntryRep.GetBookEntry(bookEntryId);
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
        [HttpDelete("{bookEntryId}")]
        public IActionResult DeleteBookEntry(Guid bookEntryId)
        {
            try
            {
                _bookEntryRep.DeleteBookEntry(bookEntryId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPatch("{bookEntryId}")]
        public IActionResult UpdateBookEntry(Guid bookEntryId, BookEntry bookEntry)
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
