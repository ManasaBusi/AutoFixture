using AutoFixture;
using DemoCode;

namespace AutoFixtureDemo.Tests
{
    public class AnnotationDemos
    {
        [Fact]
        public void BasicString()
        {
            //Arrange
            var fixture = new Fixture();

            var player = fixture.Create<PlayerCharacter>();

            //act and assert
        }
    }
}
