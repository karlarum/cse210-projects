using System;
using System.Collections.Generic;

public class Order
{
    public Customer _customer;
    public List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetPackingLabel()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetShippingLabel()}";
        return shippingLabel;
    }

    public float CalculateTotalPrice()
    {
        float totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.ProductTotalCost();
        }

        float shippingCost = CalculateShippingCost();

        return totalProductCost + shippingCost;
    }

    public float CalculateShippingCost()
    {
        if (_customer.CustomerUSA())
        {
            return 5.0f;
        }
        else
        {
            return 35.0f;
        }
    }
}