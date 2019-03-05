namespace Task3
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Order
    {
        private readonly KeyedCollection<int, OrderItem> _orderItems = new OrderItemCollection();

        public KeyedCollection<int, OrderItem> OrderItems
        {
            get => this._orderItems;
        }
    }
}