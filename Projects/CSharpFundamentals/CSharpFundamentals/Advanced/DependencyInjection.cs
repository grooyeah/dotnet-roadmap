using Microsoft.Extensions.DependencyInjection;

namespace CSharpFundamentals.Advanced
{
    public class DependencyInjection
    {
        public static void DepndencyInjectionDemo()
        {
            // Set up the Dependency Injection container
            var serviceProvider = new ServiceCollection()
                .AddTransient<IMyService, MyService>()
                .BuildServiceProvider();

            // Resolve the service
            var myService = serviceProvider.GetService<IMyService>();
            myService?.Execute();
        }
    }

    // Interface
    public interface IMyService
    {
        void Execute();
    }

    // Concrete class implementing IMyService
    public class MyService : IMyService
    {
        public void Execute()
        {
            Console.WriteLine("MyService is executing!");
        }
    }
}
