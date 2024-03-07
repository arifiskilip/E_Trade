namespace E_Trade.Entities
{
	public class PaymentType : BaseEntity
	{
        public string Type { get; set; }


        public Order Order { get; set; }
    }
}
