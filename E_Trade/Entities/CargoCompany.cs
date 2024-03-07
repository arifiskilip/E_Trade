namespace E_Trade.Entities
{
	public class CargoCompany : BaseEntity
	{
        public string Name { get; set; }

        public Order Order { get; set; }
    }
}
