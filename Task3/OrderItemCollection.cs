using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
