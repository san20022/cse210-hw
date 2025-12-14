using System;
class Address
{
    private string _streetAddress = "Street Address";
    private string _city = "City";
    private string _stateProvince = "State";
    private string _zipCode = "Zip";
    private string _country = "USA";
    public Address() {}
    public Address(string streetAddress, string city, string state_Province, string zipCode, string country)
    {
        setAddress(streetAddress, city, state_Province, zipCode, country);
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