using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Data.Service.ArticleService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Prensentation.Areas.cp.Controllers
{
    [Area("cp")]
    // [Route("[controller]")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _service;

        private readonly ILogger<ArticleController> _logger;

        public ArticleController(ILogger<ArticleController> logger,
        IArticleService service
        )
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            Article article = new Article();
            return View(article);
        }

        public IActionResult Edit(int id)
        {
            var article = _service.GetById(id);
            return View(article);
        }


        public IActionResult GetList()
        {
            var lst = _service.GetAll();
            return View(lst);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Article obj)
        {
            obj.Url = myCommon.FriendlyUrl(obj.Title);
            obj.DateCreate = DateTime.Now;
            obj.DateModified = DateTime.Now;
            obj.DatePublish = DateTime.Now;
            _service.Insert(obj);
            _service.Save();
            return Ok("Saved!");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Article obj)
        {
            obj.DateModified = DateTime.Now;
            _service.Update(obj);
            _service.Save();
            return Ok("OK");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}