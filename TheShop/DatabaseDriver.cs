using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TheShop
{
    public class DatabaseDriver
    {
        public IEnumerable<Article> Articles { get; private set; }

        public DatabaseDriver()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            Articles = new Collection<Article>
            {
                new Article
                {
                    Id = 1,
                    NameOfArticle = "Article from supplier1",
                    ArticlePrice = 458,
                    SupplierId = 1
                },
                new Article
                {
                    Id = 1,
                    NameOfArticle = "Article from supplier2",
                    ArticlePrice = 459,
                    SupplierId = 2
                },
                new Article
                {
                    Id = 1,
                    NameOfArticle = "Article from supplier3",
                    ArticlePrice = 460,
                    SupplierId = 3
                }
            };
        }
    }
}
