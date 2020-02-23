using PatterDesign.Domain.Attributes;
using PatterDesign.Domain.Interfaces;
using PatternDesign.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatterDesign.Domain.Services
{
    public class Menu : IMenu
    {
        private readonly IConsoleWriter consoleWriter;
        private List<MenuModel> options;

        public Menu(IConsoleWriter _consoleWriter)
        {
            consoleWriter = _consoleWriter;
            GenerateMenu();
        }


        public void Display()
        {
            consoleWriter.WriteMeesage("   Select and option");
            consoleWriter.WriteMeesage("");
            options.ForEach(p => consoleWriter.WriteMeesage($"{p.Id} > {p.Name}"));
            consoleWriter.WriteMeesage("");
            consoleWriter.WriteMeesage("Select an option");
        }

        public string ReadOption()
        {
            string option = Console.ReadLine();
            int optionSelected;
            int.TryParse(option, out optionSelected);
            if (optionSelected == 0)
                throw new ArgumentException("Incorrect input");

            var selected = options.First(x => x.Id == optionSelected);

            if (selected == null)
                throw new ArgumentException("Option does not exist");

            return selected.ClassName;
        }


        private void GenerateMenu()
        {
            var interdacedesign = typeof(IPatternDesign);
            int index = 1;

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(IPatternDesign).IsAssignableFrom(x) && x.IsClass ).ToList();

            options = new List<MenuModel>();

            types.ForEach(x =>
            {
                

                var attributes = Attribute.GetCustomAttributes(x);

                foreach (Attribute attr in attributes)
                {
                    if (attr is PatternAnnotation)
                    {
                        PatternAnnotation p = (PatternAnnotation)attr;
                        options.Add(new MenuModel
                        {
                            Id = index,
                            ClassName = x.Name,
                            Name = p.Name,
                            Description = p.Description
                        });

                        index++;
                    }
                }
            });
        }
    }
}
