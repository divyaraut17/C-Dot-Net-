using System;

class Program {
    /* static void MyMethod(string fname)
    {
        Console.WriteLine(fname + " Refsnes");
    }

    static void Main(string[] args)
    {
        MyMethod("Liam");
        MyMethod("Jenny");
        MyMethod("Anja");
    } */

    // Multiple Parameters
    /* static void MyMethod(string fname, int age)
    {
        Console.WriteLine(fname + " is " + age);
    }

    static void Main(string[] args)
    {
        MyMethod("Liam", 5);
        MyMethod("Jenny", 8);
        MyMethod("Anja", 31);
    }*/

    //Default Parameter Value
    /* static void MyMethod(string country = "Norway")
    {
        Console.WriteLine(country);
    }

    static void Main(string[] args)
    {
        MyMethod("Sweden");
        MyMethod("India");
        MyMethod();
        MyMethod("USA");
    }*/
    // Return Values

    /* static int MyMethod(int x)
    {
        return 5 + x;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MyMethod(3));
    }*/

    /*static int MyMethod(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MyMethod(5, 3));
    }*/

    // Named Arguments
    //It is also possible to send arguments with the key: value syntax.
    /*static void MyMethod(string child1, string child2, string child3)
    {
        Console.WriteLine("The youngest child is: " + child3);
    }

    static void Main(string[] args)
    {
        MyMethod(child3: "John", child1: "Liam", child2: "Liam");
    }*/


    //Method Overloading
    //With method overloading, multiple methods can have the same name with different parameters:
    /*static int PlusMethodInt(int x, int y)
    {
        return x + y;
    }

    static double PlusMethodDouble(double x, double y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        int myNum1 = PlusMethodInt(8, 5);
        double myNum2 = PlusMethodDouble(4.3, 6.26);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);
    }*/

    //Instead of defining two methods that should do the same thing, it is better to overload one.
    //In the example below, we overload the PlusMethod method to work for both int and double:

    /*static int PlusMethod(int x, int y)
    {
        return x + y;
    }

    static double PlusMethod(double x, double y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        int myNum1 = PlusMethod(8, 5);
        double myNum2 = PlusMethod(4.3, 6.26);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);
    }*/


}

