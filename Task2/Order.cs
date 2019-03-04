using System;

namespace Task2
{
    using System.Collections.Generic;
    using System.Linq;

    public class Order
    {
        private readonly List<OrderItem> _orderItems;

        public List<OrderItem> OrderItems
        {
            get => this._orderItems;

            set
            {
                this._orderItems.Clear();
                this._orderItems.AddRange(value);
            }
        }

        public Order(List<OrderItem> orderItems)
        {
            this._orderItems = new List<OrderItem>(orderItems.Count);
            this.OrderItems = orderItems;
        }
    }
}
