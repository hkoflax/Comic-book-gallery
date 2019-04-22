using ComicBookgallery.Data;
using ComicBookgallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookgallery.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        private ComicBookRepository _comicBookRepository = null;
        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Index()
        {
            var comiBooks = _comicBookRepository.GetComicBooks();
            return View(comiBooks);
        }
        public ActionResult Detail(int? id)
        {
            if (id==null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
        }
    }
}