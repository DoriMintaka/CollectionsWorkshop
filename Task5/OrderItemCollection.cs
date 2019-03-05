namespace Task5
{
    using System.Collections.ObjectModel;

    public class OrderItemCollection : KeyedCollection<int, OrderItem>
    {
        protected override int GetKeyForItem(OrderItem item)
        {
            return item.PartNumber;
        }
    }
}
