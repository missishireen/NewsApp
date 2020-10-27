using System;
using System.Collections.Generic;
using System.Text;

namespace News.DAL.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string[] Keywords { get; set; }
    }
}
