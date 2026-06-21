using System;
using System.Collections.Generic;

class Product
{
    public int pid;
    public string pname;
    public int qty;
    public double price;

    public Product(int id, string n, int q, double p)
    {
        pid = id;
        pname = n;
        qty = q;
        price = p;
    }
}

class Program
{
    static Dictionary<int, Product> inv = new Dictionary<int, Product>();

    static void Add(Product p)
    {
        inv[p.pid] = p;
    }

    static void Update(int id, int q, double p)
    {
        if (inv.ContainsKey(id))
        {
            inv[id].qty = q;
            inv[id].price = p;
        }
    }

    static void Delete(int id)
    {
        if (inv.ContainsKey(id))
            inv.Remove(id);
    }

    static void Show()
    {
        foreach (var x in inv.Values)
        {
            Console.WriteLine(x.pid + " " + x.pname + " " + x.qty + " " + x.price);
        }
    }

    static void Main()
    {
        Add(new Product(101, "Laptop", 20, 50000));
        Add(new Product(102, "Mouse", 50, 500));

        Console.WriteLine("After Add");
        Show();

        Update(101, 25, 52000);

        Console.WriteLine("After Update");
        Show();

        Delete(102);

        Console.WriteLine("After Delete");
        Show();
    }
}
