using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetShippingLabel()
    {
        return $"{_name}\nAddress:\n{_address.FormatAddress()}";
    }

    public bool CustomerUSA()
    {
        return _address.AddressIsUSA();
    }
}