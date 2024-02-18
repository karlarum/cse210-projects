using System;

public class Product
{
    private string _productName;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string productName, int productID, int price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetPackingLabel()
    {
        return $"Product: {_productName} | Product ID: {_productID}";
    }

    public int ProductTotalCost()
    {
        return _price * _quantity;
    }
}