namespace E_Trade.Entities
{
	public class Comment : BaseEntity
	{
        public int ProductId { get; set; }
        public double Rating { get; set; }
        public string CommentText { get; set; }
        public int CustomerId { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
