using System;
using System.Collections.Generic;
using System.Text;

namespace PatterDesign.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PatternAnnotation : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public PatternAnnotation(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
