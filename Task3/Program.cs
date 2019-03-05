using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var order = new Order();

            order.OrderItems.Add(new OrderItem(110072674, "Widget", 400, 45.17));
            order.OrderItems.Add(new OrderItem(110072675, "Sprocket", 27, 5.3));
            order.OrderItems.Add(new OrderItem(101030411, "Motor", 10, 237.5));
            order.OrderItems.Add(new OrderItem(110072684, "Gear", 175, 5.17));

            Display("Order #1", order);

            OrderItem orderItem = null;

            if (!order.OrderItems.Contains(111033401))
            {
                Console.WriteLine($"Order #1 doesn't have #111033401 item.\n");
            }

            order.OrderItems.Add(new OrderItem(111033401, "Nut", 10, .5));
            order.OrderItems.Add(new OrderItem(127700026, "Crank", 27, 5.98));

            Display("Order #2", order);

            if (order.OrderItems.Contains(127700026))
            {
                orderItem = order.OrderItems[127700026];
                Console.WriteLine("Order #2 has #127700026 item - price is {0}$.", orderItem.UnitPrice * orderItem.Quantity);
            }
        }

        private static void Display(string title, Order order)
        {
            Console.WriteLine(title);
            foreach (OrderItem item in order.OrderItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
