namespace FacadeDesignPattern
{
    public class ShoppingFacade
    {
        private readonly InventoryManager _inventoryManager;
        private readonly OrderVerificationManager _orderVerificationManager;
        private readonly CostManager _costManager;
        private readonly PaymentGatewayManager _paymentGatewayManager;
        private readonly LogisticManager _logisticManager;

        public ShoppingFacade()
        {
            _inventoryManager = new InventoryManager();
            _orderVerificationManager = new OrderVerificationManager();
            _costManager = new CostManager();
            _paymentGatewayManager = new PaymentGatewayManager();
            _logisticManager = new LogisticManager();
        }

        public void FinalizeShopping(OrderDetails orderDetails)
        {
            _inventoryManager.Update(orderDetails.ProductId);
            _orderVerificationManager.VerifyShippingAddress(orderDetails.PinCode);
            _costManager.ApplyDiscounts(orderDetails.Price, orderDetails.Discount);
            _paymentGatewayManager.ProcessPayment(orderDetails.CardNo, orderDetails.Price);
            _logisticManager.ShipProduct(orderDetails.ProductName, orderDetails.AddressLine);
        }
    }
}
