public class Adress
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private bool _isInUSA;

    public Adress(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetFullAdress()
    {
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
    }
    
    public bool IsInUsa() // Getter of isInUSA
    {
        if (_country == "United States" || _country == "USA" || _country == "United States of America" || _country == "united states of america" || _country == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }
        // return _isInUSA();
    }
}