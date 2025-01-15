﻿using BookFinder.Interfaces;
using BookFinder.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookFinder.Controllers
{
    public class BooksController : Controller
    {

        public IGoogleBooksService _bookService { get; set; }
        public BooksController(IGoogleBooksService bookService) {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Search");
        }

        public async Task<IActionResult> Search(string BookTitle, int? StartIndex=0)
        {
            string searchString = $"{BookTitle}&startIndex={StartIndex}";
            BookList response;
            try
            {
                response = await _bookService.GetBooks(searchString);
            }
            catch (Exception ex) {
                ErrorViewModel erro = new ErrorViewModel { RequestId = "400" };
                return View("Error", erro);            
            }

            ViewData["BookTitle"] = BookTitle;
            ViewData["startIndex"] = StartIndex;
            return View(response);

        }

        public async Task<IActionResult> bookDetails(string id)
        {
            Book response = await _bookService.GetBook(id);
            return View(response);
        }
    }
}
