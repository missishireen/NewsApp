using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using News.DAL;
using News.DAL.Models;

namespace News.Business
{
    public class ArticleRepository : IArticleRepository
    {
        private Context DataContext;

        public ArticleRepository(Context context)
        {
            DataContext = context;
        }

        public string FilePath { get ; set ; }

        public Article GetArticleById(int id)
        {
            return DataContext.GetArticles(FilePath).Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Article> GetArticles(int page, int pageSize)
        {
            return DataContext.GetArticles(FilePath).OrderByDescending(p => p.PublishedDate).Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
