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

        public ArticleViewModel GetArticleById(int id)
        {
            Article article = _repoArticle.GetById(id);
            ArticleViewModel articleViewModel = new ArticleViewModel();
            HelpingMapper.Mapper(articleViewModel, article);
            return articleViewModel;
        }

        public IEnumerable<ArticleViewModel> GetArticles(CategoryEnum? Type = null, int page = 1, int pageSize = 10)
        {
            var data = (from article in _repoArticle.GetAll()
                        where article.Status == StatusCode.Public && article.IsDelete == false
                        orderby article.DatePublish descending
                        select new ArticleViewModel
                        {
                            Id = article.Id,
                            Title = article.Title,
                            Description = article.Description,
                            Category = article.Category,
                            Content = article.Content,
                            Url = article.Url,
                            DatePublish = article.DatePublish
                        });

            if (Type != null)
            {
                data.Where(x => x.Category == Type);
            }
            return data;
        }

        public IEnumerable<ArticleViewModel> GetSiteMap()
        {
            return (
                from article in _repoArticle.GetAll()
                where article.Status == StatusCode.Public && article.IsDelete == false
                orderby article.DatePublish descending
                select new ArticleViewModel
                {
                    Id = article.Id,
                    Url = article.Url,
                    DatePublish = article.DatePublish                    
                }
             );
        }
    }
    public static class HelpingMapper
    {
        public static void Mapper(ArticleViewModel des, Article src)
        {
            des.Id = src.Id;
            des.Title = src.Title;
            des.Description = src.Description;
            des.Content = src.Content;
            des.Thumb = src.Thumb;
            des.Category = src.Category;
            des.Url = src.Url;
            des.Category = src.Category;
            des.DatePublish = src.DatePublish;
        }
    }
}