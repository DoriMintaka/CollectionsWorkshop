namespace Task5
{
    using System;

    public class OrderItem
    {
        public readonly int PartNumber;
        public readonly string Description;
        public readonly double UnitPrice;
        private int _quantity = 0;

        public OrderItem(int partNumber, string description, int quantity, double unitPrice)
        {
            this.PartNumber = partNumber;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }

        public int Quantity
        {
            get
            {
                return this._quantity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity cannot be negative.");
                }

                this._quantity = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0,9} {1,6} {2,-12} at {3,8:#,###.00} = {4,10:###,###.00}",
                this.PartNumber, this._quantity, this.Description, this.UnitPrice, this.UnitPrice * this._quantity);
        }
    }
}