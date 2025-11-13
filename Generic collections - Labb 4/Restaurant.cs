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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("~MENY~");
            Console.ResetColor();

            foreach (MenuItem menuItems in Menu)
            {
                Console.WriteLine($"{menuItems.Id}. {menuItems.ToString()}");
            }
        }

        internal void CreateOrder(Order orders)
        {
            OrderQueue.Enqueue(orders);
            Console.WriteLine($"Beställning nr {orders.OrderId} har lagts till");
        }

        internal void HandleOrder()
        {
            Order nextorder = OrderQueue.Dequeue();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Order {nextorder.OrderId} färdig.\n");
            Console.ResetColor();   
        }

        internal void ShowOrders()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Aktuella beställningar:");
            Console.ResetColor();

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
                string text = "Det finns inga väntande ordrar i kön just nu.";

                // Hämta alla tillgängliga färger i ConsoleColor
                ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

                int index = 0;
                int top = Console.CursorTop - 2; // raden där texten skrevs

                while (!Console.KeyAvailable)
                {
                    // Byt färg
                    Console.ForegroundColor = colors[index];

                    // Skriv om samma text på samma plats (utan att radera)
                    Console.SetCursorPosition(0, top);
                    Console.Write(text);

                    // Vänta lite innan nästa färg
                    Thread.Sleep(300);

                    // Nästa färg (loopa runt vid slutet)
                    index = (index + 1) % colors.Length;
                }                
            }


        }

        internal void ShowOrderCount()
        {
            if (OrderQueue.Count > 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Det är {OrderQueue.Count} ordrar i kön.\n");
                Console.ResetColor();
            }
            else if (OrderQueue.Count <= 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Det är {OrderQueue.Count} order i kön.\n");
                Console.ResetColor();
            }
        }
    }
}
