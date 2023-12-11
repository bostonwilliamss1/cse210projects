using System.Security.Cryptography.X509Certificates;

public class Address
{
    private string _street;
    private string _city;
    private string _stateprov;
    private string _country;
    public Address(string street, string city, string stateprov, string country)
    {
        _street = street;
        _city = city;
        _stateprov = stateprov;
        _country = country;
    }
    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}, {_stateprov}");
        Console.WriteLine($"{_country}");
    }
    
    
}