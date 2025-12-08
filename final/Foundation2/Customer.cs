using System;
class Customer 
{
    private string _customerName = "";
    private Address _customerAddress;
    private bool _localUS_Address = false;
    private string _country = "";
    public Customer(string customerName)
    {
        SetCustomerName(customerName);
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public string GetCustomerAddress()
    {
        return _customerAddress.GetAddress();
    }
    public void SetCustomerName(string name)
    {
        _customerName = name;
    }
    public void SetAddress(string streetAddress, string city, string state_Province, string zipCode, string country)
    {
        _customerAddress = new Address(streetAddress, city, state_Province, zipCode, country);
        _country = country;
    }
    public bool IsLocalUSAddress()
    {
        if (_country == "USA") { return true; }
        else return false;
    }
}