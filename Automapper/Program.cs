using System;
using AutoMapper;
using Threenine.Map;

namespace SimpleMappingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            MapConfigurationFactory.Scan<Program>();

            var testMap = new ClassA { Name = "Gary" };

            var testMap2 = Mapper.Map<ClassB>(testMap);

            Console.WriteLine(testMap2.Name);
            Console.WriteLine(testMap2.GetType().Name);
        }
    }
}