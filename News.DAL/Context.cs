using News.DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace News.DAL
{
    public class Context
    {
        public List<Article> GetArticles(string filepath)
        {
            using (StreamReader file = File.OpenText(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Article> articles = (List<Article>)serializer.Deserialize(file, typeof(List<Article>));
                return articles;
            }
        }
    }
}
