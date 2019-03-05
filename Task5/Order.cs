namespace Task5
{
    using System.Collections.Generic;
    using System.Linq;

    public class Order
    {
        private readonly Dictionary<int, OrderItem> _orderItems = new Dictionary<int, OrderItem>();

        public Dictionary<int, OrderItem> OrderItems
        {
            get
            {
                return this._orderItems;
            }
        }

        public void AddRange(IEnumerable<OrderItem> items)
        {
            foreach (var item in items)
            {
                this._orderItems.Add(item.PartNumber, item);
            }
        }

        public OrderItem FindByPartNumber(int partNumber)
        {
            OrderItem resultItem;
            if (this.OrderItems.TryGetValue(partNumber, out resultItem))
            {
                return resultItem;
            }

            return null;
        }

        public OrderItem FindByDescription(string description)
        {
            foreach (var item in this._orderItems.Values)
            {
                if (item.Description == description)
                {
                    return item;
                }
            }

            return null;
        }
    }
}