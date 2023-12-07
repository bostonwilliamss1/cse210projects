public class Customer
{
    private string _name;

    public Customer(string name)
    {
        _name = name;
    }

    public string GetCustomerName()
    {
        return _name;
    }
}