using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            var orderItems = new OrderItem[]
            {
            new OrderItem(110072674, "Widget", 400, 45.17),
            new OrderItem(110072675, "Sprocket", 27, 5.3),
            new OrderItem(101030411, "Motor", 10, 237.5),
            new OrderItem(110072684, "Gear", 175, 5.17)
            };

            var order = new Order(orderItems);
            Display("Order #1", order);

            // TODO Replace with code that searches a list item in order.OrderItems. Use List<T> methods only.
            if (true)
            {
                Console.WriteLine("Order #1 doesn't have #111033401 item.\n");
            }

            var newOrderItems = new OrderItem[orderItems.Length + 2];
            Array.Copy(orderItems, 0, newOrderItems, 0, orderItems.Length);

            newOrderItems[orderItems.Length] = new OrderItem(111033401, "Nut", 10, .5);
            newOrderItems[orderItems.Length + 1] = new OrderItem(127700026, "Crank", 27, 5.98);

            order.OrderItems = newOrderItems;
            Display("Order #2", order);

            // TODO Replace with code that searches a list item in order.OrderItems. Use List<T> methods only.
            if (true)
            {
                Console.WriteLine("Order #2 has #127700026 item.");
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
