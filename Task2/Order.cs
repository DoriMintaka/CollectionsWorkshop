using System;

namespace Task2
{
    public class Order
    {
        private OrderItem[] _orderItems;

        public OrderItem[] OrderItems
        {
            get
            {
                return _orderItems;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                this._orderItems = value;
            }
        }

        public Order(OrderItem[] orderItems)
        {
            this.OrderItems = orderItems;
        }
    }
}
