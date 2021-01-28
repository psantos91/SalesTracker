using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    public class Product
    {
        //PROPERTIES
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int IVA { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();


        //CONSTRUCTORS
        public Product() { }

        public Product(int productId, string name, string category, double price, int iva)
        {
            ProductId = productId;
            Name = name;
            Category = category;
            Price = price;
            IVA = iva;
        }


        ////METHODS
        //public void AddProduct(Product pr)
        //{
        //    Products.Add(pr);
        //}

        //public void RemoveProduct(Product pr)
        //{
        //    Products.Remove(pr);
        //}
    }
}
