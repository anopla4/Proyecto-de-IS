using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cine__backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookEntryController : ControllerBase
    {
        private IBookEntryRepository _bookEntryRep;
        public BookEntryController(IBookEntryRepository bookEntryRepository)
        {
            this._bookEntryRep = bookEntryRepository;
        }
        
        [Authorize(Roles = "WebMaster, Accountant")]
        [HttpGet]
        public IActionResult GetBookEntrys()
        {
            return Ok(_bookEntryRep.GetBookEntries());
        }
        [Authorize(Roles = "WebMaster, Accountant")]
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
        
        [Authorize(Roles = "WebMaster, Accountant, Worker")]
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
        
        [Authorize(Roles = "WebMaster, Accountant")]
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
        
        [Authorize(Roles = "WebMaster, Accountant")]
        [HttpPatch("{bookEntryId}")]
        public IActionResult UpdateBookEntry(Guid bookEntryId, BookEntry bookEntry)
        {
            try
            {
                bookEntry.Id = bookEntryId;
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
