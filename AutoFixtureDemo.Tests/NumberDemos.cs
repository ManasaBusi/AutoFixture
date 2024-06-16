using AutoFixture;
using DemoCode;

namespace AutoFixtureDemo.Tests
{
    public class NumberDemos
    {
        [Fact]
        public void Ints()
        {
            //Arrange
            var sut = new IntCalculator();
            var fixture = new Fixture();

            //Act
            //sut.Subtract(1);
            sut.Subtract(fixture.Create<int>());

            //Assert
            Assert.True(sut.Value < 0);
        }

        [Fact]

        public void Decimals()
        {
            //Arrange
            var fixture = new Fixture();
            var sut = new DecimalCalculator();

            decimal num = fixture.Create<decimal>();

            //Act
            sut.Add(num);

            //Assert
            Assert.Equal(num, sut.Value);



        }
    }
}
