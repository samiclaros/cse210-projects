using System.Net.Sockets;

public class Customer
{
    private string _customerName;
    private Adress _adress;

    public Customer (string customerName, Adress adress)
    {
        _customerName = customerName;
        _adress = adress;
    }

    public string GetName()
    {
        return _customerName;
    }

    public Adress GetAdress()
    {
        return _adress;
    }

    public bool IsInUSA()
    {
        return _adress.IsInUsa(); // Pull out the bool of adress class
    }
}