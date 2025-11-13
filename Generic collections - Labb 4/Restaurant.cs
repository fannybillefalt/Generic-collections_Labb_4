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
            Console.WriteLine("\n~~~~~~MENY~~~~~~");
            foreach (MenuItem menuItems in Menu)
            {
                Console.WriteLine($"{menuItems.Id}. {menuItems.ToString()}");
            }
            Console.WriteLine();
        }

        public void CreateOrder(Order orders)
        {
            OrderQueue.Enqueue(orders);
            int number = 0;
            foreach(var nr in OrderQueue)
            {
                number++;
            }
            
            Console.WriteLine($"Beställning nr {number} har lagts till");
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
