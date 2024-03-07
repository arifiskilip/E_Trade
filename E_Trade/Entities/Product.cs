using System.Collections.Generic;

namespace E_Trade.Entities
{
	public class Product : BaseEntity
	{
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public int FeatureId { get; set; }
        public double AvarageRating { get; set; }


        public Feature Feature { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
		public ICollection<Basket> Baskets { get; set; }
		public ICollection<FavoriteProduct> FavoriteProducts { get; set; }
		public ICollection<OrderDetail> OrderDetails { get; set; }
	}
}
