using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Advanced
{
    public class AsyncAwait
    {
        public static async Task AsyncAwaitDemo()
        {
            Console.WriteLine("Starting async task...");

            var result = await DoSomeWorkAsync();

            Console.WriteLine($"Work finished, result: {result}");
        }

        private static async Task<string> DoSomeWorkAsync()
        {
            await Task.Delay(2000);

            return "Task Completed";
        }
    }
}
