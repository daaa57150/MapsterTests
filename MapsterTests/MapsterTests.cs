using Mapster;

namespace MapsterTests
{
    public class MapsterTests
    {
        private static Model BuildModel()
        {
            Model model = new Model()
            {
                Name = "Model",
                Child = new Child(10, 20)
            };

            return model;
        }

        private static EditModelCommand BuildCommand()
        {
            EditModelCommand command = new EditModelCommand()
            {
                Name = "Edited Model",
                Child = new EditModelChild()
                {
                    Property1 = 99,
                }
            };

            return command;
        }

        [Fact]
        public void Test1()
        {
            Model model = BuildModel();
            EditModelCommand command = BuildCommand();

            command.Adapt(model);

            Assert.Equal("Edited Model", model.Name);
            Assert.Equal(20, model.Child.Property2); // ERROR
        }
    }
}