using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.Manager
{
    internal class OrderManager
    {
        private static List<Order> orders = new List<Order>();
        


        public static List<Order> GetOrders()
        {
            return orders;
        }
        public static void Add(Order order)
        {
            orders.Add(order);
        }
        public static void Remove(Order order)
        {
            orders.Remove(order);
        }

    }
}
