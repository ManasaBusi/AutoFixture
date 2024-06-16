using AutoFixture;
using DemoCode;

namespace AutoFixtureDemo.Tests
{
    public class GraphDemos
    {
        [Fact]
        public void ManualCreation()
        {
            //Arrange
            Customer customer = new Customer
            {
                CustomerName = "Manasa"
            };

            Order order = new Order(customer)
            {
                Id = 42,
                OrderDate = DateTime.Now,
                Items = { new OrderItem { ProductName = "Hats", Quantity = 2 } }

            };

            //Act
            var result = order.Items.Sum(x => x.Quantity);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void AutoCreation()
        {
            //Arrange

            var fixture = new Fixture();

            Order order = fixture.Create<Order>();
        }

    }
}
