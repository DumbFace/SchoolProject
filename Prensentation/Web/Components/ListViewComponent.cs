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
                    data = _content.GetArticles();
                    break;
                case ListView.Trick:
                    data = _content.GetArticles(CategoryEnum.Trick);
                    break;
            }
            return View(data);
        }
    }
}