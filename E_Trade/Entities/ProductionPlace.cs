using System;

namespace E_Trade.Entities
{
	public class ProductionPlace : BaseEntity
	{
        public int CountryId { get; set; }
        public DateTime ProductionDate { get; set; }


        public Feature Feature { get; set; }
        public Country Country { get; set; }
    }
}
