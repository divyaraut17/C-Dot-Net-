//it is a type-safe reference to a method it means delegates can store address of methods and call it later
//simple -- delegates is a var that points to a function
//when we use : event handling programs
// suppose when we have to call function sometimes it become slow performace then we use delegates
//delegate is mediter in betwwen function and method
// 1. singlecast Delegate
//2.multicast Delegate

//class Program
//{
//    // Step 1: Declare delegate
//    public delegate void MyDelegate();

//    // Step 2: Method matching delegate signature
//    public static void Function1()
//    {
//        Console.WriteLine("hello");
//    }

//    static void Main(string[] args)
//    {
//        // Step 3: Assign method to delegate
//        MyDelegate d1 = Function1;

//        // Step 4: Invoke delegate
//        d1();
//    }
//}
using System;
internal class Program
{
    public void f1()
    {
        Console.WriteLine("hello");
    }
    public void f2()
    {
        Console.WriteLine("hiiii");
    }
    public void f3()
    {
        Console.WriteLine("heeeeee");
    }
    public delegate void MyDelegate();

    public static void Main()
    {
        Program p = new Program();
        MyDelegate del = new MyDelegate(p.f1);
        del -= p.f2;
        del += p.f3;
        {
            del();
        }
        
    }

}



