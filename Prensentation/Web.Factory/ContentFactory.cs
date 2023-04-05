using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Data.EFCore;

namespace Web.Factory
{
    public class ContentFactory : IContentFactory
    {
        private readonly IRepository<Article> _repoArticle;
        private readonly IRepository<Category> _repoCategory;
        public ContentFactory(
            IRepository<Article> repoArticle,
            IRepository<Category> repoCategory

        )
        {
            _repoArticle = repoArticle;
            _repoCategory = repoCategory;
        }

        public Article GetArticleById(int id)
        {
            return _repoArticle.GetById(id);
        }

        public IEnumerable<Article> GetArticles(int page = 1, int pageSize = 10)
        {
            return _repoArticle.GetAll().Where(x => x.Status == StatusCode.Public && x.IsDelete == false).OrderByDescending(x => x.DatePublish);
        }

    }
}