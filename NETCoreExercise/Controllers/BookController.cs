using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCoreExercise.Core.Base;
using NETCoreExercise.Model.Base;
using NETCoreExercise.Model.Entity;

namespace NETCoreExercise.Controllers
{
    public class BookController : Controller
    {

        private DateBaseContext _context;
        public BookController(DateBaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _context.Set<BookEntity>().ToList().Select(b => new BookViewModel
            {
                Id = b.Id,
                Name = b.Name,
                ISBN = b.ISBN,
                Author = b.Author,
                Publisher = b.Publisher
            });
            return View("Index", model);
        }
        [HttpGet]
        public IActionResult AddEditBook(long? id)
        {
            BookViewModel model = new BookViewModel();
            if (id.HasValue)
            {
                Book book = context.Set<Book>().SingleOrDefault(c => c.Id == id.Value);
                if (book != null)
                {
                    model.Id = book.Id;
                    model.Name = book.Name;
                    model.ISBN = book.ISBN;
                    model.Author = book.Author;
                    model.Publisher = book.Publisher;
                }
            }
            return PartialView("~/Views/Book/_AddEditBook.cshtml", model);
        }
    }
}