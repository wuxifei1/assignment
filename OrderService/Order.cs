using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace OrderApp
{
    public class Order : IComparable<Order>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        public virtual Customer Customer { get; set; }

        [NotMapped]
        public string CustomerName => (Customer != null) ? Customer.Name : "";

        public DateTime CreateTime { get; set; }

        public virtual List<OrderDetail> Details { get; set; } = new List<OrderDetail>();

        [NotMapped]
        public double TotalPrice => Details.Sum(item => item.TotalPrice);

        public Order()
        {
            CreateTime = DateTime.Now;
            Details = new List<OrderDetail>();
        }

        public Order(int orderId, Customer customer, List<OrderDetail> items)
        {
            this.OrderId = orderId;
            this.Customer = customer;
            this.CreateTime = DateTime.Now;
            this.Details = (items == null) ? new List<OrderDetail>() : items;
        }

        public void AddDetail(OrderDetail orderItem)
        {
            if (Details.Any(d => d.Equals(orderItem)))
                throw new ApplicationException($"添加错误：订单项{orderItem.ProductName} 已经存在!");
            Details.Add(orderItem);
        }

        public void RemoveDetail(OrderDetail orderItem)
        {
            Details.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Id:{OrderId}, customer:{Customer},orderTime:{CreateTime},totalPrice：{TotalPrice}");
            Details.ForEach(od => strBuilder.Append("\n\t" + od));
            return strBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            var hashCode = -531220479;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerName);
            hashCode = hashCode * -1521134295 + CreateTime.GetHashCode();
            return hashCode;
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderId.CompareTo(other.OrderId);
        }
    }
}
