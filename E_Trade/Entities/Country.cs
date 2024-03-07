namespace E_Trade.Entities
{
	public class Country : BaseEntity
	{
        public string Name { get; set; }

        public ProductionPlace ProductionPlace { get; set; }
    }
}
