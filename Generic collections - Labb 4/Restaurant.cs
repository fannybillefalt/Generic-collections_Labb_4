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

        internal void AddToMenu(MenuItem menuItems)
        {
            Menu.Add(menuItems);
            Console.WriteLine($"{menuItems.Name} har lagts till i menyn.");
        }

        internal void ShowMenu()
        {
            Console.WriteLine("~MENY~");
            foreach (MenuItem menuItems in Menu)
            {
                Console.WriteLine($"{menuItems.Id}. {menuItems.ToString()}");
            }
        }

        internal void CreateOrder(Order orders)
        {
            OrderQueue.Enqueue(orders);
            int number = 0;
            foreach(var nr in OrderQueue)
            {
                number++;
            }
            
            Console.WriteLine($"Beställning nr {number} har lagts till");
        }

        internal void HandleOrder()
        {
                Order nextorder = OrderQueue.Dequeue();
                Console.WriteLine($"Order {nextorder.OrderId} färdig");
        }

        internal void ShowOrders()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ORDERKÖ~~~~~~~~~~~~~~~~~");
            foreach (var orders in OrderQueue)
            {
                orders.ShowOneOrder(); 
            }
        }

        internal void ShowNextOrder()
        {
            if(OrderQueue.Count > 0)
            {
                Order nextorder = OrderQueue.Peek();

                Console.WriteLine($"Nästa order i kön:");
                nextorder.ShowOneOrder();
            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu.");
            }
        }

        internal void ShowOrderCount()
        {
            Console.WriteLine($"Det är {OrderQueue.Count} ordrar i kön"); 
        }
    }
}
