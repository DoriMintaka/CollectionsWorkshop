namespace Task5
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Order
    {
        private readonly List<OrderItem> _orderItems = new List<OrderItem>();

        public IReadOnlyList<OrderItem> OrderItems => new ReadOnlyCollection<OrderItem>(this._orderItems);

        public void AddRange(IEnumerable<OrderItem> items)
        {
            this._orderItems.AddRange(items);
        }
    }
}
