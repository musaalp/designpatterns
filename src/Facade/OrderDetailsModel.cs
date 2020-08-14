namespace FacadeDesignPattern
{
    public class OrderDetailsModel
    {
        public string ProductName { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public string AddressLine { get; set; }
        public int PinCode { get; set; }
        public string CardNo { get; set; }
    }
}
