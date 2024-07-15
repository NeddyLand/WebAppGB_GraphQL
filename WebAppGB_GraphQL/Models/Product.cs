﻿namespace WebAppGB_GraphQL.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? ProductGroupID { get; set; }
        public virtual List<Storage> Storages { get; set; }
        public virtual ProductGroup? ProductGroup { get; set; }
    }
}
