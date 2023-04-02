using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prensentation.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string UrlToImage { get; set; }
    }
}