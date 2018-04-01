using System.Collections.Generic;
using System.Linq;

namespace TheShop
{
    public static class ArticleEnumerableExtensions
    {
        public static IEnumerable<Article> WithId(this IEnumerable<Article> query, int id)
        {
            return query.Where(x => x.Id == id);
        }

        public static IEnumerable<Article> NotSold(this IEnumerable<Article> query)
        {
            return query.Where(x => !x.IsSold);
        }

        public static IEnumerable<Article> WithMaxPrice(this IEnumerable<Article> query, int price)
        {
            return query.Where(x => x.ArticlePrice <= price);
        }

        public static IEnumerable<Article> OrderByPrice(this IEnumerable<Article> query)
        {
            return query.OrderBy(x => x.ArticlePrice);
        }
    }
}
