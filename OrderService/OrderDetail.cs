using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApp
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailId { get; set; }

        public int Index { get; set; }

        [Required]
        public virtual Product ProductItem { get; set; }

        [NotMapped]
        public string ProductName => ProductItem != null ? this.ProductItem.Name : "";

        [NotMapped]
        public double UnitPrice => ProductItem != null ? this.ProductItem.Price : 0.0;

        public int Quantity { get; set; }

        [NotMapped]
        public double TotalPrice => ProductItem == null ? 0.0 : ProductItem.Price * Quantity;

        public OrderDetail() { }

        public OrderDetail(int index, Product goods, int quantity)
        {
            this.Index = index;
            this.ProductItem = goods;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return $"[No.:{Index},product:{ProductName},quantity:{Quantity},totalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderDetail;
            return item != null &&
                   ProductName == item.ProductName;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + Index.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductName);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
    }
}
