using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;

namespace TheShop.Tests
{
    public class ShopFixture
    {
        [Test]
        public void SellArticle()
        {
            var buyerId = 10;
            var article = new ArticleBuilder().Build();
            article.SellArticle(buyerId);

            Assert.AreEqual(article.IsSold, true);
            Assert.AreEqual(article.BuyerUserId, buyerId);
            Assert.AreNotEqual(article.SoldDate, DateTime.MinValue);
        }

        [Test]
        [TestCase(1, 3)]
        [TestCase(2, 1)]
        public void FindArticlesWithId(int id, int expectedCount)
        {
            var articles = GetArticleTestData();
            var articlesWithId = articles.WithId(id);
            Assert.AreEqual(articlesWithId.Count(), expectedCount);
        }

        [Test]
        [TestCase(3)]
        public void FindArticlesThatAreNotSold(int expectedCount)
        {
            var articles = GetArticleTestData();
            var articlesWithId = articles.NotSold();
            Assert.AreEqual(articlesWithId.Count(), expectedCount);
        }

        [Test]
        [TestCase(30, 2)]
        [TestCase(50, 3)]
        [TestCase(20, 0)]
        public void FindArticlesThatHaveMaxPrice(int maxPrice, int expectedCount)
        {
            var articles = GetArticleTestData();
            var articlesWithId = articles.WithMaxPrice(maxPrice);
            Assert.AreEqual(articlesWithId.Count(), expectedCount);
        }

        private IEnumerable<Article> GetArticleTestData()
        {
            return new Collection<Article>
            {
                new ArticleBuilder().IsSold(false).WithId(1).WithPrice(50).Build(),
                new ArticleBuilder().IsSold(false).WithId(1).WithPrice(60).Build(),
                new ArticleBuilder().IsSold(true).WithId(1).WithPrice(30).Build(),
                new ArticleBuilder().IsSold(false).WithId(2).WithPrice(30).Build()
            };
        }
    }
}
