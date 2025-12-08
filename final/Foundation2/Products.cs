using System;
class Product
{
    private string _name = "";
    private string _productID = "";
    private double _pricePerUnit = 0;
    private int _quantity = 0;
    public Product(string productName, string productID, double pricePerUnit)
    {
        _name = productName;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public double GetProductTotalCost()
    {
        return _quantity * _pricePerUnit;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetID()
    {
        return _productID;
    }
    public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}