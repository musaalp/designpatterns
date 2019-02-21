using System;

namespace FacadeDesignPattern
{
    public class OrderDetails
    {
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public float Price { get; private set; }
        public float Discount { get; private set; }
        public string AddressLine { get; private set; }
        public int PinCode { get; private set; }
        public string CardNo { get; private set; }

        public OrderDetails(OrderDetailsModel orderDetailsModel)
        {
            ProductId = new Random().Next(1, 100);
            ProductName = orderDetailsModel.ProductName;
            Price = orderDetailsModel.Price;
            Discount = orderDetailsModel.Discount;
            AddressLine = orderDetailsModel.AddressLine;
            PinCode = orderDetailsModel.PinCode;
            CardNo = orderDetailsModel.CardNo;
        }
    }
}
