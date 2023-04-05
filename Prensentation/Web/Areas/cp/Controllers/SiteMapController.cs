using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CMS.Core.Domain;
using CMS.Data.Service.ArticleService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Factory;

namespace Web.Areas.cp.Controllers
{
    [Area("cp")]
    public class SiteMapController : Controller
    {
        private readonly ILogger<SiteMapController> _logger;
        private readonly IContentFactory _content;
        public SiteMapController(
            ILogger<SiteMapController> logger,
            IContentFactory content
        )
        {
            _content = content;
            _logger = logger;
        }

        public IActionResult Index()
        {
            GenerateSitemap(_content.GetArticles());
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }


        public void GenerateSitemap(IEnumerable<Article> articles)
        {
            string strPhysical = CMS.Data.Helper.Constrants.RootPath+ "\\wwwroot" + "\\sitemap.xml";

            using (XmlTextWriter writer = new XmlTextWriter(strPhysical, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("urlset");
                writer.WriteAttributeString("xmlns", "http://www.sitemaps.org/schemas/sitemap/0.9");
                writer.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteAttributeString("xsi:schemaLocation", "http://www.sitemaps.org/schemas/sitemap/0.9 http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd");
                writer.WriteStartElement("url");
                writer.WriteElementString("loc", "https://phamphuongkhang.xyz/");
                writer.WriteElementString("lastmod", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:00+07:00"));
                writer.WriteElementString("changefreq", "hourly");
                writer.WriteElementString("priority", "1.0");
                writer.WriteEndElement(); // end of url

                foreach (Article item in articles)
                {
                    string DistributionDate = item.DatePublish.ToString("yyyy-MM-ddTHH:mm:00+07:00");
                    string strLink = "http://phamphuongkhang.xyz/" + item.Url + "-" + item.Id + ".html";
                    writer.WriteStartElement("url");
                    writer.WriteElementString("loc", strLink);
                    writer.WriteElementString("lastmod", DistributionDate);
                    writer.WriteElementString("changefreq", "hourly");
                    writer.WriteElementString("priority", "0.80");
                    writer.WriteEndElement();  //end url
                }

                writer.WriteEndElement(); // end of urlset
                writer.Close();

                // code to write the sitemap goes here
            }


        }
    }


}