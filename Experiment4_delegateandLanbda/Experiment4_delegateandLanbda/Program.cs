//lambda expression is a anonymous function that can be used to create delegates or expression tree types

//activity
//mathch the multiple methods 
//1.calulate using delegate
//2.multiple delegte create example 
//3. replace method with lambda expression
//4.solve list using lambda expression
//5. where we use lambda expression and delegate in company level and why
//what is LINQ query
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Delegate for calculator
    public delegate int Operation(int a, int b);

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    // Multicast delegate
    public delegate void Show();

    public static void Hello()
    {
        Console.WriteLine("Hello");
    }

    public static void Welcome()
    {
        Console.WriteLine("Welcome to C#");
    }

    static void Main()
    {
        Console.WriteLine("---- Calculator using Delegates ----");

        Operation op = Add;
        Console.WriteLine("Addition: " + op(8, 19));

        op = Multiply;
        Console.WriteLine("Multiplication: " + op(8, 19));


        Console.WriteLine("\n---- Multicast Delegate ----");

        Show s = Hello;
        s += Welcome;
        s();


        Console.WriteLine("\n---- Lambda Expression ----");

        Func<int, int> square = x => x * x;
        Console.WriteLine("Square: " + square(5));


        Console.WriteLine("\n---- Sort List using Lambda ----");

        List<int> numbers = new List<int> { 5, 2, 8, 1, 4 };
        numbers.Sort((a, b) => a.CompareTo(b));

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }


        Console.WriteLine("\n---- LINQ Query ----");

        int[] nums = { 1, 2, 3, 4, 5, 6 };

        var result = nums.Where(n => n > 3);

        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
}

//5. where we use lambda expression and delegate in company level and why
//Lambda expressions and delegates are widely used in company-level applications for various reasons:
//Delegate used in:
//1. Event Handling: Delegates are commonly used for event handling in GUI applications, allowing developers to define callback methods that respond to user actions.
//2. Asynchronous Programming: Delegates and lambda expressions are used in asynchronous programming to define callback methods that execute when an asynchronous operation completes.
//3.Callback Methods: Delegates enable the implementation of callback methods, allowing developers to pass methods as parameters to other methods, which can then invoke them at a later time.

//lambda expression used in:
//1. LINQ Queries: Lambda expressions are essential for writing LINQ queries, enabling developers to filter, project, and manipulate data collections in a concise and readable manner.
//2. Functional Programming: Lambda expressions facilitate functional programming paradigms, allowing developers to treat functions as first-class citizens and create higher-order functions.
//3. Code Readability: Lambda expressions can improve code readability by reducing boilerplate code and making it easier to understand the intent of the code, especially when working with collections and events.

//what is LINQ query
//LINQ (Language Integrated Query) is a powerful feature in C# that allows developers to query and manipulate data from various sources (like collections, databases, XML, etc.) using a consistent syntax.
//LINQ provides a set of query operators that enable developers to filter, sort, group, and transform data in a more readable and concise way compared to traditional loops and conditional statements.
//LINQ queries can be written using method syntax (with lambda expressions) or query syntax (similar to SQL).
