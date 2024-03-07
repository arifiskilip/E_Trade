namespace E_Trade.Entities
{
	public class FavoriteProduct : BaseEntity
	{
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
