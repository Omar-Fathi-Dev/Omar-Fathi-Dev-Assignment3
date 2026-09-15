namespace CSharpBasicsAssignment;

public class Order
{
    public  int _orderId;
    public  string _customerName;
    public  int _quantity;
    public  decimal _unitPrice;
    public  decimal _totalPrice;
    public  bool _isPaid;
    public  double _discountPercent;
    public  string _shippingCity;
    public  char _priority;
    public  long _itemCode;
        
    public void CalculateTotal()
    {
        _totalPrice = (_quantity * _unitPrice )* (1 - (decimal)(_discountPercent/100));
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Order Id : {_orderId} - Customer Name: {_customerName} - Total Price: {_totalPrice} - IsPaid : {_isPaid}");
    }
        
        
        
        
}