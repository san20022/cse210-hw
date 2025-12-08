using System;
using System.Collections.Generic;
class Order 
{
    private Customer _customer;
    private List<Product> _productList = new List<Product>();
    private double shippingCostOutsideUSA = 35;
    private double shippingCostInsideUSA = 5;
    public double GetTotalCost()
    {
        double totalCost = 0;
        if (_customer.IsLocalUSAddress())
        {
            totalCost += shippingCostInsideUSA;
        }
        else
        {
            totalCost += shippingCostOutsideUSA;
        }
        foreach (Product lineItemInOrder in _productList)
        {
            totalCost += lineItemInOrder.GetProductTotalCost();
        }
        return totalCost;
    }
    public void CustomerSetup(string name, string streetAddress, string city, string state_Province, string zipCode, string country)
    {
        _customer = new Customer(name);
        _customer.SetAddress(streetAddress, city, state_Province, zipCode, country);
    }
    public string GetCustomer()
    {
        return _customer.GetCustomerName();
    }
    public void SetProductList(Product itemAdding, int quantity)
    {
        itemAdding.SetQuantity(quantity);
        _productList.Add(itemAdding);
    }
    public string GetPackingLabel()
    {
        string result = "";
        foreach (Product lineItem in _productList)
        {
            result += $"Product Name: {lineItem.GetName()} - Product ID: {lineItem.GetID()} Qty: {lineItem.GetQuantity()}\n";
        }
        return result;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
    }
}