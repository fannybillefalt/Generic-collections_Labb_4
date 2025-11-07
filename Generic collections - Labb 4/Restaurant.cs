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
            Console.WriteLine($"{menuItems.Name} har lagts till i menyn.");
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
            Console.WriteLine($"En ny beställning har lagts till: {orders.ShowOneOrder}");
        }

        public void HandleOrder()
        {
            OrderQueue.Dequeue();
            Console.WriteLine($"Order {OrderQueue.Dequeue()} är färdig");
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
            OrderQueue.Peek().ShowOneOrder();
            Console.WriteLine($"Nästa order i kör är: ");
        }

        public void ShowOrderCount()
        {
            Console.WriteLine($"Antal beställningar: {OrderQueue.Count}"); 
        }
    }
}
