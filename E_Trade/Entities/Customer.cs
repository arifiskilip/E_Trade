using System.Collections.Generic;

namespace E_Trade.Entities
{
	public class Customer : BaseEntity
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public string SecurityStamp { get; set; }
        public int GenderId { get; set; }

        public Gender Gender { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Basket> Baskets { get; set; }
        public ICollection<FavoriteProduct> FavoriteProducts { get; set; }
    }
}
