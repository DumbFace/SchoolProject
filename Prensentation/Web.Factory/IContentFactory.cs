using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;

namespace Web.Factory
{
    public interface IContentFactory
    {
        IEnumerable<Article> GetArticles(int page = 10,int pageSize = 10);
        Article GetArticleById(int id);
    }
}