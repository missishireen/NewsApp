using News.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Business
{
   public interface IArticleRepository
    {
        List<Article> GetArticles(int page, int pageSize);
        Article GetArticleById(int id);
        string FilePath { get; set; }
    }
}
