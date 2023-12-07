using System.ComponentModel;

public class Order
{
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();

    public void PackingLabel(Address address)
    {
        int shippingcost = TotalShipping(address);
        double totalitemprice = 0;
        Console.WriteLine("Packing Label- ");
        foreach (Customer customer in _customers)
        {
            Console.WriteLine($"{customer.GetCustomerName()}'s Order: ");
        
        foreach (Product product in _products)
        {
            double total = product.GetPrice() * product.GetQuantity();
            totalitemprice += total;
            Console.WriteLine($"{product.GetName()} ({product.GetProductId()})");
        }
            Console.WriteLine();
        }

    }
    public void ShippingLabel(Customer customer, Address address)
    {
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(customer.GetCustomerName());
        address.DisplayAddress();
        Console.WriteLine();
    }
    public int TotalShipping(Address cost)
    {
        return cost.CheckUSA() ? 5 : 35;
    }
    public void TotalCost(Address address)
    {
        int shippingcost = TotalShipping(address);
        double totalitemprice = 0;
        double totals = 0;
        Console.WriteLine("Total Cost: ");
        foreach (Product product in _products)
        {
            double itemstotal = product.GetPrice() * product.GetQuantity();
            totalitemprice += itemstotal;
            totals = shippingcost + totalitemprice;
        }
            Console.WriteLine($"Items Total: ${totalitemprice}");
            Console.WriteLine($"Shipping Cost: ${shippingcost}");
            Console.WriteLine($"Total: ${totalitemprice + shippingcost}");
            Console.WriteLine();
    }

    public void ProductList(Product item)
    {
        _products.Add(item);
    }
    public void CustomerList(Customer item)
    {
        _customers.Add(item);
    }
}