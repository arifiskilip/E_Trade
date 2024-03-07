namespace E_Trade.Entities
{
	public class ProductImage : BaseEntity
	{
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }

        public Product Product { get; set; }
    }
}
