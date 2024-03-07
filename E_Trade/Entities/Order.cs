using System;
using System.Collections.Generic;

namespace E_Trade.Entities
{
	public class Order : BaseEntity
	{
        public int AddressId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime ShippedDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int OrderStatusId { get; set; }
        public int CargoCompanyId { get; set; }
        public int PaymentTypeId { get; set; }


        public PaymentType PaymentType { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public CargoCompany CargoCompany { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
