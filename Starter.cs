using HomeWork.Providers;
using HomeWork.Providers.Abstractions;
using HomeWork.Services;
using HomeWork.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IAnimalProvider, AnimalProvider>()
                .AddTransient<ICounterService, CounterService>()
                .AddTransient<ISafariService, SafariService>()
                .AddTransient<App>()
                .BuildServiceProvider();
            var app = serviceProvider.GetService<App>();

            if (app != null)
            {
                app.Run();
            }
        }
    }
}