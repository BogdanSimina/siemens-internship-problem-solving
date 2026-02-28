using System.Collections.Generic;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public List<OrderItem> Items { get; set; }

    public Order(int id, string customerName)
    {
        Id = id;
        CustomerName = customerName;
        Items = new List<OrderItem>();
    }

    public decimal CalculateFinalPrice()
    {
        decimal total = 0;

        for (int i = 0; i < Items.Count; i++)
        {
            total += Items[i].GetTotal();
        }

        if (total > 500)
        {
            total = total - (total * 0.10m);
        }

        return total;
    }
}