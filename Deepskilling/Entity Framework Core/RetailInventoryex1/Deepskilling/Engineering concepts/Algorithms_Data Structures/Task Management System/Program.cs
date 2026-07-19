using System;

class Task
{
    public int id;
    public string name;
    public string status;
    public Task next;

    public Task(int i, string n, string s)
    {
        id = i;
        name = n;
        status = s;
        next = null;
    }
}

class Program
{
    static Task head = null;

    static void Add(Task t)
    {
        if (head == null)
            head = t;
        else
        {
            Task cur = head;
            while (cur.next != null)
                cur = cur.next;
            cur.next = t;
        }
    }

    static Task Search(int id)
    {
        Task cur = head;
        while (cur != null)
        {
            if (cur.id == id)
                return cur;
            cur = cur.next;
        }
        return null;
    }

    static void Delete(int id)
    {
        if (head == null) return;

        if (head.id == id)
        {
            head = head.next;
            return;
        }

        Task cur = head;
        while (cur.next != null)
        {
            if (cur.next.id == id)
            {
                cur.next = cur.next.next;
                return;
            }
            cur = cur.next;
        }
    }

    static void Show()
    {
        Task cur = head;
        while (cur != null)
        {
            Console.WriteLine(cur.id + " " + cur.name + " " + cur.status);
            cur = cur.next;
        }
    }

    static void Main()
    {
        Add(new Task(1, "Coding", "Open"));
        Add(new Task(2, "Testing", "Done"));
        Add(new Task(3, "Deploy", "Open"));

        Show();

        Delete(2);

        Console.WriteLine("After Delete");
        Show();
    }
}