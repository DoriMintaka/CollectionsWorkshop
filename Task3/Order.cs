namespace Task3
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Order
    {
        private readonly OrderItemCollection _orderItems = new OrderItemCollection();

        public OrderItemCollection OrderItems
        {
            get => this._orderItems;
        }
    }
}