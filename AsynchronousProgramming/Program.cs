using System;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        //testing git
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");

            var task = SomeMethod();

            Console.WriteLine("Main Method End");

            string Result = task.Result;
            Console.WriteLine($"Result : {Result}");

            Console.WriteLine("Program End");
            Console.ReadKey();
        }

        public async static Task<string> SomeMethod()
        {
            Console.WriteLine("Some Method Started......");

            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n");

            Console.WriteLine("Some Method End");
            return "Some Data";
        }
    }
}