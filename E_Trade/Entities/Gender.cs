namespace E_Trade.Entities
{
	public class Gender : BaseEntity
	{
        public string Name { get; set; }

        public Customer Customer { get; set; }

    }
}
