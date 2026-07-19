using System;

class Product
{
    public int pid;
    public string pname;
    public string cat;

    public Product(int id, string n, string c)
    {
        pid = id;
        pname = n;
        cat = c;
    }
}

class Program
{
    static Product Ls(Product[] p, int id)
    {
        for (int i = 0; i < p.Length; i++)
        {
            if (p[i].pid == id)
                return p[i];
        }
        return null;
    }

    static Product Bs(Product[] p, int id)
    {
        int l = 0, r = p.Length - 1;

        while (l <= r)
        {
            int m = (l + r) / 2;

            if (p[m].pid == id)
                return p[m];

            if (p[m].pid < id)
                l = m + 1;
            else
                r = m - 1;
        }
        return null;
    }

    static void Main()
    {
        Product[] p ={
            new Product(101,"Laptop","Ele"),
            new Product(102,"Mouse","Ele"),
            new Product(103,"Key","Ele"),
            new Product(104,"Shoe","Fas"),
            new Product(105,"Watch","Acc")
        };

        Product a = Ls(p, 103);

        Console.WriteLine("Linear Search");
        if (a != null)
            Console.WriteLine(a.pname);
        else
            Console.WriteLine("Not Found");

        Product b = Bs(p, 104);

        Console.WriteLine("Binary Search");
        if (b != null)
            Console.WriteLine(b.pname);
        else
            Console.WriteLine("Not Found");
    }
}