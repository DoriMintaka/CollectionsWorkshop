using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Program
    {
        public static void Main()
        {
            var order = new Order();

            order.AddRange(
                new[]
                    {
                        new OrderItem(110072674, "Widget", 400, 45.17), new OrderItem(110072675, "Sprocket", 27, 5.3),
                        new OrderItem(101030411, "Motor", 10, 237.5), new OrderItem(110072684, "Gear", 175, 5.17)
                    });

            Display("Order #1", order);

            OrderItem orderItem = null;

            foreach (var item in order.OrderItems)
            {
                if (item.PartNumber == 111033401)
                {
                    orderItem = item;
                    break;
                }
            }

            if (orderItem == null)
            {
                Console.WriteLine("Order #1 doesn't have #111033401 item.\n");
            }

            order.AddRange(
                new[] { new OrderItem(111033401, "Nut", 10, .5), new OrderItem(127700026, "Crank", 27, 5.98) });

            Display("Order #2", order);

            foreach (var item in order.OrderItems)
            {
                if (item.PartNumber == 127700026)
                {
                    orderItem = item;
                    break;
                }
            }

            if (orderItem != null)
            {
                Console.WriteLine("Order #2 has #127700026 item - price is {0:###,###.00}$.", orderItem.UnitPrice * orderItem.Quantity);
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
