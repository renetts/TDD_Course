using System;
using NUnit.Framework;

namespace HelloWorldUnitTesting.NUnitTest
{
	public class HelloWorldNUnitTest
    {

        private HelloWorld helloWorld;

        public HelloWorldNUnitTest()
		{
		}

        [SetUp]
        public void Setup()
        {
            helloWorld = new HelloWorld();
        }

        [Test]
        public void TestGreet()
        {
            string expected = "Hello World";
            string actual = helloWorld.Greet("World");
            NUnit.Framework.Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

