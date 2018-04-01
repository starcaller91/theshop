using System;
using System.Linq;

namespace TheShop
{
	internal class Program
	{
	    private static readonly DatabaseDriver DatabaseDriver = new DatabaseDriver();
	    private static readonly Logger Logger = new Logger();

        private static void Main(string[] args)
		{
            try
			{
                SellArticle(1, 20, 10);
                SellArticle(1, 600, 10);
                SellArticle(1, 458, 10);
			    SellArticle(2, 460, 10);
                SellArticle(1, 460, 10);
                SellArticle(1, 460, 10);
			}
			catch (Exception ex)
			{
				Logger.Error(ex.Message);
			}

			Console.ReadKey();
		}

	    private static void SellArticle(int id, int maxPrice, int buyerId)
	    {
	        Logger.Info($"Trying to sell article with id:{id}");
            var articles = DatabaseDriver.Articles
	            .WithId(id)
                .NotSold()
	            .WithMaxPrice(maxPrice)
	            .OrderByPrice()
	            .ToList();

	        if (articles.Any())
	        {
	            var article = articles.First();
                article.SellArticle(buyerId);
                Logger.Info($"Article with id:{article.Id} sold for {article.ArticlePrice}");
	        }
	        else
	        {
                Logger.Info("No articles were found.");
	        }
        }
	}
}