using AutoFixture;
using DemoCode;

namespace AutoFixtureDemo.Tests
{
    public class StringDemos
    {
        [Fact]
        public void BasicStrings()
        {
            //Arrange
            var fixture = new Fixture();
            var sut = new NameJoiner();

            var firstName = fixture.Create("First_");
            var lastName = fixture.Create("Last_");

            //Act
            var result = sut.Join(firstName, lastName);

            //Assert
            Assert.Equal(firstName + ' ' + lastName, result);
        }

        [Fact]
        public void Chars() 
        {
            //Arrange
            var fixture = new Fixture();

            var anonChar = fixture.Create<char>();
        }
    }
}
