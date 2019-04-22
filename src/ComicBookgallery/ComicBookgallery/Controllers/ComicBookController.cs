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
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing spider man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name="dan slott", Role="script"},
                    new Artist() {Name="humberto ramos", Role="pencils"},
                    new Artist() {Name="victor olazaba", Role="inks"},
                    new Artist() {Name="edgar delgado", Role="colors"},
                    new Artist() {Name="chris eliopoulos", Role="letters"},
                }
            };

            return View(comicBook);
        }
    }
}