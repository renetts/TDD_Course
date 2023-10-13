using System;

namespace HelloWorldUnitTesting.MSTest
{
    [TestClass]
    public class HelloWorldMSTest
	{
        [TestMethod]
        public void TestGreet()
        {
            string expected = "Hello World";
            HelloWorld helloWorld = new HelloWorld();
            string actual = helloWorld.Greet("World");
            Assert.AreEqual(expected, actual);
        }
    }
}