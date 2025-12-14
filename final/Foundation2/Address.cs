using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _zipCode;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string zipCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _zipCode = zipCode;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince} {_zipCode}\n{_country}";
    }
}
