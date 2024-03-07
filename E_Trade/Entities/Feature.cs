namespace E_Trade.Entities
{
	public class Feature : BaseEntity
	{
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public int ProductionPlaceId { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }



        public Product Product { get; set; }
        public Color Color { get; set; }
        public Brand Brand { get; set; }
        public ProductionPlace ProductionPlace { get; set; }
        public Category Category { get; set; }
        
    }
}
