using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Web.Factory;
using Web.Models;

namespace Web.ViewComponents
{
    public class ListViewComponent : ViewComponent
    {
        private readonly IContentFactory _content;
        public ListViewComponent(IContentFactory content)
        {
            _content = content;
        }

        public async Task<IViewComponentResult> InvokeAsync(ListViewModel model)
        {
            IEnumerable<ArticleViewModel> data = null;
            switch (model.Type)
            {
                case ListView.Home:
                    data = _content.GetArticlesPaging(null, model.Page, model.PageSize);
                    break;
                case ListView.Trick:
                    data = _content.GetArticlesPaging(CategoryEnum.Trick, model.Page, model.PageSize);
                    break;
                case ListView.DesignPattern:
                    data = _content.GetArticlesPaging(CategoryEnum.DesignPattern, model.Page, model.PageSize);
                    break;
            }
            return View(data);
        }
    }
}