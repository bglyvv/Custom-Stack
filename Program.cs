using System;
using System.Text;
public class CustomStack
{
    public Node top;
    private int _count = 0;


    public CustomStack()
    {
        this.top = null;
    }


    //c# da stacki-in uzunluğunu tapmaq üçün stack.Count istifadə olunur. Buna görədə mən count-u method kimi yox property kimi define elədim
    public int Count
    {
        get
        {
            return _count;
        }
    }

    // stack LIFO məntiqi ilə işlədiyi üçün hər əlavə olunan yeni rəqəmi başa əlavə edəcəm.
    public void Push(int val)
    {
        Node temporary = new Node();

        if (temporary == null)
        {
            return;
        }

        temporary.data = val;

        temporary.next = top;

        top = temporary;

        _count++;
    }

    // Peek method-u stack-da ən başda olan elementi göstərəcək
    public int Peek()
    {
        try
        {
            return top.data;

        }
        catch (Exception)
        {

            Console.WriteLine("Stack boşdur");
            return -1;
        }
    }

    // Stack da baş elementi silmək üçün istifadə olunur.
    public void Pop()
    {
        try
        {
            top = top.next;
            _count--;
        }
        catch (Exception)
        {
            Console.WriteLine("Stack Underflow");
        }

    }


    // Stackda olan elementləri göstərmək üçün istifadə olunur
    public void display()
    {
        try
        {
            Node temporary = top;
            StringBuilder result = new StringBuilder();
            while (temporary != null)
            {

                result.Append(temporary.data + (temporary.next != null ? ", " : ""));
                temporary = temporary.next;
            }

            Console.WriteLine(result);

        }
        catch (Exception)
        {

            Console.WriteLine("Xəta baş verdi");
        }
    }
}


// Linked List node
public class Node
{
    public int data;
    public Node next;
}



public class Program
{
    public static void Main(String[] args)
    {

        CustomStack st = new CustomStack();

        st.Push(1);
        st.Push(2);
        st.Push(3);
        st.Push(4);
        st.Push(5);

        st.display();

        Console.WriteLine("Başdakı element: {0}", st.Peek());

        Console.WriteLine($"Stack-in uzunluğu: {st.Count}");


        st.Pop();
        st.Pop();

        Console.WriteLine("---------------------");

        st.display();

        Console.WriteLine("Başdakı element: {0}", st.Peek());
        Console.WriteLine($"Stack-in uzunluğu: {st.Count}");
    }
}
