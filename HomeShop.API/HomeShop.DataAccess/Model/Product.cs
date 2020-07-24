using System.Collections.Generic;

namespace HomeShop.DataAccess.Model
{
    public class Product
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public Brand Brand { get; set; }

        public int BrandId { get; set; }


    }
}