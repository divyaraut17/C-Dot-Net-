
//solid principle --> USE>they helps to write clean ,maintanable,reuasble code
//it is object oriented designing priviple
//s--single responsibilty priciple
//O--open/close principle
//l--liskov substitution priciple
//i--interface seggregation principle
//d--dependency inversion principle

//Single responsibilty principle(SRP) --->one class should do only one job (if a class has more than one responsibilty it hard to maintain)
class Student
{  // it is bad ex of SRP
    public void SaveStudent()
    {
      //save student data in DB
    }
    public void PrintReport()
    {
        //print student report
    }
}

class Student1
{
    public string Name { get; set; }
    
}
class SaveStudentData
{
    public void SaveStudentDB(Student std)
    {
        // save student detail
    }
}
class ReportStudent
{
    public void PrintReport(Student std)
    {
        //print report
    }
}

//Open/closes Principle(OCP)----> class should be open for extension but closed for modification (use should add more feature without changing exsiting code)
class Discount
{
    public int GetDiscount(String CustomerType)
    {
        if ( CustomerType==null)
        {
            return 1;
        }
        else
           return 0;
    }
}
// this is bad ex if we want to add new customer type we have to modify the existing code

//good ex
interface IdDiscount
{
    GetDiscount();
}
class StudentDiscount : IdDiscount
{
    public GetDiscount()=>10
}

class TeacherDiscount : IdDiscount
{
    public GetDiscount()=>20
}
//to add new discount create new class

//liskov substitution principle(LSP)--> child class should replace parent class without affecting the functionality of program(if b is child of a then we should able to use b instead of a everywhere without breaking the code)
class Bird
{
    public virtual void Fly()
    {
        //
    }
}
class Ostrich : Bird
{
    public override void Fly()
    {
        //
    }
}
//ostrich is a bird but cannot fly it breaks behavior 

interface IBird
{

}
interface IflyingBird
{
    void fly();
}
class sparrow : IflyingBird
{
    public void fly()
    {

    }
}
class ostrich : IBird
{

}
//I – Interface Segregation Principle (ISP)-->  “A class should not be forced to implement interfaces it does not use.”
//Instead of one big interface, create multiple small, specific interfaces.

//Bad example
interface IWorker
{
    void Work();
    void Eat();
}

class HumanWorker : IWorker
{
    public void Work()
    {
        // human working
    }

    public void Eat()
    {
        // human eating
    }
}

class RobotWorker : IWorker
{
    public void Work()
    {
        // robot working
    }

    public void Eat()
    {
        // ❌ robot does not eat
        throw new NotImplementedException();
    }
}
//Robot is forced to implement Eat() which it does not need.

//Good example
interface IWork
{
    void Work();
}

interface IEat
{
    void Eat();
}

class HumanWorker1 : IWork, IEat
{
    public void Work()
    {
        // human working
    }

    public void Eat()
    {
        // human eating
    }
}

class RobotWorker1 : IWork
{
    public void Work()
    {
        // robot working
    }
}
//Each class implements only what it needs, Easy to maintain and extend

//D – Dependency Inversion Principle (DIP)--> High-level modules should not depend on low-level modules.
//Both should depend on abstractions (interfaces)

//Bad example
class MySQLDatabase
{
    public void SaveData()
    {
        // save data in MySQL
    }
}

class UserService
{
    MySQLDatabase db = new MySQLDatabase();

    public void SaveUser()
    {
        db.SaveData();
    }
}
//UserService is tightly coupled to MySQLDatabase,If database changes → code must be modified

//Good example
interface IDatabase
{
    void SaveData();
}

class MySQLDatabase1 : IDatabase
{
    public void SaveData()
    {
        // save data in MySQL
    }
}

class MongoDatabase : IDatabase
{
    public void SaveData()
    {
        // save data in MongoDB
    }
}

class UserService1
{
    private IDatabase db;

    public UserService1(IDatabase database)
    {
        db = database;
    }

    public void SaveUser()
    {
        db.SaveData();
    }
}
//UserService depends on interface, not concrete class,Easy to switch DB without changing business logic

//SOLID – One-Line Revision (Very Useful for MCQs)

//S (SRP) → One class = One responsibility

//O(OCP) → Open for extension, closed for modification

//L (LSP) → Child can replace parent without breaking code

//I (ISP) → Many small interfaces > one large interface

//D(DIP) → Depend on abstractions, not concrete classes