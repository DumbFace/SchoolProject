using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;

namespace Web.Factory
{
    public interface IContentFactory
    {
        IEnumerable<ArticleViewModel> GetSiteMap();
        IEnumerable<ArticleViewModel> GetArticles(CategoryEnum? type = null, int page = 10, int pageSize = 10);
        ArticleViewModel GetArticleById(int id);
    }
}