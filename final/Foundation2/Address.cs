using System;
class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _stateProvince = "";
    private string _zipCode = "";
    private string _country = "";
    public Address(string streetAddress, string city, string state_Province, string zipCode, string country)
    {
        SetAddress(streetAddress, city, state_Province, zipCode, country);
    }
    public void SetAddress(string streetAddress, string city, string state_Province, string zipCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = state_Province;
        _zipCode = zipCode;
        _country = country;
    }
    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince} {_zipCode}\n{_country}";
    }
}