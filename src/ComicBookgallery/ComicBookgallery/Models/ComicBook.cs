using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookgallery.Models
{
    public class ComicBook
    {
        public int id { get; set; }
        public string SeriesTitle { get; set; }
        public int issueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool favorite { get; set; }
    }
}