﻿namespace E_Trade.Entities
{
	public class OrderStatus : BaseEntity
	{
        public string Name { get; set; }

        public Order Order { get; set; }
    }
}
