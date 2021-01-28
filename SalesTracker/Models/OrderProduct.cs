using System.ComponentModel.DataAnnotations.Schema;

namespace SalesTracker.Models
{
    public class OrderProduct
    {
        public int OrderProductId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}