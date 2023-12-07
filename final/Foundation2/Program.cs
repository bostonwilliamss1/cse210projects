using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Paper (reams)", "01034", 1, 100);
        Product p2 = new Product("Folders (5)", "12353", 4.45, 5);
        Product p3 = new Product("Stapler (1)", "97765", 6.59, 1);
        Product p4 = new Product("Rubber Bands (15)", "45321", 3.24, 25);

        Address a1 = new Address("345 Main St.", "Centerville", "OH", "United States");
        Address a2 = new Address("2201 Brown St", "Wilmington", "Ontario", "Canada");

        Customer c1 = new Customer("Sarah Lopez");
        Customer c2 = new Customer("Jonny Jones");

        Order order1 = new Order();
        Order order2 = new Order();

        order1.CustomerList(c1);
        order2.CustomerList(c2);

        order1.ProductList(p1);
        order1.ProductList(p2);

        order2.ProductList(p3);
        order2.ProductList(p4);

        order1.PackingLabel(a1);
        order1.ShippingLabel(c1, a1);
        order1.TotalCost(a1);
        
        order2.PackingLabel(a2);
        order2.ShippingLabel(c2, a2);
        order2.TotalCost(a2); 
        
        

    }
}