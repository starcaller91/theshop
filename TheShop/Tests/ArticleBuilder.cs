using System;

namespace TheShop.Tests
{
    public class ArticleBuilder
    {
        private int _price = 0;
        private int _supplierId = 0;
        private int _buyerId = 0;
        private bool _isSold;
        private DateTime _soldDate = DateTime.MinValue;
        private int _id = 0;
        private string _name = "Some Name";

        public ArticleBuilder IsSold(bool isSold)
        {
            _isSold = isSold;
            return this;
        }


        public ArticleBuilder WithPrice(int price)
        {
            _price = price;
            return this;
        }

        public ArticleBuilder WithId(int id)
        {
            _id = id;
            return this;
        }
        public Article Build()
        {
            return new Article
            {
                ArticlePrice = _price,
                SupplierId = _supplierId,
                BuyerUserId = _buyerId,
                IsSold = _isSold,
                SoldDate = _soldDate,
                Id = _id,
                NameOfArticle = _name
            };
        }
    }
}
