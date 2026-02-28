using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>();

        Order o1 = new Order(1, "Ana");
        o1.Items.Add(new OrderItem("Laptop", 1, 1200m));
        o1.Items.Add(new OrderItem("Mouse", 2, 25m));
        orders.Add(o1);

        Order o2 = new Order(2, "Bogdan");
        o2.Items.Add(new OrderItem("Monitor", 1, 300m));
        o2.Items.Add(new OrderItem("Keyboard", 1, 80m));
        orders.Add(o2);

        Order o3 = new Order(3, "Ana");
        o3.Items.Add(new OrderItem("Mouse", 1, 25m));
        o3.Items.Add(new OrderItem("USB-C Hub", 1, 60m));
        orders.Add(o3);

        Console.WriteLine("Order 1 final price: " + o1.CalculateFinalPrice());
        Console.WriteLine("Customer who spent the most: " + Analytics.FindCustomerWhoSpentMost(orders));

        var popular = Analytics.GetPopularProducts(orders);

        foreach (var kv in popular)
        {
            Console.WriteLine(kv.Key + " -> " + kv.Value);
        }
    }
}