using AutoFixture;
using DemoCode;

namespace AutoFixtureDemo.Tests
{
    public class SequenceDemos
    {
        [Fact]
        public void SequenceOfString()
        {
            //Arrange
            var fixture = new Fixture();

            IEnumerable<string> messages = fixture.CreateMany<string>();

            //etc.
        }

        [Fact]
        public void ExplicitNumberOfItems()
        {
            //Arrange
            var fixture = new Fixture();

            IEnumerable<int> numbers = fixture.CreateMany<int>(6);

            //etc.
        }

        [Fact]

        public void AdingToExistingList()
        {
            //Arrange
            var fixture = new Fixture();
            var sut = new DebugMessageBuffer();

            fixture.AddManyTo<string>(sut.Messages, 10);

            //Act
            sut.WriteMessages();

            //Assert
            Assert.Equal(10, sut.MessagesWritten);
        }

        [Fact]

        public void AddingToExistingListWithCreatorFunction()
        {
            //Arrange
            var fixture = new Fixture();
            var sut = new DebugMessageBuffer();
            var rnd = new Random();

            fixture.AddManyTo(sut.Messages, () => rnd.Next().ToString());

            //Act
            sut.WriteMessages();

            //Assert
            Assert.Equal(10, sut.MessagesWritten);
        }
    }
}
