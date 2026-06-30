using System;

class Order
{
    public int oid;
    public string cname;
    public double price;

    public Order(int id, string n, double p)
    {
        oid = id;
        cname = n;
        price = p;
    }
}

class Program
{
    static void Bubble(Order[] o)
    {
        for (int i = 0; i < o.Length - 1; i++)
        {
            for (int j = 0; j < o.Length - i - 1; j++)
            {
                if (o[j].price > o[j + 1].price)
                {
                    Order t = o[j];
                    o[j] = o[j + 1];
                    o[j + 1] = t;
                }
            }
        }
    }

    static int Part(Order[] o, int low, int high)
    {
        double p = o[high].price;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (o[j].price < p)
            {
                i++;
                Order t = o[i];
                o[i] = o[j];
                o[j] = t;
            }
        }

        Order x = o[i + 1];
        o[i + 1] = o[high];
        o[high] = x;

        return i + 1;
    }

    static void Quick(Order[] o, int low, int high)
    {
        if (low < high)
        {
            int pi = Part(o, low, high);
            Quick(o, low, pi - 1);
            Quick(o, pi + 1, high);
        }
    }

    static void Show(Order[] o)
    {
        foreach (Order x in o)
        {
            Console.WriteLine(x.oid + " " + x.cname + " " + x.price);
        }
    }

    static void Main()
    {
        Order[] o ={
            new Order(1,"Ram",5000),
            new Order(2,"Sam",2000),
            new Order(3,"Tom",8000),
            new Order(4,"Raj",3000)
        };

        Console.WriteLine("Bubble Sort");
        Bubble(o);
        Show(o);

        Order[] q ={
            new Order(1,"Ram",5000),
            new Order(2,"Sam",2000),
            new Order(3,"Tom",8000),
            new Order(4,"Raj",3000)
        };

        Console.WriteLine("Quick Sort");
        Quick(q, 0, q.Length - 1);
        Show(q);
    }
}