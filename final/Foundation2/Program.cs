using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> _orders = new List<Order>();

        Product product = new Product("can opener", "8456-435", 14, 1);
        Product product1 = new Product("wrench", "01234-432", 2, 1);
        Product product2 = new Product("refrigerator", "5678-463", 2599, 1);
        Product product3 = new Product("laptop", "234-ab54", 599, 1);

        Product product4 = new Product("DELL 3476 Quantum Processor", "3476-DQP", 24999, 1);
        Product product5 = new Product("Vibranium", "V-344", 26000, 1);
        Product product6 = new Product("Bombardier Global 6000", "B/G 9765", 31500000, 1);

        Order order = new Order(new Customer("John Smith", new Address("221 B Baker Street", "London", "England", "UK", 2354)));
        order.AddItem(product);
        order.AddItem(product1);
        order.AddItem(product2);
        order.AddItem(product3);

        order.GetPackingLabel();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine(order.GetTotalCost());
        Console.WriteLine();

        order = new Order(new Customer("Tony Stark", new Address("10880 Malibu Point", "Malibu", "California", "USA", 90265)));
        order.AddItem(product4);
        order.AddItem(product5);
        order.AddItem(product6);

        order.GetPackingLabel();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine(order.GetTotalCost());


    }
}