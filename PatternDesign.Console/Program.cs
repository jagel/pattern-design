
namespace PatternDesign.Console
{
    using Behaivoural.Patterns.Observe;
    using Microsoft.Extensions.DependencyInjection;
    using PatterDesign.Domain.Interfaces;
    using PatterDesign.Domain.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    //https://refactoring.guru/design-patterns/csharp
    //https://www.dofactory.com/net/design-patterns
    //https://www.dotnettricks.com/learn/designpatterns/observer-design-pattern-c-sharp
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConsoleWriter, ConsoleWriter>()
                .AddSingleton<IMenu, Menu>()
                .AddTransient<IPatternDesign, RunObservePattern>()
                .BuildServiceProvider();

            if (args.Length == 0)
            {
                var menu = serviceProvider.GetService<IMenu>();
                menu.Display();
                try
                {
                    var optionSelected = menu.ReadOption();
                    var serviceSelected = serviceProvider.GetServices<IPatternDesign>();
                    serviceSelected.First(x => x.GetType().Name == optionSelected).Run();
                }
                catch (Exception ex)
                {
                    serviceProvider.GetService<IConsoleWriter>().WriteErrorMessage(ex.Message);
                }
            }





            Console.ReadLine();

        }
    }
}
