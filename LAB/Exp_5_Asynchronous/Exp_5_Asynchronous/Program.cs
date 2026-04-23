using System;
using System.Threading;
using System.Threading.Tasks;


    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("---- Synchronous Program ----");
            SyncMethod();

            Console.WriteLine("\n---- Asynchronous Program ----");
            await AsyncMethod();

            Console.WriteLine("\n---- Task.Delay Example ----");
            await DelayExample();

            Console.WriteLine("\n---- Method Returning Task ----");
            await MethodReturningTask();
        }

        // 1️⃣ Synchronous Method
        static void SyncMethod()
        {
            Console.WriteLine("Task 1 Started");
            Thread.Sleep(2000);   // pause for 2 seconds
            Console.WriteLine("Task 1 Finished");

            Console.WriteLine("Task 2 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Task 2 Finished");
        }

        // 2️⃣ Asynchronous Method
        static async Task AsyncMethod()
        {
            Console.WriteLine("Async Task 1 Started");
            await Task.Delay(2000);
            Console.WriteLine("Async Task 1 Finished");

            Console.WriteLine("Async Task 2 Started");
            await Task.Delay(2000);
            Console.WriteLine("Async Task 2 Finished");
        }

        // 3️⃣ Replace Thread.Sleep with Task.Delay
        static async Task DelayExample()
        {
            Console.WriteLine("Waiting using Task.Delay...");
            await Task.Delay(3000);
            Console.WriteLine("Finished waiting");
        }

        // 4️⃣ Method Returning Task
        static async Task MethodReturningTask()
        {
            Console.WriteLine("Method returning Task started");
            await Task.Delay(2000);
            Console.WriteLine("Method returning Task finished");
        }
    }
