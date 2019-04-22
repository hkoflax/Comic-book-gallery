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
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool favorite { get; set; }

        public string Displaytext
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }
        //series-title-issueNumber.jpg
        public string CoverImagefileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}