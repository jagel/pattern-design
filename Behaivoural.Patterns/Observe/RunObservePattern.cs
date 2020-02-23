using PatterDesign.Domain.Attributes;
using PatterDesign.Domain.Interfaces;
using PatternDesign.Data.Doc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behaivoural.Patterns.Observe
{
    [PatternAnnotation(PatternDefinitions.ObservePatternTitle, PatternDefinitions.ObservePatternInformation)]
    public class RunObservePattern : IPatternDesign
    {
        public void Run()
        {
            Console.Write("Observe pattern is running");
        }
    }

    [PatternAnnotation("demo", "demo inf")]
    public class demopattern : IPatternDesign
    {
        public void Run()
        {
            Console.Write("demo pattern is running");
        }
    }
}
