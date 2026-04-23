// ceate class
using System;

/*class Car
{
    String color = "red";
}

//create object
class Vehicle

{
    String color1 = "Pink";

    static void Main(string[] args)
    {
        Vehicle v = new Vehicle();
        Console.WriteLine(v.color1);
    }
}*/

//Multiple Objects
/*namespace MyApplication
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
}*/

// Class Members
//Fields and methods inside classes are often referred to as "Class Members":
//Create a Car class with three class members: two fields and one method.
//The class
//class MyClass
//{
//    // Class members
//    string color = "red";        // field
//    int maxSpeed = 200;          // field
//    public void fullThrottle()   // method
//    {
//        Console.WriteLine("The car is going as fast as it can!");
//    }
//}

//Fields
//variables inside a class are called fields, and that you can access them by creating an object of the class, and by using the dot syntax (.).
/*class Car
{
    string color = "red";
    int maxSpeed = 200;

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.maxSpeed);
    }
}*/

//You can also leave the fields blank, and modify them when creating the object:
/* class Car
{
    string color;
    int maxSpeed;

    static void Main(string[] args)
    {
        Car myObj = new Car();
        myObj.color = "red";
        myObj.maxSpeed = 200;
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.maxSpeed);
    }
} */
// This is especially useful when creating multiple objects of one class:
/* class Car
{
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        Car Opel = new Car();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);
    }
} */
//Constructors
/* 
 A constructor is a special method that is used to initialize objects. 
The advantage of a constructor, is that it is called when an object of a class is created.
It can be used to set initial values for fields:
 */

// Create a Car class
/* class Car
{
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car()
    {
        model = "Mustang"; // Set the initial value for model
    }

    static void Main(string[] args)
    {
        Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
        Console.WriteLine(Ford.model);  // Print the value of model
    }
} */

//Access Modifiers
//public string color;
//The public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.
/* 
 public	-->The code is accessible for all classes
private --->The code is only accessible within the same class
protected-->The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
iinternal --> The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
 */
//private Modifer
/* class Car
{
    private string model = "Mustang";

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
    }
} */
//it give output

//if you try to access it outside the class, an error will occur:
/*class Car
{
    private string model = "Mustang";
}

class Program
{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
    }
}*/
//Properties and Encapsulation
/*
 The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
declare fields/variables as private
provide public get and set methods, through properties, to access and update the value of a private field
 */
//A property is like a combination of a variable and a method, and it has two methods: a get and a set method:

/*class Person
{
    private string name; // field

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
}
Example explained
The Name property is associated with the name field. 
It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.

The get method returns the value of the variable name.

The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.
*/
//Now we can use the Name property to access and update the private field of the Person class:
/*class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}*/
/*
 Automatic Properties (Short Hand)
C# also provides a way to use short-hand / automatic properties, 
where you do not have to define the field for the property, and you only have to write get; and set; inside the property.

The following example will produce the same result as the example above. The only difference is that there is less code:
class Person
{
  public string Name  // property
  { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}

 */
//Inheritance (Derived and Base Class)
/*
 In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

Derived Class (child) - the class that inherits from another class
Base Class (parent) - the class being inherited from
To inherit from a class, use the : symbol.

In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):
 class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}

class Program
{
  static void Main(string[] args)
  {
    // Create a myCar object
    Car myCar = new Car();

    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}
 */

using System;

class Student
{

    // Private data members (Encapsulation)
    private string name;
    private int age;

    // Public method to set data
    public void SetData(string n, int a)
    {
        name = n;
        age = a;
    }

    // Public method to display data
    public void DisplayData()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program1
{
    static void Main()
    {
        // Creating object
        Student s1 = new Student();

        // Accessing methods
        s1.SetData("suyog", 21);
        s1.DisplayData();
    }
}



