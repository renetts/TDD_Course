using Xunit;

namespace HelloWorldUnitTesting.XUnitTest
{
    public class HelloWorldXUnitTest
    {

        [Fact]
        public void Greet()
        {
            string expected = "Hello World";
            HelloWorld helloWorld = new HelloWorld();
            string actual = helloWorld.Greet("World");

            Xunit.Assert.True(expected == actual);
        }
    }
}

