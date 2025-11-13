namespace Generic_collections___Labb_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var restaurant = new Restaurant();
            var menu1 = new MenuItem(1, "Shawarmarulle", 120);
            var menu2 = new MenuItem(2, "Falafelrulle", 100);
            var menu3 = new MenuItem(3, "Kebabtallrik", 130);
            var menu4 = new MenuItem(4, "Falafeltallrik", 110);

            restaurant.AddToMenu(menu1);
            restaurant.AddToMenu(menu2);
            restaurant.AddToMenu(menu3);
            restaurant.AddToMenu(menu4);

            restaurant.ShowMenu();


            List<MenuItem> orderList = new List<MenuItem>() { menu1, menu2, menu3 };
            List < MenuItem > orderList2 = new List<MenuItem>() { menu1, menu2 };
            var order1 = new Order(orderList, 3);
            var order2 = new Order(orderList2, 5);
            restaurant.CreateOrder(order1);
            restaurant.CreateOrder(order2);

            order1.ShowOneOrder();
            order2.ShowOneOrder();
        }
    }
}
