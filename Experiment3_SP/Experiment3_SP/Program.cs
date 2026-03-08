using System;

// I - Interface Segregation Principle
interface IWork
{
    void Work();
}

interface IEat
{
    void Eat();
}

// S - Single Responsibility Principle
class Worker : IWork, IEat
{
    public void Work()
    {
        Console.WriteLine("Worker is working");
    }

    public void Eat()
    {
        Console.WriteLine("Worker is eating");
    }
}

// L - Liskov Substitution Principle
class Manager : IWork
{
    public void Work()
    {
        Console.WriteLine("Manager is managing work");
    }
}

// O - Open/Closed Principle
class WorkReport
{
    public virtual void Generate()
    {
        Console.WriteLine("Generating basic report");
    }
}

class DetailedReport : WorkReport
{
    public override void Generate()
    {
        Console.WriteLine("Generating detailed report");
    }
}

// D - Dependency Inversion Principle
class Company
{
    private IWork worker;

    public Company(IWork worker)
    {
        this.worker = worker;
    }

    public void StartWork()
    {
        worker.Work();
    }
}

class Program
{
    static void Main()
    {
        Worker w = new Worker();
        w.Work();
        w.Eat();

        Manager m = new Manager();
        m.Work();

        WorkReport report = new DetailedReport();
        report.Generate();

        Company c = new Company(w);
        c.StartWork();
    }
}