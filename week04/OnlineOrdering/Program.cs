using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4800 N Street", "Provo", "Utah", "USA");
        Address address2 = new Address("117 Nakai Nakaku", "Okayama", "Okayama", "JAPAN");

        Customer customer1 = new Customer("Ken", address1);
        Customer customer2 = new Customer("Hana", address2);

        Product product1 = new Product("Phone", "112564", 120.99, 1);
        Product product2 = new Product("Book", "H96785", 10.99, 10);
        Product product3 = new Product("Desk", "D12345", 45.99, 2);
        Product product4 = new Product("Plate", "456789", 12.99, 5);

        //Ken's order
        Order order1 = new Order(customer1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        //Hana's order
        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product4);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("---Packing Labal---");
            Console.WriteLine(order.GetPakingLable());
            Console.WriteLine();

            Console.WriteLine("---Shipping Label---");
            Console.WriteLine(order.GetShippingLabale());
            Console.WriteLine();

            Console.WriteLine($"Total Price: ${order.GetTotalPrice():f2}");
            Console.WriteLine("**********************");
        }
    }
}