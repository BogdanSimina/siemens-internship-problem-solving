using System.Collections.Generic;

public class Analytics
{
    public static string FindCustomerWhoSpentMost(List<Order> orders)
    {
        string bestCustomer = "";
        decimal bestTotal = 0;

        for (int i = 0; i < orders.Count; i++)
        {
            string currentCustomer = orders[i].CustomerName;

            decimal customerTotal = 0;

            for (int j = 0; j < orders.Count; j++)
            {
                if (orders[j].CustomerName == currentCustomer)
                {
                    customerTotal += orders[j].CalculateFinalPrice();
                }
            }

            if (customerTotal > bestTotal)
            {
                bestTotal = customerTotal;
                bestCustomer = currentCustomer;
            }
        }

        return bestCustomer;
    }

    public static Dictionary<string, int> GetPopularProducts(List<Order> orders)
    {
        Dictionary<string, int> productCounts = new Dictionary<string, int>();

        for (int i = 0; i < orders.Count; i++)
        {
            for (int j = 0; j < orders[i].Items.Count; j++)
            {
                string name = orders[i].Items[j].ProductName;
                int qty = orders[i].Items[j].Quantity;

                if (productCounts.ContainsKey(name))
                {
                    productCounts[name] += qty;
                }
                else
                {
                    productCounts[name] = qty;
                }
            }
        }

        return productCounts;
    }
}