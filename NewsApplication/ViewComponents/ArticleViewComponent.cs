using Microsoft.AspNetCore.Mvc;
using News.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Article article)
        {
            return await Task.FromResult<IViewComponentResult>(View(article));
        }

    }
}
