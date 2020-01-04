using Threenine.Map;

namespace SimpleMappingFactory
{
    public class ClassA : IMapTo<ClassB>
    {
        public string Name { get; set; }
    }
}