using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CMS.Data.Service.ArticleService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Prensentation.Controllers
{
    public class ReadController : Controller
    {
        private readonly ILogger<ReadController> _logger;

        private readonly IArticleService _service;

        public ReadController(IArticleService service)
        {
            _service = service;
        }

        [Route("{url}-{id}.html")]
        public IActionResult Index(string url,int id)
        {
            var article = _service.GetById(id);
            return View(article);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}