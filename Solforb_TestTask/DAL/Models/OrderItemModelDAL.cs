﻿namespace Solforb_TestTask.DAL.Models
{
    public class OrderItemModelDAL
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Unit;
    }
}
