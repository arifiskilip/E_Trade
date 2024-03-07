namespace E_Trade.Entities
{
	public class Address : BaseEntity
	{
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public City City { get; set; }
        public District District { get; set; }
    }
}
