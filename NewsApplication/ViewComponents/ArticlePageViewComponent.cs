using Microsoft.AspNetCore.Mvc;
using News.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace News.Web.ViewComponents
{
    public class ArticlePageViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(List<Article> articles)
        {
            return await Task.FromResult<IViewComponentResult>(View(articles));
        }
    }
}
