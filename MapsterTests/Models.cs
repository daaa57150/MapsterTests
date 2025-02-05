using System.Diagnostics;

namespace MapsterTests
{
    // Source models
    public class EditModelCommand
    {
        public string Name { get; set; }
        public EditModelChild Child { get; set; }
    }

    public class EditModelChild
    {
        public int Property1 { get; set; }
    }

    // Destination models
    public class Model : ParentModel
    {
        public string Name { get; set; }
    }

    public abstract class ParentModel
    {
        public Child Child { get; set; }
    }

    public class Child
    {
        public int Property1 { get; set; }
        public int Property2 { get; set; }

        // The error is because this ctor is private, somehow
        private Child() 
        {
            Debug.WriteLine("new Child");
        }

        public Child(int property1, int property2)
        {
            Debug.WriteLine($"new Child({property1}, {property2})");
            Property1 = property1;
            Property2 = property2;
        }
    }
}
