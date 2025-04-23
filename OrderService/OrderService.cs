using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{
    public class OrderService
    {
        private readonly OrderContext _context;

        public OrderService()
        {
            _context = new OrderContext();
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Details.Select(d => d.ProductItem))
                .ToList();
        }

        public Order GetOrder(int id)
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Details.Select(d => d.ProductItem))
                .FirstOrDefault(o => o.OrderId == id);
        }

        public void AddOrder(Order order)
        {
            if (_context.Orders.Any(o => o.OrderId == order.OrderId))
                throw new ApplicationException($"添加错误: 订单{order.OrderId} 已经存在了!");

            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void RemoveOrder(int orderId)
        {
            var order = GetOrder(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public List<Order> QueryOrdersByProductName(string productName)
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Details.Select(d => d.ProductItem))
                .Where(order => order.Details.Any(item => item.ProductItem.Name == productName))
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Details.Select(d => d.ProductItem))
                .Where(order => order.Customer.Name == customerName)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        public void UpdateOrder(Order newOrder)
        {
            var oldOrder = GetOrder(newOrder.OrderId);
            if (oldOrder == null)
                throw new ApplicationException($"修改错误：订单 {newOrder.OrderId} 不存在!");

            _context.Entry(oldOrder).CurrentValues.SetValues(newOrder);

            // 更新明细
            foreach (var detail in newOrder.Details)
            {
                var existingDetail = oldOrder.Details.FirstOrDefault(d => d.OrderDetailId == detail.OrderDetailId);
                if (existingDetail != null)
                {
                    _context.Entry(existingDetail).CurrentValues.SetValues(detail);
                }
                else
                {
                    oldOrder.Details.Add(detail);
                }
            }

            // 删除不再存在的明细
            foreach (var detail in oldOrder.Details.ToList())
            {
                if (!newOrder.Details.Any(d => d.OrderDetailId == detail.OrderDetailId))
                {
                    _context.OrderDetails.Remove(detail);
                }
            }

            _context.SaveChanges();
        }

        public List<Order> QueryByTotalAmount(float amount)
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Details.Select(d => d.ProductItem))
                .Where(order => order.Details.Sum(d => d.Quantity * d.ProductItem.Price) >= amount)
                .OrderByDescending(o => o.Details.Sum(d => d.Quantity * d.ProductItem.Price))
                .ToList();
        }

        public void Export(String fileName)
        {
            // 可以保留XML导出功能，或改为数据库备份
            // 这里保留原有实现
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, GetAllOrders());
            }
        }

        public void Import(string path)
        {
            // 可以保留XML导入功能，或改为数据库恢复
            // 这里保留原有实现
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!_context.Orders.Any(o => o.OrderId == order.OrderId))
                    {
                        _context.Orders.Add(order);
                    }
                });
                _context.SaveChanges();
            }
        }
    }
}
