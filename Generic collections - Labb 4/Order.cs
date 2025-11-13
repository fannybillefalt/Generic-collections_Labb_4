using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collections___Labb_4
{
    internal class Order
    {
        // I denna klass använder vi i stället private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public void ShowOneOrder()
        {
            decimal price = 0;
            Console.WriteLine($"Order {_orderId}");
            foreach (var order in _orderItems)
            {
                Console.WriteLine($"1 {order.Name} ");
                price += order.Price;
            }
            Console.WriteLine($"Summa: {price} kr");
        }
    }
}
