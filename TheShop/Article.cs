using System;

namespace TheShop
{
    public class Article
    {
        public int Id { get; set; }

        public string NameOfArticle { get; set; }

        public int ArticlePrice { get; set; }
        public bool IsSold { get; set; }

        public DateTime SoldDate { get; set; }
        public int BuyerUserId { get; set; }
        public int SupplierId { get; set; }

        public void SellArticle(int buyerId)
        {
            IsSold = true;
            BuyerUserId = buyerId;
            SoldDate = DateTime.Now;
        }
    }
}
