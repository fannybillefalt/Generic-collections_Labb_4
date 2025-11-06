using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collections___Labb_4
{
    internal class Restaurant
    {
        List<MenuItem> Menu = new List<MenuItem>();
        Queue<Order> OrderQueue = new Queue<Order>();

        public void AddToMenu(MenuItem menuItems)
        {
            Menu.Add(menuItems);
        }

        public void ShowMenu()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~MENY~~~~~~~~~~~~~~~~~");
            foreach (MenuItem menuItems in Menu)
            {
                Console.WriteLine($"{menuItems.Id} {menuItems.Name} {menuItems.Price}");
            }
        }

        public void CreateOrder(Order orders)
        {
            OrderQueue.Enqueue(orders);
        }

        public void HandleOrder()
        {
            OrderQueue.Dequeue();
        }

        public void ShowOrders()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ORDERKÖ~~~~~~~~~~~~~~~~~");
            foreach (var orders in OrderQueue)
            {
                orders.ShowOneOrder();
            }
        }

        public void ShowNextOrder()
        {
            OrderQueue.Peek();
        }
    }
}
