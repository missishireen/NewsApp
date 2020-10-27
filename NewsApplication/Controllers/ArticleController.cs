using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using News.Business;

namespace News.Web.Controllers
{
    public class ArticleController : Controller
    {
        private IArticleRepository ArticleRepository;
        private IWebHostEnvironment HostingEnvironment;

        public ArticleController(IArticleRepository articleRepository,IWebHostEnvironment webHostEnvironment)
        {
            ArticleRepository = articleRepository;
            HostingEnvironment = webHostEnvironment;
            //in an ideal situation this wouldn't be here, the DAL project will be responsible to get the data from database or any other source
            ArticleRepository.FilePath = Path.Combine(HostingEnvironment.WebRootPath, @"Data\data.json");
        }
        public IActionResult Index(int? page)
        {
            int pageSize = 5;
            if (!page.HasValue)
                page = 1;
            ViewBag.Page = page + 1;
            var model = ArticleRepository.GetArticles(page.Value, pageSize);
            return View(model);
        }
        public IActionResult LoadMore(int? page)
        {
            int pageSize = 5;
            var model = ArticleRepository.GetArticles(page.Value, pageSize);
            if (model.Count > 0)
            {
                return ViewComponent("ArticlePage", model);
            }
            else
            {
                return new NotFoundResult();
            }
        }
        public IActionResult Details(int Id)
        {
            var model = ArticleRepository.GetArticleById(Id);
            return View(model);
        }
    }
}