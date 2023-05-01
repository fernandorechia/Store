using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.Manager
{
    internal class OrderManager
    {
        private List<Order> orders = new List<Order>();

        public List<Order> GetOrders()
        {
            return orders;
        }
        public void Add(Order order)
        {
            orders.Add(order);
        }
        public void Remove(Order order)
        {
            orders.Remove(order);
        }
    }
}
