using System;
class Program
{
    static Stack root, top;
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1: Push to stack | 2: Pop from stack");
            int response = Convert.ToInt16(Console.ReadLine());
            if(response == 1)
                Push();
            else
                Pop();
        }
    }

    static void Push()
    {
        Console.Write("Enter your number: ");
        int val = Convert.ToInt16(Console.ReadLine());
        if(root == null)
        {
            root = new Stack(val);
            top = root;
        }
        else
        {
            top.top = new Stack(val);
            top = top.top;
        }
        Display();
    }

    static void Pop()
    {
        Stack ele = root;
        if(ele != null)
        {
            if(ele.top == null)
            {
                Console.WriteLine("Removing element " + root.value + " from stack.");
                root = null;
                top = null;
            }
            else
            {
                while (ele.top.top != null)
                {
                    ele = ele.top;
                }
                Console.WriteLine("Removing element " + ele.top.value + " from stack.");
                ele.top = null;
                top = ele;
            }
            Display();
        }
    }

    static void Display()
    {
        Stack ele = root;
        int count = 1;
        while (ele != null)
        {
            Console.WriteLine(count + ": " + ele.value);
            count++;
            ele = ele.top;
        }
    }
}

class Stack
{
    public int value;
    public Stack top;

    public Stack(int val) => this.value = val;
}